﻿using System.Activities.Presentation.Model;
using System.Activities.Statements;
using System.Activities.Presentation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Dev2.Studio.Core.Activities.Utils;
using System.Activities.Presentation;
using Dev2;
using Dev2.Studio.Interfaces;
using Dev2.Common;
using Dev2.Utilities;

namespace Warewolf.MergeParser
{
    public class ServiceDifferenceParser : IServiceDifferenceParser
    {
        private readonly IActivityParser _activityParser;
        public (List<ModelItem> nodeList, Flowchart flowchartDiff) CurrentDifferences { get; private set; }
        public (List<ModelItem> nodeList, Flowchart flowchartDiff) Differences { get; private set; }

        private ModelItem GetCurrentModelItemUniqueId(IEnumerable<IDev2Activity> items, IDev2Activity activity)
        {
            if (activity == null) return default;
            foreach (var modelItem in items)
                if (modelItem.UniqueID.Equals(activity.UniqueID))
                    return ModelItemUtils.CreateModelItem(modelItem);
            return default;
        }

        public ServiceDifferenceParser()
            : this(CustomContainer.Get<IActivityParser>())
        {

        }
        public ServiceDifferenceParser(IActivityParser activityParser)
        {
            VerifyArgument.IsNotNull(nameof(activityParser), activityParser);
            _activityParser = activityParser;
        }

        public List<(Guid uniqueId, ModelItem current, ModelItem difference, bool conflict)> GetDifferences(IContextualResourceModel current, IContextualResourceModel difference)
        {
            var conflictList = new List<(Guid uniqueId, ModelItem current, ModelItem difference, bool conflict)>();
            CurrentDifferences = GetNodes(current);
            Differences = GetNodes(difference);
            var parsedCurrent = GetActivity(CurrentDifferences.flowchartDiff);
            var parsedDifference = GetActivity(Differences.flowchartDiff);
            var flatCurrent = _activityParser.ParseToLinkedFlatList(parsedCurrent).ToList();
            var flatDifference = _activityParser.ParseToLinkedFlatList(parsedDifference).ToList();

            var equalItems = flatCurrent.Intersect<IDev2Activity>(flatDifference, new Dev2ActivityComparer()).ToList();
            var nodesDifferentInMergeHead = flatCurrent.Except(flatDifference, new Dev2ActivityComparer()).ToList();
            var nodesDifferentInHead = flatDifference.Except(flatCurrent, new Dev2ActivityComparer()).ToList();
            var allDifferences = nodesDifferentInMergeHead.Union(nodesDifferentInHead, new Dev2ActivityComparer());

            foreach (var item in equalItems)
            {
                if (item is null)
                {
                    continue;
                }
                var currentModelItemUniqueId = GetCurrentModelItemUniqueId(flatCurrent, item);

                var equalItem = (Guid.Parse(item.UniqueID), currentModelItemUniqueId, currentModelItemUniqueId, false);
                conflictList.Add(equalItem);
            }

            foreach (var item in allDifferences)
            {
                var currentModelItemUniqueId = GetCurrentModelItemUniqueId(flatCurrent, item);
                var differences = GetCurrentModelItemUniqueId(flatDifference, item);
                var diffItem = (Guid.Parse(item.UniqueID), currentModelItemUniqueId, differences, true);
                conflictList.Add(diffItem);
            }
            return conflictList;
        }

        private IDev2Activity GetActivity(Flowchart modelItem)
        {
            var act = _activityParser.Parse(new List<IDev2Activity>(), modelItem);
            return act;
        }

        private (List<ModelItem> nodeList, Flowchart flowchartDiff) GetNodes(IContextualResourceModel resourceModel)
        {
            var wd = new WorkflowDesigner();
            var xaml = resourceModel.WorkflowXaml;

            var workspace = GlobalConstants.ServerWorkspaceID;
            var msg = resourceModel.Environment.ResourceRepository.FetchResourceDefinition(resourceModel.Environment, workspace, resourceModel.ID, false);
            if (msg != null)
            {
                xaml = msg.Message;
            }

            if (xaml == null || xaml.Length == 0)
            {
                throw new Exception($"Could not find resource definition for {resourceModel.ResourceName}");
            }
            wd.Text = xaml.ToString();
            wd.Load();

            var modelService = wd.Context.Services.GetService<ModelService>();
            var nodeList = modelService.Find(modelService.Root, typeof(FlowNode)).ToList();
            var workflowHelper = new WorkflowHelper();
            var flowchartDiff = workflowHelper.EnsureImplementation(modelService).Implementation as Flowchart;
            // ReSharper disable once RedundantAssignment assuming this is for disposing
            wd = null;
            return (nodeList, flowchartDiff);
        }

    }
}
