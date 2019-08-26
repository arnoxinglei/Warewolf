/*
*  Warewolf - Once bitten, there's no going back
*  Copyright 2019 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/

using Dev2;
using Dev2.Common.Interfaces.Data;
using Dev2.Common.Interfaces.Data.TO;
using Dev2.Common.Interfaces.DB;
using Dev2.Common.Interfaces.Resources;
using Dev2.Studio.Core.Interfaces;
using Dev2.Studio.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Warewolf.Core;
using Warewolf.Options;
using Warewolf.UI;

namespace Warewolf.Trigger.Queue.Tests
{
    [TestClass]
    public class TriggerQueueViewTests
    {
        [TestMethod]
        [TestCategory(nameof(TriggerQueueView))]
        [Owner("Pieter Terblanche")]
        public void TriggerQueueView_QueueSources()
        {
            var queueSource1 = new Mock<IResource>();
            var queueSource2 = new Mock<IResource>();

            var expectedList = new List<IResource>
            {
                queueSource1.Object, queueSource2.Object
            };

            var mockServer = new Mock<IServer>();
            var mockResourceRepository = new Mock<IResourceRepository>();
            mockResourceRepository.Setup(resourceRepository => resourceRepository.FindResourcesByType<IQueueSource>(mockServer.Object)).Returns(expectedList);

            mockServer.Setup(server => server.ResourceRepository).Returns(mockResourceRepository.Object);

            var triggerQueueView = new TriggerQueueView(mockServer.Object);

            Assert.IsNotNull(triggerQueueView.QueueSources);
            Assert.IsNull(triggerQueueView.SelectedQueueSource);

            Assert.IsNotNull(triggerQueueView.QueueSources);
            Assert.AreEqual(2, triggerQueueView.QueueSources.Count);
        }

        [TestMethod]
        [TestCategory(nameof(TriggerQueueView))]
        [Owner("Pieter Terblanche")]
        public void TriggerQueueView_DeadLetterQueueSources()
        {
            var queueSource1 = new Mock<IResource>();
            var queueSource2 = new Mock<IResource>();

            var expectedList = new List<IResource>
            {
                queueSource1.Object, queueSource2.Object
            };

            var mockServer = new Mock<IServer>();
            var mockResourceRepository = new Mock<IResourceRepository>();
            mockResourceRepository.Setup(resourceRepository => resourceRepository.FindResourcesByType<IQueueSource>(mockServer.Object)).Returns(expectedList);

            mockServer.Setup(server => server.ResourceRepository).Returns(mockResourceRepository.Object);

            var triggerQueueView = new TriggerQueueView(mockServer.Object);

            Assert.IsNotNull(triggerQueueView.DeadLetterQueueSources);
            Assert.IsNull(triggerQueueView.SelectedDeadLetterQueueSource);

            Assert.IsNotNull(triggerQueueView.DeadLetterQueueSources);
            Assert.AreEqual(2, triggerQueueView.DeadLetterQueueSources.Count);
        }

        private static List<IOption> SetupOptionsView()
        {
            var expectedOptionBool = new OptionBool
            {
                Name = "bool",
                Value = false
            };
            var expectedOptionInt = new OptionInt
            {
                Name = "int",
                Value = 10
            };
            var expectedOptionAutocompletebox = new OptionAutocomplete
            {
                Name = "auto",
                Value = "new text"
            };
            var expectedOptions = new List<IOption>
            {
                expectedOptionBool,
                expectedOptionInt,
                expectedOptionAutocompletebox
            };
            return expectedOptions;
        }

        [TestMethod]
        [TestCategory(nameof(TriggerQueueView))]
        [Owner("Pieter Terblanche")]
        public void TriggerQueueView_QueueNames()
        {
            var queueSource1 = new Mock<IResource>();

            string[] tempValues = new string[3];
            tempValues[0] = "value1";
            tempValues[1] = "value2";
            tempValues[2] = "value3";

            var expectedQueueNames = new Dictionary<string, string[]>
            {
                { "QueueNames", tempValues }
            };

            List<IOption> expectedOptions = SetupOptionsView();

            var mockServer = new Mock<IServer>();
            var mockResourceRepository = new Mock<IResourceRepository>();
            mockResourceRepository.Setup(resourceRepository => resourceRepository.FindAutocompleteOptions(mockServer.Object, queueSource1.Object)).Returns(expectedQueueNames);
            mockResourceRepository.Setup(resourceRepository => resourceRepository.FindOptions(mockServer.Object, queueSource1.Object)).Returns(expectedOptions);

            mockServer.Setup(server => server.ResourceRepository).Returns(mockResourceRepository.Object);

            var triggerQueueView = new TriggerQueueView(mockServer.Object)
            {
                SelectedQueueSource = queueSource1.Object
            };

            Assert.IsNotNull(triggerQueueView.SelectedQueueSource);
            Assert.AreEqual(queueSource1, triggerQueueView.SelectedQueueSource);
            Assert.IsNotNull(triggerQueueView.QueueNames);
            Assert.AreEqual(3, triggerQueueView.QueueNames.Count);
            Assert.AreEqual("value1", triggerQueueView.QueueNames[0].Value);
            Assert.AreEqual("value2", triggerQueueView.QueueNames[1].Value);
            Assert.AreEqual("value3", triggerQueueView.QueueNames[2].Value);

            Assert.AreEqual(3, triggerQueueView.Options.Count);

            var optionOne = triggerQueueView.Options[0].DataContext as OptionBool;
            Assert.IsNotNull(optionOne);
            Assert.AreEqual("bool", optionOne.Name);
            Assert.IsFalse(optionOne.Value);
            Assert.IsTrue(optionOne.Default);

            var optionTwo = triggerQueueView.Options[1].DataContext as OptionInt;
            Assert.IsNotNull(optionTwo);
            Assert.AreEqual("int", optionTwo.Name);
            Assert.AreEqual(10, optionTwo.Value);
            Assert.AreEqual(0, optionTwo.Default);
        }

        [TestMethod]
        [TestCategory(nameof(TriggerQueueView))]
        [Owner("Pieter Terblanche")]
        public void TriggerQueueView_DeadLetterQueues()
        {
            var queueSource1 = new Mock<IResource>();

            string[] tempValues = new string[3];
            tempValues[0] = "value1";
            tempValues[1] = "value2";
            tempValues[2] = "value3";

            var expectedQueueNames = new Dictionary<string, string[]>
            {
                { "QueueNames", tempValues }
            };

            List<IOption> expectedOptions = SetupOptionsView();

            var mockApplicationAdapter = new Mock<IApplicationAdaptor>();
            mockApplicationAdapter.Setup(p => p.TryFindResource(It.IsAny<string>())).Verifiable();
            CustomContainer.Register(mockApplicationAdapter.Object);

            var mockServer = new Mock<IServer>();
            var mockResourceRepository = new Mock<IResourceRepository>();
            mockResourceRepository.Setup(resourceRepository => resourceRepository.FindAutocompleteOptions(mockServer.Object, queueSource1.Object)).Returns(expectedQueueNames);
            mockResourceRepository.Setup(resourceRepository => resourceRepository.FindOptions(mockServer.Object, queueSource1.Object)).Returns(expectedOptions);

            mockServer.Setup(server => server.ResourceRepository).Returns(mockResourceRepository.Object);

            var triggerQueueView = new TriggerQueueView(mockServer.Object)
            {
                SelectedDeadLetterQueueSource = queueSource1.Object
            };

            Assert.IsNotNull(triggerQueueView.SelectedDeadLetterQueueSource);
            Assert.AreEqual(queueSource1, triggerQueueView.SelectedDeadLetterQueueSource);
            Assert.IsNotNull(triggerQueueView.DeadLetterQueues);
            Assert.AreEqual(3, triggerQueueView.DeadLetterQueues.Count);
            Assert.AreEqual("value1", triggerQueueView.DeadLetterQueues[0].Value);
            Assert.AreEqual("value2", triggerQueueView.DeadLetterQueues[1].Value);
            Assert.AreEqual("value3", triggerQueueView.DeadLetterQueues[2].Value);

            Assert.AreEqual(3, triggerQueueView.DeadLetterOptions.Count);

            var optionOne = triggerQueueView.DeadLetterOptions[0].DataContext as OptionBool;
            Assert.IsNotNull(optionOne);
            Assert.AreEqual("bool", optionOne.Name);
            Assert.IsFalse(optionOne.Value);
            Assert.IsTrue(optionOne.Default);

            //var optionOneTemplate = triggerQueueView.DeadLetterOptions[0].DataTemplate;
            mockApplicationAdapter.Verify(model => model.TryFindResource("OptionBoolStyle"), Times.Once());

            var optionTwo = triggerQueueView.DeadLetterOptions[1].DataContext as OptionInt;
            Assert.IsNotNull(optionTwo);
            Assert.AreEqual("int", optionTwo.Name);
            Assert.AreEqual(10, optionTwo.Value);
            Assert.AreEqual(0, optionTwo.Default);

            //var optionTwoTemplate = triggerQueueView.DeadLetterOptions[1].DataTemplate;
            mockApplicationAdapter.Verify(model => model.TryFindResource("OptionIntStyle"), Times.Once());

            var optionThree = triggerQueueView.DeadLetterOptions[2].DataContext as OptionAutocomplete;
            Assert.IsNotNull(optionThree);
            Assert.AreEqual("auto", optionThree.Name);
            Assert.AreEqual("new text", optionThree.Value);
            Assert.IsNull(optionThree.Suggestions);
            Assert.AreEqual("", optionThree.Default);

            //var optionThreeTemplate = triggerQueueView.DeadLetterOptions[2].DataTemplate;
            mockApplicationAdapter.Verify(model => model.TryFindResource("OptionAutocompleteStyle"), Times.Once());
        }

        [TestMethod]
        [Owner("Pieter Terblanche")]
        [TestCategory(nameof(TriggerQueueView))]
        public void TriggerQueueView_Equals_Other_IsNull_Expect_False()
        {
            var mockServer = new Mock<IServer>();

            var triggerQueueView = new TriggerQueueView(mockServer.Object);
            var equals = triggerQueueView.Equals(null);
            Assert.IsFalse(equals);
        }

        [TestMethod]
        [Owner("Pieter Terblanche")]
        [TestCategory(nameof(TriggerQueueView))]
        public void TriggerQueueView_ReferenceEquals_Match_Expect_True()
        {
            var mockServer = new Mock<IServer>();
            var triggerQueueView = new TriggerQueueView(mockServer.Object)
            {
                Concurrency = 1
            };
            var otherTriggerQueueView = triggerQueueView;
            var equals = triggerQueueView.Equals(otherTriggerQueueView);
            Assert.IsTrue(equals);
        }

        [TestMethod]
        [Owner("Pieter Terblanche")]
        [TestCategory(nameof(TriggerQueueView))]
        public void TriggerQueueView_Equals_MisMatch_Expect_False()
        {
            var mockServer = new Mock<IServer>();

            var resourceId = Guid.NewGuid();
            var queueSinkResourceId = Guid.NewGuid();

            var mockOption = new Mock<IOption>();
            var option = new OptionViewForTesting(mockOption.Object);
            var mockInputs = new Mock<ICollection<IServiceInput>>();

            var triggerQueueView = new TriggerQueueView(mockServer.Object)
            {
                QueueSourceId = resourceId,
                QueueName = "Queue",
                WorkflowName = "Workflow",
                Concurrency = 100,
                UserName = "Bob",
                Password = "123456",
                Options = new List<OptionView> { option },
                QueueSinkId = queueSinkResourceId,
                DeadLetterQueue = "DeadLetterQueue",
                DeadLetterOptions = new List<OptionView> { option },
                Inputs = mockInputs.Object
            };

            var otherTriggerQueueView = new TriggerQueueView(mockServer.Object)
            {
                Concurrency = 2
            };
            var equals = triggerQueueView.Equals(otherTriggerQueueView);
            Assert.IsFalse(equals);
        }

        [TestMethod]
        [Owner("Pieter Terblanche")]
        [TestCategory(nameof(TriggerQueueView))]
        public void TriggerQueueView_Defaults_For_Coverage_To_Remove()
        {
            var mockServer = new Mock<IServer>();
            var mockErrorResultTO = new Mock<IErrorResultTO>();
            var resourceId = Guid.NewGuid();
            var triggerQueueView = new TriggerQueueView(mockServer.Object)
            {
                TriggerId = resourceId,
                ResourceId = resourceId,
                OldQueueName = "OldName",
                Enabled = true,
                Errors = mockErrorResultTO.Object,
                TriggerQueueName = "TriggerQueueName",
                NameForDisplay = "NameForDisplay",
                IsNewQueue = true
            };

            Assert.AreEqual(resourceId, triggerQueueView.TriggerId);
            Assert.AreEqual(resourceId, triggerQueueView.ResourceId);
            Assert.IsFalse(triggerQueueView.IsDirty);
            Assert.AreEqual("OldName", triggerQueueView.OldQueueName);
            Assert.IsTrue(triggerQueueView.Enabled);
            Assert.IsNotNull(triggerQueueView.Errors);
            Assert.IsTrue(triggerQueueView.IsNewQueue);
            Assert.AreEqual("TriggerQueueName", triggerQueueView.TriggerQueueName);
            Assert.AreEqual("NameForDisplay", triggerQueueView.NameForDisplay);
            Assert.IsTrue(triggerQueueView.IsNewQueue);
        }

        [TestMethod]
        [Owner("Pieter Terblanche")]
        [TestCategory(nameof(TriggerQueueView))]
        public void TriggerQueueView_Item_IsDirty_True()
        {
            var mockServer = new Mock<IServer>();
            var resourceId = Guid.NewGuid();
            var triggerQueueView = new TriggerQueueView(mockServer.Object)
            {
                ResourceId = resourceId,
                OldQueueName = "OldName",
                Enabled = true,
                TriggerQueueName = "TriggerQueueName",
                IsNewQueue = true
            };

            var triggerQueueViewItem = new TriggerQueueView(mockServer.Object)
            {
                ResourceId = resourceId,
                OldQueueName = "OldName",
                Enabled = true,
                TriggerQueueName = "TriggerQueueName",
                IsNewQueue = true,
                Item = triggerQueueView
            };

            Assert.AreEqual("TriggerQueueName *", triggerQueueViewItem.NameForDisplay);
        }

        [TestMethod]
        [Owner("Pieter Terblanche")]
        [TestCategory(nameof(TriggerQueueView))]
        public void TriggerQueueView_Item_IsDirty_False()
        {
            var mockServer = new Mock<IServer>();
            var resourceId1 = Guid.NewGuid();
            var resourceId2 = Guid.NewGuid();
            var triggerQueueView = new TriggerQueueView(mockServer.Object)
            {
                ResourceId = resourceId1,
                OldQueueName = "OldName",
                Enabled = true,
                TriggerQueueName = "TriggerQueueName",
                IsNewQueue = true
            };

            var triggerQueueViewItem = new TriggerQueueView(mockServer.Object)
            {
                ResourceId = resourceId2,
                OldQueueName = "OldName",
                Enabled = true,
                TriggerQueueName = "TriggerQueueName",
                IsNewQueue = true,
                Item = triggerQueueView
            };

            Assert.AreEqual("TriggerQueueName", triggerQueueViewItem.NameForDisplay);
        }

        [TestMethod]
        [TestCategory(nameof(TriggerQueueView))]
        [Owner("Pieter Terblanche")]
        public void TriggerQueueView_WorkflowName()
        {
            var mockServer = new Mock<IServer>();
            var triggerQueueView = new TriggerQueueView(mockServer.Object);

            Assert.IsNull(triggerQueueView.WorkflowName);

            var workflowName = "Workflow1";
            triggerQueueView.WorkflowName = workflowName;

            Assert.AreEqual(workflowName, triggerQueueView.WorkflowName);
        }

        [TestMethod]
        [TestCategory(nameof(TriggerQueueView))]
        [Owner("Pieter Terblanche")]
        public void TriggerQueueView_Concurrency()
        {
            var mockServer = new Mock<IServer>();
            var triggerQueueView = new TriggerQueueView(mockServer.Object);

            Assert.AreEqual(0, triggerQueueView.Concurrency);

            var concurrency = 5;
            triggerQueueView.Concurrency = concurrency;

            Assert.AreEqual(concurrency, triggerQueueView.Concurrency);
        }

        [TestMethod]
        [TestCategory(nameof(TriggerQueueView))]
        [Owner("Pieter Terblanche")]
        public void TriggerQueueView_UserName()
        {
            var mockServer = new Mock<IServer>();
            var triggerQueueView = new TriggerQueueView(mockServer.Object);

            //------------Execute Test---------------------------
            Assert.AreEqual("", triggerQueueView.UserName);

            triggerQueueView.UserName = "someAccountName";
            //------------Assert Results-------------------------
            Assert.AreEqual("someAccountName", triggerQueueView.UserName);
        }

        [TestMethod]
        [TestCategory(nameof(TriggerQueueView))]
        [Owner("Pieter Terblanche")]
        public void TriggerQueueView_Password()
        {
            var mockServer = new Mock<IServer>();
            var triggerQueueView = new TriggerQueueView(mockServer.Object);

            //------------Execute Test---------------------------
            Assert.AreEqual("", triggerQueueView.Password);
            triggerQueueView.Password = "somePassword";
            //------------Assert Results-------------------------
            Assert.AreEqual("somePassword", triggerQueueView.Password);
        }

        [TestMethod]
        [TestCategory(nameof(TriggerQueueView))]
        [Owner("Pieter Terblanche")]
        public void TriggerQueueView_QueueEvents_Inputs()
        {
            var mockServer = new Mock<IServer>();
            var triggerQueueView = new TriggerQueueView(mockServer.Object);

            var inputs = new ObservableCollection<IServiceInput>
            {
                new ServiceInput("name1", "value1"),
                new ServiceInput("name2", "value2")
            };

            triggerQueueView.Inputs = inputs;

            var inputsAsList = triggerQueueView.Inputs.ToList();

            Assert.AreEqual(2, triggerQueueView.Inputs.Count);
            Assert.AreEqual("name1", inputsAsList[0].Name);
            Assert.AreEqual("value1", inputsAsList[0].Value);
            Assert.AreEqual("name2", inputsAsList[1].Name);
            Assert.AreEqual("value2", inputsAsList[1].Value);
        }

        [TestMethod]
        [TestCategory(nameof(TriggerQueueView))]
        [Owner("Pieter Terblanche")]
        public void TriggerQueueView_QueueEvents_VerifyCommand()
        {
            var mockServer = new Mock<IServer>();

            var triggerQueueView = new TriggerQueueView(mockServer.Object);
            Assert.IsNull(triggerQueueView.VerifyResults);
            Assert.IsFalse(triggerQueueView.IsVerifying);
            Assert.IsFalse(triggerQueueView.IsVerifyResultsEmptyRows);

            triggerQueueView.VerifyCommand.Execute(null);

            Assert.IsTrue(triggerQueueView.VerifyResultsAvailable);
            Assert.IsFalse(triggerQueueView.IsVerifyResultsEmptyRows);
            Assert.IsFalse(triggerQueueView.IsVerifying);
            Assert.IsTrue(triggerQueueView.VerifyPassed);
            Assert.IsFalse(triggerQueueView.VerifyFailed);
        }
    }

    public class OptionViewForTesting : OptionView
    {
        public OptionViewForTesting(IOption option)
            : base(option)
        {
        }
    }
}