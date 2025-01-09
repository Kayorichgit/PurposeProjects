using OpenQA.Selenium;
using PurposeProjects.Hooks;
using PurposeProjects.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace PurposeProjects.StepDefinitions
{
    [Binding]
    public class ExploreMoreStepDefinitions
    {
        public IWebDriver driver = BaseTests.driver;
        ExploreMorePgObj exploreMorePgObj = new ExploreMorePgObj();


        [Given(@"that I am on Kafkaf webpage ""([^""]*)""")]
        public void GivenThatIAmOnKafkafWebpage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        [Given(@"I click on visit herbal store on the footer")]
        public void GivenIClickOnVisitHerbalStoreOnTheFooter()
        {
            exploreMorePgObj.UserClickOnVisitHerbalStore();
        }

        [Given(@"I am directed to herbal life store webpage")]
        public void GivenIAmDirectedToHerbalLifeStoreWebpage()
        {
            exploreMorePgObj.UserIsDirectedToHerbalStoreSite();
        }

        [Given(@"I click on visit juiceplus\+ store")]
        public void GivenIClickOnVisitJuiceplusStore()
        {
            exploreMorePgObj.UserClickOnJuiceplus();  
        }

        [Given(@"I am directed to juiceplus\+ webpage")]
        public void GivenIAmDirectedToJuiceplusWebpage()
        {
            exploreMorePgObj.UserIsDirectedToJuiceplusSite();
        }

        [When(@"I click on become a partner")]
        public void WhenIClickOnBecomeAPartner()
        {
           exploreMorePgObj.UserClickOnBecomePatner();
        }

        [Then(@"I should be directed to start your business page")]
        public void ThenIShouldBeDirectedToStartYourBusinessPage()
        {
            exploreMorePgObj.UserIsDirectedToBecomePatnerSite();
        }
    }
}
