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
    }
}
