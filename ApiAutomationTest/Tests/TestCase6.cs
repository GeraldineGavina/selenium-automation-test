using SeleniumAutomationTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationTest.Tests
{
    public class TestCase6 : TestBase
    {
        private TestCase1 testCase2 = new TestCase1();
        [Test]
        public void ContactUsForm()
        {
            testCase2.VerifyHomePageIsVisible();
            VerifyGetInTouchIsVisible();
            VerifySuccessMessageIsVisible();
        }

        public void VerifyGetInTouchIsVisible()
        {
            string getGetInTouchText = new HomePage(GetDriver())
                .ContactUsButtonClick()
                .GetInTouch()
                .Text;
            Assert.AreEqual("GET IN TOUCH", getGetInTouchText);

        }
        public void VerifySuccessMessageIsVisible()
        {
            string getAlertSuccess = new ContactUsPage(GetDriver())
                .FillUpForm()
                .SubmitButtonClick()
                .OKButtonClick()
                .GetAlertSuccess()
                .Text;
            Assert.AreEqual("Success! Your details have been submitted successfully.", getAlertSuccess);

        }

        public void ClickHomeButtonAndVerifyThatLandedToHomepage()
        {
            Boolean homepageVisible = new ContactUsPage(GetDriver())
                 .HomePageButtonClick()
                 .HomePageIsVisible()
                 .Displayed;
            Assert.IsTrue(homepageVisible);

        }
       

    }
}
