﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.7.1.0
//      SpecFlow Generator Version:1.7.0.0
//      Runtime Version:4.0.30319.239
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace Lockdown.AcceptanceTests.MVC
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.7.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Operation Discovery")]
    public partial class OperationDiscoveryFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Operation Discovery.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Operation Discovery", "In order to authorise calls to MVC controller actions\r\nthe authorisation service " +
                    "will discover controller actions\r\nand create operations for them", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Single Controller")]
        public virtual void SingleController()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Single Controller", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("I have a MVC application called Achme.MyApp");
#line 8
 testRunner.And("the application has a controller called Home Controller");
#line 9
 testRunner.And("the Home Controller has an action called Index");
#line 10
 testRunner.And("the Home Controller has an action called About");
#line 11
 testRunner.When("I discover operations in the application");
#line 12
 testRunner.Then("an operation called Achme.MyApp.Controllers.HomeController.Index should be found");
#line 13
 testRunner.Then("an operation called Achme.MyApp.Controllers.HomeController.About should be found");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Single Controller with Post Action")]
        public virtual void SingleControllerWithPostAction()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Single Controller with Post Action", ((string[])(null)));
#line 16
this.ScenarioSetup(scenarioInfo);
#line 17
 testRunner.Given("I have a MVC application");
#line 18
 testRunner.And("the application has a controller called Home Controller");
#line 19
 testRunner.And("the Home Controller has an action called Index");
#line 20
 testRunner.And("the Home Controller has an POST action called Index");
#line 21
 testRunner.When("I discover operations in the application");
#line 22
 testRunner.Then("an operation called Achme.MyApp.Controllers.HomeController.Index should be found");
#line 23
 testRunner.Then("an operation called Achme.MyApp.Controllers.HomeController.Index[POST] should be " +
                    "found");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Two Controllers")]
        public virtual void TwoControllers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Two Controllers", ((string[])(null)));
#line 25
this.ScenarioSetup(scenarioInfo);
#line 26
 testRunner.Given("I have a MVC application called Achme.MyApp");
#line 27
 testRunner.And("the application has a controller called Home Controller");
#line 28
 testRunner.And("the Home Controller has an action called Index");
#line 29
 testRunner.And("the application has a controller called Product Controller");
#line 30
 testRunner.And("the Product Controller has an action called Index");
#line 31
 testRunner.When("I discover operations in the application");
#line 32
 testRunner.Then("an operation called Achme.MyApp.Controllers.HomeController.Index should be found");
#line 33
 testRunner.Then("an operation called Achme.MyApp.Controllers.ProductController.About should be fou" +
                    "nd");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#endregion
