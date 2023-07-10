using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Newtonsoft.Json;
using System.IO;
using SeleniumAutomationTest.Data;
using SeleniumAutomationTest.Utils;
using System.Xml.Linq;

namespace SeleniumAutomationTest.Pages
{

    public class LoginSignUpPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "div[class='signup-form'] h2")]
        private IWebElement newUserSignup;
        
        [FindsBy(How = How.CssSelector, Using = "div[class='login-form'] h2")]
        private IWebElement loginToYourAccount;

        [FindsBy(How = How.CssSelector, Using = "input[data-qa='signup-name']")]
        private IWebElement signUpNameInput;

        [FindsBy(How = How.CssSelector, Using = "input[data-qa='signup-email']")]
        private IWebElement signUpEmailInput;
        
        [FindsBy(How = How.CssSelector, Using = "button[data-qa='signup-button']")]
        private IWebElement signUpButton;

        [FindsBy(How = How.CssSelector, Using = "input[data-qa='login-email']")]
        private IWebElement loginEmailInput;

        [FindsBy(How = How.CssSelector, Using = "input[data-qa='login-password']")]
        private IWebElement loginPasswordInput;

        [FindsBy(How = How.CssSelector, Using = "button[data-qa='login-button']")]
        private IWebElement loginButton;

        [FindsBy(How = How.XPath, Using = "/html/body/section/div/div/div[1]/div/form/p")]
        private IWebElement errorLoginTxt;

        string jsonPath = "..\\..\\..\\Data\\user.json";

        [FindsBy(How = How.XPath, Using = "//section/div/div/div[3]/div/form/p")]
        private IWebElement emailAddressAlreadyExist;

        public LoginSignUpPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        public IWebElement GetNewUserSignup()
        {
            return newUserSignup;
        }
        public IWebElement GetLoginToYourAccount()
        {
            return loginToYourAccount;
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
            UserSignUp newUser = new UserSignUp();
            newUser.email = email;
            newUser.name = name;
            JSONUtil.WriteObjectToJsonFile(newUser, jsonPath);
            return new EnterAccountInformationPage(driver);
        }

        public LoggedHomePage FillCorrectLogin(string email, string password)
        {
            FillLogin(email, password);
            return new LoggedHomePage(driver);
        }

        private void FillLogin(String email, String password)
        {
            loginEmailInput.SendKeys(email);
            loginPasswordInput.SendKeys(password);
            loginButton.Click();
        }
        public LoginSignUpPage FillIncorrectLogin()
        {
            loginEmailInput.SendKeys("email"+Util.GenerateCurrentDateAndTime()+"@incorrect.com");
            loginPasswordInput.SendKeys("pass"+Util.GenerateCurrentDateAndTime());
            loginButton.Click();
            return this;
        }
        public IWebElement GetErrorLogin()
        {
            return errorLoginTxt;
        }

        public LoginSignUpPage FillIncorrectSignUp(string name, string email)
        {
            signUpNameInput.SendKeys(name);
            signUpEmailInput.SendKeys(email);
            signUpButton.Click();
            return this;

        }

        public IWebElement GetEmailAddressAlreadyExist()
        {
            return emailAddressAlreadyExist;
        }
    }
}
