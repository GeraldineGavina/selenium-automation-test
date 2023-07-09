using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumAutomationTest.Pages;
using NUnit.Framework;
using SeleniumAutomationTest.Utils;
using OpenQA.Selenium;

namespace SeleniumAutomationTest.Tests
{
    public class TestCase1 : TestBase
    {
        private string name = "name" + Util.GenerateCurrentDateAndTime();
        private string email = "email" + Util.GenerateCurrentDateAndTime() + "@test.com";

        [Test]
        public void RegisterUser()
        {
            VerifyHomePageIsVisible();
            VerifyNewUserSignUpIsVisible();
            VerifyThatEnterAccountInformationIsVisible();
            VerifyThatAccountCreatedIsVisible();
        }


        public void VerifyHomePageIsVisible()
        {
            Boolean homepageIsVisible = new HomePage(GetDriver())
                .HomePageIsVisible()
                .Displayed;
            Assert.IsTrue(homepageIsVisible);
        }

        
        public void VerifyNewUserSignUpIsVisible()
        {   
            string newUserTxt = new HomePage(GetDriver())
                .SignUpLinkClick()
                .GetNewUserSignup()
                .Text;
            Assert.AreEqual("New User Signup!", newUserTxt);
        }

        
        public void VerifyThatEnterAccountInformationIsVisible()
        {
            string accountInfoText = new LoginSignUpPage(GetDriver())
                .FillCorrectSignUp(name, email)
                .GetEnterAccountInformation().Text;
            Assert.AreEqual("ENTER ACCOUNT INFORMATION", accountInfoText);
        }

        public void VerifyThatAccountCreatedIsVisible()
        {
            new EnterAccountInformationPage(GetDriver())
                .FillAccountDetails();

                
        }


    }
}
     