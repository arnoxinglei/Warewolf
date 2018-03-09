﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Dev2.Activities.Specs.Merge
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class MergeExecutionFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MergeExecution.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "MergeExecution", "\tIn order to avoid silly mistakes\r\n\tAs a math idiot\r\n\tI want to be told the sum o" +
                    "f two numbers", ProgrammingLanguage.CSharp, new string[] {
                        "WorkflowMerging"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "MergeExecution")))
            {
                global::Dev2.Activities.Specs.Merge.MergeExecutionFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Merge AssignOnlyWithNoOutput Workflow with Same Version")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MergeExecution")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WorkflowMerging")]
        public virtual void MergeAssignOnlyWithNoOutputWorkflowWithSameVersion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Merge AssignOnlyWithNoOutput Workflow with Same Version", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
  testRunner.Given("I Load workflow \"AssignOnlyWithNoOutput\" from \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
  testRunner.And("I Load workflow \"AssignOnlyWithNoOutput\" from \"Remote Connection Integration\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
  testRunner.When("Merge Window is opened with remote \"AssignOnlyWithNoOutput\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
  testRunner.Then("Current workflow contains \"2\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
  testRunner.Then("Current workflow contains \"1\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
  testRunner.And("Different workflow contains \"2\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
  testRunner.And("Different workflow contains \"1\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
  testRunner.And("Merge conflicts count is \"3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
  testRunner.And("Merge variable conflicts is false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
  testRunner.And("Merge window has no Conflicting tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Merge VersionHelloWorld Workflow")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MergeExecution")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WorkflowMerging")]
        public virtual void MergeVersionHelloWorldWorkflow()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Merge VersionHelloWorld Workflow", ((string[])(null)));
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
  testRunner.Given("I Load workflow \"MergeHelloWorld\" from \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
  testRunner.And("I Load workflow \"VersionHelloWorld\" from \"Remote Connection Integration\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
  testRunner.When("Merge Window is opened with remote \"VersionHelloWorld\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
  testRunner.Then("Current workflow contains \"6\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
  testRunner.Then("Current workflow contains \"5\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
  testRunner.And("Different workflow contains \"6\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
  testRunner.And("Different workflow contains \"5\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
  testRunner.And("Merge conflicts count is \"11\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
  testRunner.And("Merge variable conflicts is false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
  testRunner.And("Merge window has \"1\" Conflicting tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Merge WorkFlowWithOneScalar different input mapping")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MergeExecution")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WorkflowMerging")]
        public virtual void MergeWorkFlowWithOneScalarDifferentInputMapping()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Merge WorkFlowWithOneScalar different input mapping", ((string[])(null)));
#line 32
this.ScenarioSetup(scenarioInfo);
#line 33
  testRunner.Given("I Load workflow \"WorkFlowWithOneScalar\" from \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
  testRunner.And("I Load workflow version of WorkFlowWithOneScalar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
  testRunner.When("Merge Window is opened with local \"WorkFlowWithOneScalar\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
  testRunner.Then("Current workflow contains \"2\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 37
  testRunner.Then("Current workflow contains \"1\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
  testRunner.And("Different workflow contains \"2\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
  testRunner.And("Different workflow contains \"1\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
  testRunner.And("Merge conflicts count is \"3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
  testRunner.And("Merge variable conflicts is false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
  testRunner.And("Merge window has \"2\" Conflicting tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Merge WorkFlowWithOneRecordSet different input mapping")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MergeExecution")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WorkflowMerging")]
        public virtual void MergeWorkFlowWithOneRecordSetDifferentInputMapping()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Merge WorkFlowWithOneRecordSet different input mapping", ((string[])(null)));
#line 44
this.ScenarioSetup(scenarioInfo);
#line 45
  testRunner.Given("I Load workflow \"WorkFlowWithOneRecordSet\" from \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 46
  testRunner.And("I Load workflow version of WorkFlowWithOneRecordSet", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
  testRunner.When("Merge Window is opened with local \"WorkFlowWithOneRecordSet\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
  testRunner.Then("Current workflow contains \"2\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
  testRunner.Then("Current workflow contains \"1\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 50
  testRunner.And("Different workflow contains \"2\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
  testRunner.And("Different workflow contains \"1\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
  testRunner.And("Merge conflicts count is \"3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
  testRunner.And("Merge variable conflicts is false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
  testRunner.And("Merge window has \"2\" Conflicting tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Merge WorkFlowWithOneObject different input mapping")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MergeExecution")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WorkflowMerging")]
        public virtual void MergeWorkFlowWithOneObjectDifferentInputMapping()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Merge WorkFlowWithOneObject different input mapping", ((string[])(null)));
#line 56
this.ScenarioSetup(scenarioInfo);
#line 57
  testRunner.Given("I Load workflow \"WorkFlowWithOneObject\" from \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 58
  testRunner.And("I Load workflow version of WorkFlowWithOneObject", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
  testRunner.When("Merge Window is opened with local \"WorkFlowWithOneObject\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
  testRunner.Then("Current workflow contains \"2\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
  testRunner.Then("Current workflow contains \"1\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
  testRunner.And("Different workflow contains \"2\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
  testRunner.And("Different workflow contains \"1\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
  testRunner.And("Merge conflicts count is \"3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
  testRunner.And("Merge variable conflicts is false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
  testRunner.And("Merge window has \"2\" Conflicting tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Merge Workflow with Assign tool As First Tool And Split tool as Second tool count" +
            "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MergeExecution")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WorkflowMerging")]
        public virtual void MergeWorkflowWithAssignToolAsFirstToolAndSplitToolAsSecondToolCount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Merge Workflow with Assign tool As First Tool And Split tool as Second tool count" +
                    "", ((string[])(null)));
#line 68
this.ScenarioSetup(scenarioInfo);
#line 69
  testRunner.Given("I Load workflow \"WorkflowWithDifferentToolSequence\" from \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 70
  testRunner.And("I Load workflow \"WorkflowWithDifferentToolSequence\" from \"Remote Connection Integ" +
                    "ration\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
  testRunner.When("Merge Window is opened with remote \"WorkflowWithDifferentToolSequence\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
  testRunner.Then("Current workflow contains \"3\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 73
  testRunner.Then("Current workflow contains \"2\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 74
  testRunner.And("Different workflow contains \"3\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
  testRunner.And("Different workflow contains \"2\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
  testRunner.And("Merge conflicts count is \"5\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
  testRunner.And("Merge variable conflicts is false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Merge Workflow Containing SequenceTool With Different Children Counts Equals One")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MergeExecution")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WorkflowMerging")]
        public virtual void MergeWorkflowContainingSequenceToolWithDifferentChildrenCountsEqualsOne()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Merge Workflow Containing SequenceTool With Different Children Counts Equals One", ((string[])(null)));
#line 79
this.ScenarioSetup(scenarioInfo);
#line 80
  testRunner.Given("I Load workflow \"WorkflowWithSequenceToolWithDifferentChildren\" from \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 81
  testRunner.And("I Load workflow version \"1\" of \"WorkflowWithSequenceToolWithDifferentChildren\" fr" +
                    "om \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
  testRunner.When("Merge Window is opened with local \"WorkflowWithSequenceToolWithDifferentChildren\"" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
  testRunner.Then("Current workflow contains \"2\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 84
  testRunner.Then("Current workflow contains \"1\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 85
  testRunner.And("Different workflow contains \"2\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
  testRunner.And("Different workflow contains \"1\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
  testRunner.And("Merge conflicts count is \"3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
  testRunner.And("Merge variable conflicts is false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Merge Workflow Containing SequenceTool With Different Children Sequence")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MergeExecution")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WorkflowMerging")]
        public virtual void MergeWorkflowContainingSequenceToolWithDifferentChildrenSequence()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Merge Workflow Containing SequenceTool With Different Children Sequence", ((string[])(null)));
#line 90
this.ScenarioSetup(scenarioInfo);
#line 91
  testRunner.Given("I Load workflow \"WorkflowWithSequenceToolWithChildrenInDifferentOrder\" from \"loca" +
                    "lhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 92
  testRunner.And("I Load workflow version \"1\" of \"WorkflowWithSequenceToolWithChildrenInDifferentOr" +
                    "der\" from \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
  testRunner.When("Merge Window is opened with local \"WorkflowWithSequenceToolWithChildrenInDifferen" +
                    "tOrder\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 94
  testRunner.Then("Current workflow contains \"2\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 95
  testRunner.Then("Current workflow contains \"1\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 96
  testRunner.And("Different workflow contains \"2\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
  testRunner.And("Different workflow contains \"1\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
  testRunner.And("Merge conflicts count is \"3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
  testRunner.And("Merge variable conflicts is false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Merge Workflow Containing Same tools But disconnected Arms")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MergeExecution")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WorkflowMerging")]
        public virtual void MergeWorkflowContainingSameToolsButDisconnectedArms()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Merge Workflow Containing Same tools But disconnected Arms", ((string[])(null)));
#line 101
this.ScenarioSetup(scenarioInfo);
#line 102
  testRunner.Given("I Load workflow \"WorkflowWithAssignToolsWithDisconnectedArms\" from \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 103
  testRunner.And("I Load workflow \"WorkflowWithAssignToolsWithDisconnectedArms\" from \"Remote Connec" +
                    "tion Integration\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
  testRunner.When("Merge Window is opened with remote \"WorkflowWithAssignToolsWithDisconnectedArms\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 105
  testRunner.Then("Current workflow contains \"3\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 106
  testRunner.Then("Current workflow contains \"1\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 107
  testRunner.And("Different workflow contains \"3\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
  testRunner.And("Different workflow contains \"1\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
  testRunner.And("Merge conflicts count is \"4\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
  testRunner.And("Merge variable conflicts is false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Merge Workflow Containing Removed tool with same Variable List")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MergeExecution")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WorkflowMerging")]
        public virtual void MergeWorkflowContainingRemovedToolWithSameVariableList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Merge Workflow Containing Removed tool with same Variable List", ((string[])(null)));
#line 112
this.ScenarioSetup(scenarioInfo);
#line 113
  testRunner.Given("I Load workflow \"MergeRemovedTool\" from \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 114
  testRunner.And("I Load workflow version of MergeRemovedTool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
  testRunner.When("Merge Window is opened with local \"MergeRemovedTool\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 116
  testRunner.Then("Current workflow contains \"4\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 117
  testRunner.Then("Current workflow contains \"3\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 118
  testRunner.And("Different workflow contains \"4\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
  testRunner.And("Different workflow contains \"3\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
  testRunner.And("Merge conflicts count is \"7\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
  testRunner.And("Merge variable conflicts is false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
  testRunner.And("I select Current Tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
  testRunner.And("I select Current Arm", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
  testRunner.And("I select Current Arm", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
  testRunner.Then("Save is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Merge Workflow Containing Switch tool")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MergeExecution")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WorkflowMerging")]
        public virtual void MergeWorkflowContainingSwitchTool()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Merge Workflow Containing Switch tool", ((string[])(null)));
#line 127
this.ScenarioSetup(scenarioInfo);
#line 128
  testRunner.Given("I Load workflow \"MergeSwitchTool\" from \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 129
  testRunner.And("I Load workflow version of MergeSwitchTool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 130
  testRunner.When("Merge Window is opened with local \"MergeSwitchTool\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 131
  testRunner.Then("Current workflow contains \"4\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 132
  testRunner.Then("Current workflow contains \"3\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 133
  testRunner.And("Different workflow contains \"4\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
  testRunner.And("Different workflow contains \"3\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
  testRunner.And("Merge conflicts count is \"7\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
  testRunner.And("Merge variable conflicts is false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
  testRunner.And("conflict \"2\" Current matches tool \"[[a]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
  testRunner.And("conflict \"2\" Different matches tool \"Switch\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
  testRunner.And("conflict \"3\" Current Connector matches tool \"Switch : 1 -> Assign (0)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 140
  testRunner.And("conflict \"3\" Different Connector matches tool is null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 141
  testRunner.And("conflict \"4\" Current Connector matches tool \"Switch : Default -> Assign (0)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 142
  testRunner.And("conflict \"4\" Different Connector matches tool is null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
  testRunner.And("conflict \"5\" Current matches tool \"Assign (0)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 144
  testRunner.And("conflict \"6\" Current matches tool \"Assign (0)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
  testRunner.And("I select Current Tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 146
  testRunner.And("I select Current Arm", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 147
  testRunner.And("I select Current Tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
  testRunner.And("I select Current Arm", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 149
  testRunner.Then("Save is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Merge Workflow Containing Position Change tools")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MergeExecution")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WorkflowMerging")]
        public virtual void MergeWorkflowContainingPositionChangeTools()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Merge Workflow Containing Position Change tools", ((string[])(null)));
#line 151
this.ScenarioSetup(scenarioInfo);
#line 152
  testRunner.Given("I Load workflow \"MergeToolPositionChange\" from \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 153
  testRunner.And("I Load workflow version conflict MergeToolPositionChange", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 154
  testRunner.When("Merge Window is opened with local \"MergeToolPositionChange\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 155
  testRunner.Then("Current workflow contains \"3\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 156
  testRunner.Then("Current workflow contains \"3\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 157
  testRunner.And("Different workflow contains \"3\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 158
  testRunner.And("Different workflow contains \"3\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 159
  testRunner.And("Current workflow header is \"MergeToolPositionChange\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 160
  testRunner.And("Different workflow header is \"MergeToolPositionChange v.2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 161
  testRunner.And("Merge conflicts count is \"6\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 162
  testRunner.And("Merge variable conflicts is false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 163
  testRunner.And("conflict \"0\" Current matches tool \"Start\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 164
  testRunner.And("conflict \"0\" Different matches tool \"Start\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 165
  testRunner.And("conflict \"1\" Current Connector matches tool \"Start -> Data Merge (0)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 166
  testRunner.And("conflict \"1\" Different Connector matches tool \"Start -> Assign (0)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 167
  testRunner.And("conflict \"2\" Current matches tool \"Data Merge (0)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 168
  testRunner.And("conflict \"2\" Different matches tool \"Data Merge (0)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 169
  testRunner.And("conflict \"3\" Current Connector matches tool \"Data Merge (0) -> Assign (0)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 170
  testRunner.And("conflict \"3\" Different Connector matches tool is null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 171
  testRunner.And("conflict \"4\" Current matches tool \"Assign (0)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 172
  testRunner.And("conflict \"4\" Different matches tool \"Assign (0)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 173
  testRunner.And("conflict \"5\" Current Connector matches tool is null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 174
  testRunner.And("conflict \"5\" Different Connector matches tool \"Assign (0) -> Data Merge (0)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 175
  testRunner.And("I select Current Tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 176
  testRunner.And("I select Current Arm", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 177
  testRunner.And("I select Different Arm", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 178
  testRunner.Then("Save is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Merge Workflow Version Containing Position Change tools")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MergeExecution")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WorkflowMerging")]
        public virtual void MergeWorkflowVersionContainingPositionChangeTools()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Merge Workflow Version Containing Position Change tools", ((string[])(null)));
#line 180
this.ScenarioSetup(scenarioInfo);
#line 181
  testRunner.Given("I Load workflow \"MergeToolPositionChange\" from \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 182
  testRunner.And("I Load workflow version conflict MergeToolPositionChange", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 183
  testRunner.When("Merge Window is opened with local version \"MergeToolPositionChange\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 184
  testRunner.Then("Current workflow contains \"3\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 185
  testRunner.Then("Current workflow contains \"3\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 186
  testRunner.And("Different workflow contains \"3\" tools", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 187
  testRunner.And("Different workflow contains \"3\" connectors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 188
  testRunner.And("Current workflow header is \"MergeToolPositionChange v.2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 189
  testRunner.And("Different workflow header is \"MergeToolPositionChange\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 190
  testRunner.And("Merge conflicts count is \"6\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 191
  testRunner.And("Merge variable conflicts is false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 192
  testRunner.And("conflict \"0\" Current matches tool \"Start\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 193
  testRunner.And("conflict \"0\" Different matches tool \"Start\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 194
  testRunner.And("conflict \"1\" Current Connector matches tool \"Start -> Assign (0)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 195
  testRunner.And("conflict \"1\" Different Connector matches tool \"Start -> Data Merge (0)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 196
  testRunner.And("conflict \"2\" Current matches tool \"Assign (0)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 197
  testRunner.And("conflict \"2\" Different matches tool \"Assign (0)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 198
  testRunner.And("conflict \"3\" Current Connector matches tool \"Assign (0) -> Data Merge (0)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 199
  testRunner.And("conflict \"3\" Different Connector matches tool is null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 200
  testRunner.And("conflict \"4\" Current matches tool \"Data Merge (0)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 201
  testRunner.And("conflict \"4\" Different matches tool \"Data Merge (0)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 202
  testRunner.And("conflict \"5\" Current Connector matches tool is null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 203
  testRunner.And("conflict \"5\" Different Connector matches tool \"Data Merge (0) -> Assign (0)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 204
  testRunner.And("I select Different Tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 205
  testRunner.And("I select Different Arm", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 206
  testRunner.And("I select Current Arm", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 207
  testRunner.Then("Save is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Merge Validate All tools are mapped")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MergeExecution")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WorkflowMerging")]
        public virtual void MergeValidateAllToolsAreMapped()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Merge Validate All tools are mapped", ((string[])(null)));
#line 210
this.ScenarioSetup(scenarioInfo);
#line 211
  testRunner.Given("I Load All tools and expect all tools to be mapped", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
