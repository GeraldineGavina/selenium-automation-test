using OpenQA.Selenium;
using SeleniumAutomationTest.Tests;
using SeleniumExtras.PageObjects;

namespace SeleniumAutomationTest.Pages
{
    public class HomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "a[href='/login']")]
        private IWebElement signUpLink;

        [FindsBy(How = How.CssSelector, Using = "div[class='item active'] img[alt='demo website for practice']")]
        private IWebElement bannerImage;

        [FindsBy(How = How.CssSelector, Using = "a[href='/contact_us']")]
        private IWebElement contactUsButton;

        [FindsBy(How = How.CssSelector, Using = "a[href='/test_cases'")]
        private IWebElement testcasesButton;

        [FindsBy(How = How.CssSelector, Using = "a[href='/products']")]
        private IWebElement productsButton;

        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }   

        public LoginSignUpPage SignUpLinkClick()
        {
            signUpLink.Click();
            return new LoginSignUpPage(driver);
        }

        internal IWebElement HomePageIsVisible()
        {
            return bannerImage;
        }

        public ContactUsPage ContactUsButtonClick()
        {
            contactUsButton.Click();
            return new ContactUsPage(driver);
        }

        public TestCasesPage TestCaseButtonClick()
        {
            testcasesButton.Click();
            return new TestCasesPage(driver);
        }

        public ProductsPage ProductsPageButtonClick()
        {
            productsButton.Click();
            return new ProductsPage(driver);
        }

    }
}
