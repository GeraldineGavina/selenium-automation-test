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
    public class TestCase3 : TestBase
    {
        private TestCase1 testCase1 = new TestCase1();
        private TestCase2 testCase2 = new TestCase2();
        [Test]
        public void LoginUserWithIncorrectEmailAndPassword()
        {
            testCase1.VerifyHomePageIsVisible();
            testCase2.VerifyLoginToYourAccountIsVisible();
            VerifyErroYourEmailIsIncorrectIsVisible();
        }

        public void VerifyErroYourEmailIsIncorrectIsVisible()
        {
            string errorLogin = new LoginSignUpPage(GetDriver())
                .FillIncorrectLogin()
                .GetErrorLogin()
                .Text;
            Assert.AreEqual("Your email or password is incorrect!", errorLogin);
        }
    }
}
