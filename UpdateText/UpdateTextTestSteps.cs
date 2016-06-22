using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace UpdateText
{
    [Binding]
    public class UpdateTextTestSteps
    {
        [Given(@"I have following text in source file")]
        public static void GivenIHaveFollowingTextInSourceFile(string multilineText)
        {
            ScenarioContext.Current.Set(multilineText, "source");
        }

        [Given(@"I have following text in my translation file")]
        public static void GivenIHaveFollowingTextInMyTranslationFile(string multilineText)
        {
            ScenarioContext.Current.Set(multilineText, "translation");
        }

        [When(@"I try to sync")]
        public static void WhenITryToSync()
        {
            var source = ScenarioContext.Current.Get<string>("source");
            var translation = ScenarioContext.Current.Get<string>("translation");
            var output = Core.Update(source, translation);
            ScenarioContext.Current.Set(output, "translation");
        }

        [Then(@"I should get following text in my translation file")]
        public static void ThenIShouldGetFollowingTextInMyTranslationFile(string multilineText)
        {
            var translation = ScenarioContext.Current.Get<string>("translation");
            Assert.AreEqual(multilineText, translation);
        }
    }
}
