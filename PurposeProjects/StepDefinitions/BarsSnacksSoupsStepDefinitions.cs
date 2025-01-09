using OpenQA.Selenium;
using PurposeProjects.Hooks;
using PurposeProjects.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace PurposeProjects.StepDefinitions
{
    [Binding]
    public class BarsSnacksSoupsStepDefinitions
    {
        public IWebDriver driver = BaseTests.driver;
        BarsSnacksSoupsPageObj barsSnacksSoupsPage = new BarsSnacksSoupsPageObj();

        [Given(@"I am on Kafkaf products website ""([^""]*)""")]
        public void GivenIAmOnKafkafProductsWebsite(string url)
        {
           driver.Navigate().GoToUrl(url);
        }

        [Given(@"I hover on categories to see drop downs")]
        public void GivenIHoverOnCategoriesToSeeDropDowns()
        {
            barsSnacksSoupsPage.UserHoverOnCategory(); 
        }

        [Given(@"I click on Bars, Snacks and Soups item")]
        public void GivenIClickOnBarsSnacksAndSoupsItem()
        {
            barsSnacksSoupsPage.UserClickBarsSnacksAndSoup();
        }

        [Given(@"I am directed to Bars, Snacks & Soups page")]
        public void GivenIAmDirectedToBarsSnacksSoupsPage()
        {
            barsSnacksSoupsPage.UserDirectedToBarSnacksSoupsPage().Should().BeTrue();
        }

        [When(@"I click any page number at the bottom of the page")]
        public void WhenIClickAnyPageNumberAtTheBottomOfThePage()
        {
            barsSnacksSoupsPage.ClickPageNumber();
        }

        [Then(@"Then I should be redirected to another page to see more products")]
        public void ThenThenIShouldBeRedirectedToAnotherPageToSeeMoreProducts()
        {
            barsSnacksSoupsPage.UserDirectedToOtherPage().Should().BeTrue();
        }
    }
}
