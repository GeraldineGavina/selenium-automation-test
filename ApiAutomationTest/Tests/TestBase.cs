using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumAutomationTest.Utils;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumAutomationTest.Tests
{
    public class TestBase
    {
        private static readonly ThreadLocal<IWebDriver> TDriver = new ThreadLocal<IWebDriver>();

        public static IWebDriver GetDriver()
        {
            return TDriver.Value;
        }

        [SetUp]
        public void Setup()
        {
            //string url = ConfigurationManager.AppSettings["baseUrl"].ToString();
            string url = "https://automationexercise.com/";
            IWebDriver driver = BrowserManager.DoBrowserSetup();
            TDriver.Value = driver;
            GetDriver().Navigate().GoToUrl(url);
        }

        [TearDown]
        public void TearDown()
        {
            //GetDriver().Quit();
            //TDriver.Dispose();
        }
    }
}
