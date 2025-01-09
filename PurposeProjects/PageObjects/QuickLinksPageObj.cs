using OpenQA.Selenium;
using PurposeProjects.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurposeProjects.PageObjects
{
    public class QuickLinksPageObj
    {
        public IWebDriver driver;

        private By clickOnAboutUs = By.XPath("//*[@id=\"block-27\"]/ul/li[1]/a");
        private By clickOnContact = By.CssSelector("#block-27 > ul > li:nth-child(2) > mark > a");
        private By clickFaq = By.XPath("//*[@id=\"block-27\"]/ul/li[3]/mark/a");
        private By clickAllProduct = By.XPath("//*[@id=\"block-27\"]/ul/li[4]/mark/a");


        public QuickLinksPageObj()
        {
            driver = BaseTests.driver;
        }

        public void UserClickOnAboutUs()
        {
            driver.FindElement(clickOnAboutUs).Click();
        }

        public bool UserDirectedToAboutUsPage()
        {
            return driver.Url.Contains("https://kafkaf.reteicons.com/about/");
        }

        public void UserClickOnContac()
        {
            driver.FindElement(clickOnContact).Click();
        }

        public bool UserIsDirectedToContactPage()
        {
            return driver.Url.Contains("https://kafkaf.reteicons.com/contact/");
        }

        public void UserClickOnFaq() 
        {
            driver.FindElement(clickFaq).Click();
        }

        public bool UserIsDirectedToFaqPage()
        {
            return driver.Url.Contains("https://kafkaf.reteicons.com/faq/");
        }

        public void UserClickOnAllProduct()
        {
            driver.FindElement(clickAllProduct).Click();
        }

        public bool UserIsDirectedToAllProductPage()
        {
            return driver.Url.Contains("https://kafkaf.reteicons.com/all-products/");
        }

    }
}
