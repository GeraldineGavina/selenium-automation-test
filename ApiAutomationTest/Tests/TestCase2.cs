using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumAutomationTest.Data;
using SeleniumAutomationTest.Pages;
using SeleniumAutomationTest.Utils;

namespace SeleniumAutomationTest.Tests
{
    public class TestCase2 : TestBase
    {
        private TestCase1 testCase1 = new TestCase1();
        [Test]
        public void LoginUserWithCorrectEmailAndPassword()
        {
            testCase1.VerifyHomePageIsVisible();
            VerifyLoginToYourAccountIsVisible();
            VerifyLoggedInAsUserName();
            testCase1.VerifyThatAccountDeletedIsVisibleAndClickContinueButton();
        }

        public void VerifyLoginToYourAccountIsVisible()
        {
            string loginToYourAccountTxt = new HomePage(GetDriver())
                .SignUpLinkClick()
                .GetLoginToYourAccount()
                .Text;
            Assert.AreEqual("Login to your account", loginToYourAccountTxt);
        }

        public void VerifyLoggedInAsUserName()
        {
            //create a new user to login
            testCase1.VerifyThatEnterAccountInformationIsVisible();
            testCase1.VerifyThatAccountCreatedIsVisible();
            testCase1.VerifyThatLoggedInAsUsernameIsVisible().LogoutButtonClick();
            string jsonPath = "..\\..\\..\\Data\\user.json";
            UserSignUp userSignUp = JSONUtil.ReadFromJsonFile<UserSignUp>(jsonPath);
            string username = new LoginSignUpPage(GetDriver())
                .FillCorrectLogin(userSignUp.email, userSignUp.password)
                .GetUsername()
                .Text;
            Assert.AreEqual(userSignUp.name, username);
        }


    }
}
