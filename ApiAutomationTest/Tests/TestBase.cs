using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumAutomationTest.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.ObjectModel;

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

            driver.Manage().Window.Maximize();

            string currentWindowHandle = driver.CurrentWindowHandle;
            ReadOnlyCollection<string> windowHandles = driver.WindowHandles;

            foreach (string windowHandle in windowHandles)
            {
                if (windowHandle != currentWindowHandle)
                {

                    driver.SwitchTo().Window(windowHandle);
                    driver.Close();

                }
            }
            driver.SwitchTo().Window(currentWindowHandle);

        }

        [TearDown]
        public void TearDown()
        {
            //GetDriver().Quit();
            //TDriver.Dispose();
        }
    }
}
