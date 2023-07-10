using SeleniumAutomationTest.Pages;
using SeleniumAutomationTest.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationTest.Tests
{
    public class TestCase5 : TestBase
    {
        private TestCase1 testCase1 = new TestCase1();
        private string name = "Existing User";
        private string email = "user@exist.com";

        [Test]
        public void RegisterUserExistingEmail()
        {
            testCase1.VerifyHomePageIsVisible();
            testCase1.VerifyNewUserSignUpIsVisible();
            RegisterUserWithExistingEmail();

        }

        public void RegisterUserWithExistingEmail()
        {
            string emailAddressExist = new LoginSignUpPage(GetDriver())
                .FillIncorrectSignUp(name, email)
                .GetEmailAddressAlreadyExist()
                .Text;
            Assert.AreEqual("Email Address already exist!", emailAddressExist);

        }
    }
}
