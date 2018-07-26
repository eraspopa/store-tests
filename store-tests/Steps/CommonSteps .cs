﻿using store_tests.Tools;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace store_tests.Steps
{
    using static Assert;
    using static StringAssert;
    using static BrowserTools;

    [Binding]
    public class CommonSteps
    {
        [BeforeFeature]
        public static void BeforeFeature()
        {
            LaunchChrome();
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Dispose();
        }

        [Then(@"I am redirected to the /(.*) url")]
        [Then(@"I am redirected to the correct (.*) url")]
        public void ThenIAmRedirectedToTheUrl(string url)
        {
            Contains(url, CurrentUrl);
        }

        [Then(@"the page has correct (.*) title")]
        public void ThenThePageHasCorrectTitle(string title)
        {
            AreEqual(PageTitle, title);
        }

        [Given(@"I am on the (.*) page")]
        [When(@"I navigate to the (.*) page")]
        public void WhenINavigateToThePage(string page)
        {
            Visit(page);
        }
    }
}