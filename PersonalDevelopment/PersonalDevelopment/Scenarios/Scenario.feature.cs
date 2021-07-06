﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace PersonalDevelopment.Scenarios
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Scenarios for restrictions feature")]
    public partial class ScenariosForRestrictionsFeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Scenario.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Scenarios for restrictions feature", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Cancel out of the Restrictions page")]
        [NUnit.Framework.CategoryAttribute("Edge")]
        public virtual void CancelOutOfTheRestrictionsPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cancel out of the Restrictions page", null, new string[] {
                        "Edge"});
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 testRunner.Given("I have logged into Confluence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.And("I click on the Confluence link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.When("I click on my space", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
 testRunner.And("I am redirected to the Overview page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.And("I navigate to the restrictions page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.When("I click the cancel button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("I am redirected to the Overview page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add restriction - anyone can view & edit")]
        [NUnit.Framework.CategoryAttribute("Edge")]
        public virtual void AddRestriction_AnyoneCanViewEdit()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add restriction - anyone can view & edit", null, new string[] {
                        "Edge"});
#line 14
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 15
 testRunner.Given("I have logged into Confluence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
 testRunner.And("I click on the Confluence link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.When("I click on my space", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.And("I am redirected to the Overview page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("I navigate to the restrictions page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.When("I choose the permission", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.Then("I am able to add the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add restriction - anyone can view & some can edit")]
        [NUnit.Framework.CategoryAttribute("Edge")]
        public virtual void AddRestriction_AnyoneCanViewSomeCanEdit()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add restriction - anyone can view & some can edit", null, new string[] {
                        "Edge"});
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 25
 testRunner.Given("I have logged into Confluence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
 testRunner.And("I click on the Confluence link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.When("I click on my space", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.And("I am redirected to the Overview page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("I navigate to the restrictions page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.When("I choose the permission for this scenario", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.And("I choose the user for this scenario", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.Then("I am able to add the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Delete user - anyone can view & some can edit restriction")]
        [NUnit.Framework.CategoryAttribute("Edge")]
        public virtual void DeleteUser_AnyoneCanViewSomeCanEditRestriction()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete user - anyone can view & some can edit restriction", null, new string[] {
                        "Edge"});
#line 35
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 36
 testRunner.Given("I have logged into Confluence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 37
 testRunner.And("I click on the Confluence link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.When("I click on my space", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.And("I am redirected to the Overview page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("I navigate to the restrictions page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.When("I click on the remove button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
 testRunner.Then("the user is removed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Modify restriction after adding user - specific people can view or edit restricti" +
            "on")]
        [NUnit.Framework.CategoryAttribute("Edge")]
        public virtual void ModifyRestrictionAfterAddingUser_SpecificPeopleCanViewOrEditRestriction()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Modify restriction after adding user - specific people can view or edit restricti" +
                    "on", null, new string[] {
                        "Edge"});
#line 45
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 46
 testRunner.Given("I have logged into Confluence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 47
 testRunner.And("I click on the Confluence link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.When("I click on my space", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
 testRunner.And("I am redirected to the Overview page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And("I navigate to the restrictions page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.When("I choose the permission to a specific user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.And("I choose the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.And("click on edit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.Then("I am able to add the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Remove user - specific people can view or edit restriction")]
        [NUnit.Framework.CategoryAttribute("Edge")]
        public virtual void RemoveUser_SpecificPeopleCanViewOrEditRestriction()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Remove user - specific people can view or edit restriction", null, new string[] {
                        "Edge"});
#line 57
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 58
 testRunner.Given("I have logged into Confluence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 59
 testRunner.And("I click on the Confluence link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.When("I click on my space", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.And("I am redirected to the Overview page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And("I navigate to the restrictions page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.When("I click on the remove button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
 testRunner.Then("the user is removed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

