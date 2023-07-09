using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace SeleniumAutomationTest.Utils
{
    public class SeleniumHelper
    {
        public static void WaitForElementToExist(IWebDriver driver, By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(locator));
        }

        public static void WaitForElementToBeVisible(IWebDriver driver, By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public static void WaitForNotToEmptyList(IWebDriver driver, By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(driver1 => driver.FindElements(locator).Count > 0);
        }

        public static void WaitForElementToBeClickable(IWebDriver driver, IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        private static string TakeScreenshot(IWebDriver driver)
        {
            Random random = new Random();
            int randomNumber = random.Next(1000);
            ITakesScreenshot screenshot = (ITakesScreenshot)driver;
            Screenshot screenshotFile = screenshot.GetScreenshot();
            string path = $"src/test/resources/screenshots/screenshot{randomNumber}.png";
            screenshotFile.SaveAsFile(path);
            return path;
        }
    }
}
