using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAutomationTest.Pages
{
    public class LoggedHomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//*[@id='header']/div/div/div/div[2]/div/ul/li[10]/a/b")]
        private IWebElement username;

        [FindsBy(How = How.CssSelector, Using = "a[href='/logout']")]
        private IWebElement logoutButton;

        [FindsBy(How = How.CssSelector, Using = "a[href='/delete_account']")]
        private IWebElement deleteAccountButton;

        public LoggedHomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        public IWebElement LogoutButton()
        {
            return username;
        }
        
        public AccountDeletedPage deleteAccountButtonClick()
        {
            deleteAccountButton.Click();
            return new AccountDeletedPage(driver);
        }

        public LoginSignUpPage logoutButtonClick()
        {
            logoutButton.Click();
            return new LoginSignUpPage(driver);
        }


    }
}
 