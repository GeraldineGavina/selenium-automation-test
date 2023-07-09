using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAutomationTest.Pages
{

    public class LoginSignUpPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "div[class='signup-form'] h2")]
        private IWebElement newUserSignup;

        [FindsBy(How = How.CssSelector, Using = "input[data-qa='signup-name']")]
        private IWebElement signUpNameInput;

        [FindsBy(How = How.CssSelector, Using = "input[data-qa='signup-email']")]
        private IWebElement signUpEmailInput;
        
        [FindsBy(How = How.CssSelector, Using = "button[data-qa='signup-button']")]
        private IWebElement signUpButton;

        public LoginSignUpPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        public IWebElement GetNewUserSignup()
        {
            return newUserSignup;
        }

        public void FillSignUp(string name, string email)
        {
            signUpNameInput.SendKeys(name);
            signUpEmailInput.SendKeys(email);
            signUpButton.Click();
        }

        public EnterAccountInformationPage FillCorrectSignUp(string name, string email)
        {
            FillSignUp(name, email);
            return new EnterAccountInformationPage(driver);
        }
    }
}
