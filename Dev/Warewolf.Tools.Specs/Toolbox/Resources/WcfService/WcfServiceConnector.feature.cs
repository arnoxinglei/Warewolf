﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Warewolf.Tools.Specs.Toolbox.Resources.WcfService
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class WcfServiceConnectorFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "WcfServiceConnector.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "WcfServiceConnector", "\tIn Order to access an Wcf endpoint\r\n\tas a Warewolf user.", ProgrammingLanguage.CSharp, new string[] {
                        "Resources"});
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "WcfServiceConnector")))
            {
                global::Warewolf.Tools.Specs.Toolbox.Resources.WcfService.WcfServiceConnectorFeature.FeatureSetup(null);
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
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("create Wcf tool")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "WcfServiceConnector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Resources")]
        public virtual void CreateWcfTool()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("create Wcf tool", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("I open New Wcf Tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.Then("\"Sources\" wcf combobox is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 9
 testRunner.And("Selected wcf Source is null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("Selected wcf Method is Null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2819 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input",
                        "Default Value",
                        "Required Field",
                        "Empty Null"});
#line 11
 testRunner.And("wcf Inputs are", ((string)(null)), table2819, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2820 = new TechTalk.SpecFlow.Table(new string[] {
                        "Output",
                        "Output Alias"});
#line 13
 testRunner.And("wcf Outputs are", ((string)(null)), table2820, "And ");
#line 15
 testRunner.And("wcf Recordset is \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.And("there are \"no\" wcf validation errors of \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Create new wcf Tool and Select a Source")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "WcfServiceConnector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Resources")]
        public virtual void CreateNewWcfToolAndSelectASource()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create new wcf Tool and Select a Source", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
 testRunner.Given("I open New Wcf Tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
 testRunner.Then("\"Sources\" wcf combobox is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.And("Selected wcf Source is null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("Selected wcf Method is Null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2821 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input",
                        "Default Value",
                        "Required Field",
                        "Empty Null"});
#line 23
 testRunner.And("wcf Inputs are", ((string)(null)), table2821, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2822 = new TechTalk.SpecFlow.Table(new string[] {
                        "Output",
                        "Output Alias"});
#line 25
 testRunner.And("wcf Outputs are", ((string)(null)), table2822, "And ");
#line 27
 testRunner.And("wcf Recordset is \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("there are \"no\" wcf validation errors of \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.When("I select the wcf Source \"Echo\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then("\"Sources\" wcf combobox is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
 testRunner.And("Selected wcf Source is \"Echo\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And("Selected wcf Method is Null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2823 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input",
                        "Default Value",
                        "Required Field",
                        "Empty Null"});
#line 33
 testRunner.And("wcf Inputs are", ((string)(null)), table2823, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2824 = new TechTalk.SpecFlow.Table(new string[] {
                        "Output",
                        "Output Alias"});
#line 35
 testRunner.And("wcf Outputs are", ((string)(null)), table2824, "And ");
#line 37
 testRunner.And("wcf Recordset is \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("there are \"no\" wcf validation errors of \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Create new wcf Tool and Select a Action")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "WcfServiceConnector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Resources")]
        public virtual void CreateNewWcfToolAndSelectAAction()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create new wcf Tool and Select a Action", ((string[])(null)));
#line 40
this.ScenarioSetup(scenarioInfo);
#line 41
 testRunner.Given("I open New Wcf Tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 42
 testRunner.Then("\"Sources\" wcf combobox is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
 testRunner.And("Selected wcf Source is null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.And("Selected wcf Method is Null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2825 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input",
                        "Default Value",
                        "Required Field",
                        "Empty Null"});
#line 45
 testRunner.And("wcf Inputs are", ((string)(null)), table2825, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2826 = new TechTalk.SpecFlow.Table(new string[] {
                        "Output",
                        "Output Alias"});
#line 47
 testRunner.And("wcf Outputs are", ((string)(null)), table2826, "And ");
#line 49
 testRunner.And("wcf Recordset is \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And("there are \"no\" wcf validation errors of \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.When("I select the wcf Source \"Echo\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.Then("\"Sources\" wcf combobox is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 53
 testRunner.And("Selected wcf Source is \"Echo\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.And("I select the wcf Method \"GetPeople\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.Then("\"Sources\" wcf combobox is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
 testRunner.And("Selected wcf Source is \"Echo\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.And("Selected wcf Method is \"GetPeople\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2827 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table2827.AddRow(new string[] {
                        "Echome"});
            table2827.AddRow(new string[] {
                        "GetPeople"});
#line 58
 testRunner.And("the available wcf methods in the dropdown are", ((string)(null)), table2827, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2828 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input",
                        "Default Value",
                        "Required Field",
                        "Empty Null"});
            table2828.AddRow(new string[] {
                        "Name",
                        "",
                        "False",
                        "False"});
            table2828.AddRow(new string[] {
                        "Value",
                        "Value",
                        "False",
                        "false"});
#line 62
 testRunner.And("wcf Inputs are", ((string)(null)), table2828, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2829 = new TechTalk.SpecFlow.Table(new string[] {
                        "Output",
                        "Output Alias"});
#line 66
 testRunner.And("wcf Outputs are", ((string)(null)), table2829, "And ");
#line 68
 testRunner.And("wcf Recordset is \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.And("there are \"no\" wcf validation errors of \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.And("Validate wcf is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

