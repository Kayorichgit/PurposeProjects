using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using PurposeProjects.Hooks;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurposeProjects.PageObjects
{
    public class BarsSnacksSoupsPageObj
    {
        public IWebDriver driver;

        private IWebElement hoverOnCategory => driver.FindElement(By.XPath("//*[@id=\"menu-item-5470\"]/a"));
        private By clickBarsSnacksAndSoup = By.XPath("(//*[contains(text(), 'Bars, Snacks & Soups')])[1]");
        //private By clickBarsSnacksAndSoup = By.XPath("(//a[@class='menu-link'][normalize-space()='Bars, Snacks & Soups'])[1]");
        private By clickPageNumber = By.XPath("//*[@id=\"main\"]/div/nav[2]/ul/li[2]/a");


        public BarsSnacksSoupsPageObj() 
        {
            driver = BaseTests.driver;
        }

        public void UserHoverOnCategory()
        {
            Thread.Sleep(5000);
            Actions actions = new Actions(driver);
            actions.MoveToElement(hoverOnCategory).Perform();
        }

        public void UserClickBarsSnacksAndSoup()
        {
            Thread.Sleep(5000);
            driver.FindElement(clickBarsSnacksAndSoup).Click();
        }

        public bool UserDirectedToBarSnacksSoupsPage()
        {
            return driver.Url.Contains("https://kafkaf.reteicons.com/product-category/bars-snacks-soups/");
        }

        public void ClickPageNumber() 
        {
            driver.FindElement(clickPageNumber).Click();
        }

        public bool UserDirectedToOtherPage()
        {
            return driver.Url.Contains("https://kafkaf.reteicons.com/product-category/bars-snacks-soups/page/2/");
        }



    }
}
