using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V112.Network;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationTest.Pages
{
    public class ProductDetailsPage
    {
        IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "div[class='product-information'] h2")]
        private IWebElement productName;

        [FindsBy(How = How.XPath, Using = "//section/div/div/div[2]/div[2]/div[2]/div/p[1]")]
        private IWebElement productCategory;

        [FindsBy(How = How.CssSelector, Using = "div[class='product-information'] span span")]
        private IWebElement productPrice;

        [FindsBy(How = How.XPath, Using = "//section/div/div/div[2]/div[2]/div[2]/div/p[2]")]
        private IWebElement productAvailability;

        [FindsBy(How = How.XPath, Using = "//section/div/div/div[2]/div[2]/div[2]/div/p[3]")]
        private IWebElement productCondition;

        [FindsBy(How = How.XPath, Using = "//section/div/div/div[2]/div[2]/div[2]/div/p[4]")]
        private IWebElement productBrand;
        

        public ProductDetailsPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        public IWebElement GetProductName()
        {
            return productName;
        }
        public IWebElement GetProductCategory()
        {
            return productCategory;
        }
        public IWebElement GetProductPrice()
        {
            return productPrice;
        }
        public IWebElement GetProductAvailability()
        {
            return productAvailability;
        }
        public IWebElement GetProductCondition()
        {
            return productCondition;
        }
        public IWebElement GetProductBrand()
        {
            return productBrand;
        }
    }
}
