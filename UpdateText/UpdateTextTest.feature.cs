﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UpdateText
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("UpdateTextTest")]
    public partial class UpdateTextTestFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UpdateTextTest.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UpdateTextTest", "\tIn order to avoid silly mistakes\r\n\tAs a update text tool user\r\n\tI want to be tol" +
                    "d the this tool can correctly update my translated text", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("First time generate translation file")]
        public virtual void FirstTimeGenerateTranslationFile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("First time generate translation file", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 7
 testRunner.Given("I have following text in source file", "# title\r\n\r\nhello world\r\n\r\n##section1\r\nlorel anaditum\r\n\r\n## section2 -- with a lon" +
                    "g name even <span class=\"active\">span</span> in it\r\n**lorel anaditum yanaghay**", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 19
 testRunner.And("I have following text in my translation file", "", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.When("I try to sync", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
 testRunner.Then("I should get following text in my translation file", "<!--\r\n# title\r\n\r\nhello world\r\n\r\n-->\r\n\r\n<!--\r\n##section1\r\nlorel anaditum\r\n\r\n-->\r\n\r" +
                    "\n<!--\r\n## section2 -- with a long name even <span class=\"active\">span</span> in " +
                    "it\r\n**lorel anaditum yanaghay**\r\n-->", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update translation file")]
        public virtual void UpdateTranslationFile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update translation file", ((string[])(null)));
#line 44
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 45
 testRunner.Given("I have following text in source file", @"# title

hello world

##section1

Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.

## section2 -- with a long name even <span class=""active"">span</span> in it
**lorel anaditum yanaghay**", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 58
 testRunner.And("I have following text in my translation file", @"# title

hello world
-->

title translation

<!--
##section1

abnormal things.
-->

section1 translation

<!--
## section2 -- with a long name even <span class=""active"">span</span> in it
**lorel anaditum yanaghay**
-->

section2 translation", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.When("I try to sync", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 83
 testRunner.Then("I should get following text in my translation file", @"<!--
# title

hello world

-->

title translation

<!--
##section1

Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.

-->

section1 translation

<!--
## section2 -- with a long name even <span class=""active"">span</span> in it
**lorel anaditum yanaghay**
-->

section2 translation", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("update with out of order section")]
        public virtual void UpdateWithOutOfOrderSection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("update with out of order section", ((string[])(null)));
#line 111
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 112
 testRunner.Given("I have following text in source file", "# title\r\n\r\nhello world\r\n\r\n## section0 which added later\r\n\r\n##section1\r\nlorel anad" +
                    "itum\r\n\r\n## section2 -- with a long name even <span class=\"active\">span</span> in" +
                    " it\r\n**lorel anaditum yanaghay**", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 126
 testRunner.And("I have following text in my translation file", "<!--\r\n# title\r\n\r\nhello world\r\n-->\r\n\r\n<!--\r\n##section1\r\nlorel anaditum\r\n-->\r\n\r\n<!-" +
                    "-\r\n## section2 -- with a long name even <span class=\"active\">span</span> in it\r\n" +
                    "**lorel anaditum yanaghay**\r\n-->", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 144
 testRunner.When("I try to sync", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 145
 testRunner.Then("I should get following text in my translation file", @"<!--
# title

hello world
-->

title translation

<!--
## section0 which added later
-->

<!--
##section1
lorel anaditum
-->

section1 translation

<!--
## section2 -- with a long name even <span class=""active"">span</span> in it
**lorel anaditum yanaghay**
-->

section2 translation", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 173
 testRunner.Given("I have following text in source file", @"# title

hello world

##section1

Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.

## section2 -- with a long name even <span class=""active"">span</span> in it
**lorel anaditum yanaghay**", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 186
 testRunner.When("I try to sync", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 187
 testRunner.Then("I should get following text in my translation file", @"<!--
# title

hello world
-->

title translation

<!--
##section1

Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
-->

section1 translation

<!--
## section2 -- with a long name even <span class=""active"">span</span> in it
**lorel anaditum yanaghay**
-->

section2 translation", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
