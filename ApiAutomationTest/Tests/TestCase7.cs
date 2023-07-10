using OpenQA.Selenium;
using SeleniumAutomationTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationTest.Tests
{
    public class TestCase7 : TestBase
    {
        private TestCase1 testcase1 = new TestCase1();

        [Test]
        public void TestCases()
        {
            testcase1.VerifyHomePageIsVisible();
            VerifyUserIsNavigatedToTestCasesPage();

        }

        public void VerifyUserIsNavigatedToTestCasesPage()
        {
            string getTestCaseText = new HomePage(GetDriver())
                .TestCaseButtonClick()
                .GetTestCase()
                .Text;
            Assert.AreEqual("TEST CASES",getTestCaseText);
        }
    }
}
