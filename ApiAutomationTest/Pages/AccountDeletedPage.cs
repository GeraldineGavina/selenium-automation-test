using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAutomationTest.Pages
{
    public class AccountDeletedPage
    {
        IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "h2[data-qa='account-deleted']")]
        private IWebElement accountDeleted;

        [FindsBy(How = How.CssSelector, Using = "a[data-qa='continue-button']")]
        private IWebElement continueButton;


        public AccountDeletedPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        public IWebElement GetAccountDeleted()
        {
            return accountDeleted;
        }

        public HomePage ContinueButtonClick()
        {
            continueButton.Click();
            return new HomePage(driver);
        }
    }
}
