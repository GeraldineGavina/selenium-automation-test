using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using SeleniumAutomationTest.Pages;

namespace SeleniumAutomationTest.Tests
{
    internal class TestCase4 : TestBase
    {
        TestCase1 testCase1 = new TestCase1();
        TestCase2 testCase2 = new TestCase2();
        [Test]
        public void LogoutUser()
        {
            testCase1.VerifyHomePageIsVisible();
            testCase2.VerifyLoginToYourAccountIsVisible();
            testCase2.VerifyLoggedInAsUserName();
            VerifyThatUserIsNaviatedToLoginPage();
        }

        public void VerifyThatUserIsNaviatedToLoginPage()
        {
            string loginTxt = new LoggedHomePage(GetDriver())
                .LogoutButtonClick()
                .GetLoginToYourAccount()
                .Text;
            Assert.AreEqual("Login to your account", loginTxt);
        }


    }
}
