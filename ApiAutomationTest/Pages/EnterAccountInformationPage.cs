using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumAutomationTest.Tests;
using SeleniumAutomationTest.Utils;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
namespace SeleniumAutomationTest.Pages
{
    public class EnterAccountInformationPage 
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//b[contains(.,'Enter Account Information')]")]
        private IWebElement enterAccountInformation;

        [FindsBy(How = How.Id, Using = "id_gender1")]
        private IWebElement titleRadioButton;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement passwordInput;

        [FindsBy(How = How.Id, Using = "days")]
        private IWebElement daysSelect;

        [FindsBy(How = How.Id, Using = "months")]
        private IWebElement monthsSelect;

        [FindsBy(How = How.Id, Using = "years")]
        private IWebElement yearsSelect;

        [FindsBy(How = How.Id, Using = "newsletter")]
        private IWebElement newsLetterCheckBox;

        [FindsBy(How = How.Id, Using = "optin")]
        private IWebElement specialOfferCheckBox;

        [FindsBy(How = How.Id, Using = "fist_name")]
        private IWebElement firstNameInput;

        [FindsBy(How = How.Id, Using = "last_name")]
        private IWebElement lastNameInput;

        [FindsBy(How = How.Id, Using = "company")]
        private IWebElement companyInput;

        [FindsBy(How = How.Id, Using = "address1")]
        private IWebElement address1Input;

        [FindsBy(How = How.Id, Using = "address2")]
        private IWebElement address2Input;

        [FindsBy(How = How.Id, Using = "country")]
        private IWebElement countrySelect;

        [FindsBy(How = How.Id, Using = "state")]
        private IWebElement stateInput;

        [FindsBy(How = How.Id, Using = "city")]
        private IWebElement cityInput;

        [FindsBy(How = How.Id, Using = "zipcode")]
        private IWebElement zipcodeInput;

        [FindsBy(How = How.Id, Using = "mobile_number")]
        private IWebElement LmobileNumberInput;

        [FindsBy(How = How.Id, Using = "last_name")]
        private IWebElement LastNameInput;

        [FindsBy(How = How.CssSelector, Using = "button[data-qa='create-account']")]
        private IWebElement createAccountButton;

        public EnterAccountInformationPage (IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        public IWebElement GetEnterAccountInformation()
        {
            return enterAccountInformation;
        }

        public AccountCreatedPage FillAccountDetails()
        {
            string password = "pass" + Util.GenerateCurrentDateAndTime();
            titleRadioButton.Click();
            passwordInput.SendKeys(password);
            SelectElement days = new SelectElement(daysSelect);
            days.SelectByValue("1");
            return null;
        }
    }
}
