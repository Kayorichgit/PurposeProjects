using OpenQA.Selenium;
using PurposeProjects.Hooks;
using PurposeProjects.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace PurposeProjects.StepDefinitions
{
    [Binding]
    public class QuickLinksStepDefinitions
    {
        public IWebDriver driver = BaseTests.driver;
        QuickLinksPageObj quickLinksPageObj = new QuickLinksPageObj();


        [Given(@"I am using Kafkaf website ""([^""]*)""")]
        public void GivenIAmUsingKafkafWebsite(string url)
        {
           driver.Navigate().GoToUrl(url);
        }

        [Given(@"I click on About us link")]
        public void GivenIClickOnAboutUsLink()
        {
            quickLinksPageObj.UserClickOnAboutUs();
        }

        [Given(@"I am directed to About us page")]
        public void GivenIAmDirectedToAboutUsPage()
        {
            quickLinksPageObj.UserDirectedToAboutUsPage().Should().BeTrue();
        }

        [Given(@"I click on Contact us link")]
        public void GivenIClickOnContactUsLink()
        {
            quickLinksPageObj.UserClickOnContac();
        }

        [Given(@"I am directed to Contact us page")]
        public void GivenIAmDirectedToContactUsPage()
        {
           quickLinksPageObj.UserIsDirectedToContactPage().Should().BeTrue();
        }

        [Given(@"I click FAQ link")]
        public void GivenIClickFAQLink()
        {
            quickLinksPageObj.UserClickOnFaq();
        }

        [Given(@"I am directed to FAQ page")]
        public void GivenIAmDirectedToFAQPage()
        {
            quickLinksPageObj.UserIsDirectedToFaqPage().Should().BeTrue();
        }

        [When(@"I click on All Product")]
        public void WhenIClickOnAllProduct()
        {
            quickLinksPageObj.UserClickOnAllProduct();
        }

        [Then(@"I must be directed to All Product page")]
        public void ThenIMustBeDirectedToAllProductPage()
        {
            quickLinksPageObj.UserIsDirectedToAllProductPage().Should().BeTrue();
        }
    }
}
