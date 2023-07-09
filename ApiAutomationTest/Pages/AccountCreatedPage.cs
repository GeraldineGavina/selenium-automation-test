using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V112.Network;
using SeleniumExtras.PageObjects;

namespace SeleniumAutomationTest.Pages
{
    public class AccountCreatedPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "h2[data-qa='account-created']")]
        private IWebElement accountCreated;

        [FindsBy(How = How.CssSelector, Using = "a[data-qa='continue-button']")]
        private IWebElement continueButton;


        public AccountCreatedPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        public IWebElement getAccountCreated()
        {
            return accountCreated;
        }

        public LoggedHomePage continueButtonClick()
        {
            continueButton.Click();
            return new LoggedHomePage(driver);
        }
    }
}
