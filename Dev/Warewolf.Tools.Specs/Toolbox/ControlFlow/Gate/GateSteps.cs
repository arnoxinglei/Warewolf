﻿/*
*  Warewolf - Once bitten, there's no going back
*  Copyright 2019 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/

using Dev2;
using Dev2.Activities;
using Dev2.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using Warewolf.Data.Options;
using Warewolf.Data.Options.Enums;
using Warewolf.Tools.Specs.BaseTypes;

namespace Warewolf.Tools.Specs.Toolbox.ControlFlow.Gate
{
    [Binding]
    public class GateSteps : RecordSetBases
    {
        readonly ScenarioContext scenarioContext;
        readonly Guid RetryEntryPointId = Guid.NewGuid();
        readonly Guid ResumeEndpoint = Guid.NewGuid();

        public GateSteps(ScenarioContext scenarioContext)
            : base(scenarioContext)
        {
            this.scenarioContext = scenarioContext ?? throw new ArgumentNullException("scenarioContext");
            scenarioContext.Add("activity", CreateActivity());
        }

        protected override void BuildDataList()
        {
            scenarioContext.TryGetValue("variableList", out List<Tuple<string, string>> variableList);

            if (variableList == null)
            {
                variableList = new List<Tuple<string, string>>();
                scenarioContext.Add("variableList", variableList);
            }

            variableList.Add(new Tuple<string, string>(ResultVariable, ""));
            BuildShapeAndTestData();

            scenarioContext.TryGetValue("activity", out GateActivity gateActivity);
            
            gateActivity.DisplayName = "Gate 1";
            gateActivity.UniqueID = RetryEntryPointId.ToString();
            
            var nextGateActivity = CreateActivity();
            nextGateActivity.UniqueID = Guid.NewGuid().ToString();
            nextGateActivity.DisplayName = "Gate 2";
            
            gateActivity.NextNodes = new List<IDev2Activity> { nextGateActivity };
            nextGateActivity.NextNodes = new List<IDev2Activity> { nextGateActivity };

            var gateOneFlowStep = new FlowStep { Action = gateActivity };

            var gateTwoFlowStep = new FlowStep 
            { 
                Action = nextGateActivity,
                Next = gateOneFlowStep
            };

            TestStartNode = new FlowStep
            {
                Action = gateActivity, 
                Next = gateTwoFlowStep
            };
        }

        private GateActivity CreateActivity()
        {
            var noBackoffGateActivity = new GateActivity
            {
                GateFailure = GateFailureAction.StopOnError.ToString()
            };

            CreateGateOptions(noBackoffGateActivity);

            return noBackoffGateActivity;
        }

        private void CreateGateOptions(GateActivity noBackoffGateActivity)
        {
            var noBackoffAlgorithm = new RetryAlgorithmBase();

            var gateOptions = new GateOptions
            {
                Resume = YesNo.Yes,
                ResumeEndpoint = ResumeEndpoint,
                Count = 3,
                Strategy = noBackoffAlgorithm
            };

            noBackoffGateActivity.GateOptions = gateOptions;
        }

        [Given(@"I have the following conditions")]
        public void GivenIHaveTheFollowingConditions(Table table)
        {
            FillConditions(table);
        }

        void FillConditions(Table table)
        {
            var tableRows = table.Rows.ToList();

            foreach (TableRow tableRow in tableRows)
            {
                scenarioContext.TryGetValue("variableList", out List<Tuple<string, string>> variableList);

                if (variableList == null)
                {
                    variableList = new List<Tuple<string, string>>();
                    scenarioContext.Add("variableList", variableList);
                }
                variableList.Add(new Tuple<string, string>(tableRow[0], tableRow[1]));
            }
        }

        [Given(@"GateFailure has ""(.*)"" selected")]
        public void GivenGateFailureHasSelected(string gateFailure)
        {
            scenarioContext.TryGetValue("activity", out GateActivity gateActivity);
            gateActivity.GateFailure = gateFailure;
        }

        [Given(@"Gates has ""(.*)"" selected")]
        public void GivenGatesHasSelected(string retryEntryPointId)
        {
            scenarioContext.TryGetValue("activity", out GateActivity gateActivity);
            gateActivity.RetryEntryPointId = string.IsNullOrEmpty(retryEntryPointId) ? Guid.Empty : RetryEntryPointId;
        }

        [Given(@"GateRetryStrategy has ""(.*)"" selected")]
        public void GivenGateRetryStrategyHasSelected(string retryStrategy)
        {
            scenarioContext.TryGetValue("activity", out GateActivity gateActivity);

            switch (retryStrategy)
            {
                case "NoBackoff":
                    gateActivity.GateOptions.Strategy = new NoBackoff();
                    break;
                case "ConstantBackoff":
                    gateActivity.GateOptions.Strategy = null;
                    break;
            }
        }

        [Given(@"Increment is set to ""(.*)""")]
        public void GivenIncrementIsSetTo(int increment)
        {
            scenarioContext.TryGetValue("activity", out GateActivity gateActivity);
            if (gateActivity.GateOptions.Strategy is ConstantBackoff constantBackoff)
            {
                constantBackoff.Increment = increment;
            }
        }

        [Given(@"Resume is set to ""(.*)""")]
        public void GivenResumeIsSetTo(string resume)
        {
            scenarioContext.TryGetValue("activity", out GateActivity gateActivity);
            gateActivity.GateOptions.Resume = resume == "Yes" ? YesNo.Yes : YesNo.No;
        }

        [Given(@"the Gate tool is executed")]
        public void GivenTheGateToolIsExecuted()
        {
            BuildDataList();
            var result = ExecuteProcess(isDebug: true, throwException: false);
            scenarioContext.Add("result", result);
        }

        [Then(@"the execution has errors")]
        public void ThenTheExecutionHasErrors(Table table)
        {
            var result = scenarioContext.Get<IDSFDataObject>("result");
            var fetchErrors = result.Environment.FetchErrors();
            var tableRows = table.Rows.ToList();

            Assert.AreEqual(tableRows.Count, fetchErrors.Count());

            foreach (TableRow tableRow in tableRows)
            {
                var expectedError = tableRow["error"];
                var error = fetchErrors[0];

                Assert.AreEqual(expectedError, error);
            }
        }

    }
}
