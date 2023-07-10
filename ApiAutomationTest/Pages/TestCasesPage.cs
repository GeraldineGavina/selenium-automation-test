using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationTest.Pages
{
    public class TestCasesPage
    {
        IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "h2[class='title text-center'] b")]
        private IWebElement testCase;

        public TestCasesPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        public IWebElement GetTestCase()
        {
            return testCase;
        }
    }
}
