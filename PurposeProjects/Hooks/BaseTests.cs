using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace PurposeProjects.Hooks
{
    [Binding]
    public class BaseTests
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            
        }

        

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
        }
    }
}