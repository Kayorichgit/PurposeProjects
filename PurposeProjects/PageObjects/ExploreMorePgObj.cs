using OpenQA.Selenium;
using PurposeProjects.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurposeProjects.PageObjects
{
    public class ExploreMorePgObj
    {

        public IWebDriver driver;

        private By clickOnVisitHerbalStore = By.XPath("//*[@id=\"menu-item-3770\"]/a");
        private By clickOnJuicePlus = By.XPath("//a[normalize-space()='Visit Juiceplus+ store']");
        private By clickOnBecomePatner = By.XPath("//*[@id=\"menu-item-3772\"]");



        public ExploreMorePgObj() 
        {
            driver = BaseTests.driver;
        }

        public void UserClickOnVisitHerbalStore()
        {
            driver.FindElement(clickOnVisitHerbalStore).Click();
        }

        public bool UserIsDirectedToHerbalStoreSite()
        {
            return driver.Url.Contains("https://kafkaf.herbalife.com/en-gb/u");
        }

        public void UserClickOnJuiceplus()
        {

            driver.Navigate().Back();
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0, 1000);");
            driver.FindElement(clickOnJuicePlus).Click();
        }

        public bool UserIsDirectedToJuiceplusSite()
        {
            return driver.Url.Contains("https://uk.juiceplus.com/");
        }

        public void UserClickOnBecomePatner()
        {
            driver.Navigate().Back();
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0, 1000);");
            driver.FindElement(clickOnBecomePatner).Click();
        }

        public bool UserIsDirectedToBecomePatnerSite()
        {
            return driver.Url.Contains("https://kafkaf.reteicons.com/start-your-business/");
        }


    }
}
