﻿using System;
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
            VerifyThatLoggedInAsUsernameIsVisible();
            VerifyThatAccountDeletedIsVisibleAndClickContinueButton();
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
            string accountCreatedText = new EnterAccountInformationPage(GetDriver())
                .FillAccountDetails()
                .GetAccountCreated()
                .Text;
            Assert.AreEqual("ACCOUNT CREATED!", accountCreatedText);
              
        }

        public void VerifyThatLoggedInAsUsernameIsVisible()
        {
            string username = new AccountCreatedPage(GetDriver())
                .ContinueButtonClick()
                .GetUsername()
                .Text;
            Assert.AreEqual(username, name);
        }
        public void VerifyThatAccountDeletedIsVisibleAndClickContinueButton()
        {
            string accountDeletedText = new LoggedHomePage(GetDriver())
                .DeleteAccountButtonClick()
                .GetAccountDeleted()
                .Text;
            Assert.AreEqual(accountDeletedText, "ACCOUNT DELETED!");

        }


    }
}
     