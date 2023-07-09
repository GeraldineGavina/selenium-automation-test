using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumAutomationTest.Pages;

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
        }

        public void VerifyLoginToYourAccountIsVisible()
        {
            string loginToYourAccountTxt = new HomePage(GetDriver())
                .SignUpLinkClick()
                .GetLoginToYourAccount()
                .Text;
            Assert.AreEqual("Login to your account", loginToYourAccountTxt);
        }
    }
}
