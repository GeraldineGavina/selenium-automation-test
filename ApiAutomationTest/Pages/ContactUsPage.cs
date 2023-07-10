using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAutomationTest.Pages
{
    public class ContactUsPage
    {
        IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "h2.title:nth-child(2)")]
        private IWebElement getInTouch;

        [FindsBy(How = How.Name, Using = "name")]
        private IWebElement nameInput;

        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement emailInput;

        [FindsBy(How = How.Name, Using = "subject")]
        private IWebElement subjectInput;

        [FindsBy(How = How.Id, Using = "message")]
        private IWebElement messageInput;

        [FindsBy(How = How.Name, Using = "upload_file")]
        private IWebElement uploadFileInput;

        [FindsBy(How = How.Name, Using = "submit")]
        private IWebElement submitButton;

        [FindsBy(How = How.CssSelector, Using = ".status.alert.alert-success")]
        private IWebElement alertSuccess;

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-success']")]
        private IWebElement homePageButton;


        public ContactUsPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        public IWebElement GetInTouch()
        {
            return getInTouch;
        }

        public ContactUsPage FillUpForm()
        {
            nameInput.SendKeys("estName");
            emailInput.SendKeys("abc@def.ghi");
            subjectInput.SendKeys("Test Subject Here");
            messageInput.SendKeys("Maganda naman sya ok lang matagal lang madeliver muntik pa nga ireturn sa seller buti na lang kinulit ko rider naligaw pa nga papunta samin. Seller is responsive. Well packed with bubble wrap and box. Will Order again. Fast Delivery. Will Order again. Salamat Shapi!");
            uploadFileInput.SendKeys("C:\\Users\\Staff\\source\\repos\\POMSelenium\\TestFiles");
            return this;

        }

        public ContactUsPage SubmitButtonClick()
        {
            submitButton.Click();
            return this;
        }
        public ContactUsPage OKButtonClick()
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            return this;
        }
        public IWebElement GetAlertSuccess()
        {
            return alertSuccess;
        }
        public HomePage HomePageButtonClick()
        {
            homePageButton.Click();
            return new HomePage(driver);
        }
    }
}
