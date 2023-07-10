using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationTest.Pages
{
    public class ProductsPage
    {
        IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = ".title.text-center")]
        private IWebElement allProducts;

        [FindsBy(How = How.CssSelector, Using = "a[href='/product_details/1']")]
        private IWebElement clickOnFirstProduct;

        public ProductsPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        public IWebElement AllProductsTitle()
        {
            return allProducts;
        }

        public ProductDetailsPage ClickOnViewFirstProduct()
        {
            clickOnFirstProduct.Click();
            return new ProductDetailsPage(driver);
        }
    }
}
