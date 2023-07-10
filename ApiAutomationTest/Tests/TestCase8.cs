using SeleniumAutomationTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationTest.Tests
{
    public class TestCase8 : TestBase
    {
        private TestCase1 testcase1 =  new TestCase1();

        [Test]
        public void VerifyAllProductsAndDetailsPage()
        {
            testcase1.VerifyHomePageIsVisible();
            VerifyUserIsNavigatedToAllProducts();
            new ProductsPage(GetDriver()).ClickOnViewFirstProduct();
            VerifyThatDetailsAreVisible();
        }

        public void VerifyUserIsNavigatedToAllProducts()
        {
            string productListText = new HomePage(GetDriver())
                .ProductsPageButtonClick()
                .AllProductsTitle()
                .Text;
            Assert.AreEqual("ALL PRODUCTS", productListText);

        }

        public void VerifyThatDetailsAreVisible()
        {
            Boolean name = new ProductDetailsPage(GetDriver()).GetProductName().Displayed;
            Boolean category = new ProductDetailsPage(GetDriver()).GetProductCategory().Displayed;
            Boolean price = new ProductDetailsPage(GetDriver()).GetProductPrice().Displayed;
            Boolean availability = new ProductDetailsPage(GetDriver()).GetProductAvailability().Displayed;
            Boolean condition = new ProductDetailsPage(GetDriver()).GetProductCondition().Displayed;
            Boolean brand = new ProductDetailsPage(GetDriver()).GetProductBrand().Displayed;

            Assert.IsTrue(name);
            Assert.IsTrue(category);
            Assert.IsTrue(price);
            Assert.IsTrue(availability);
            Assert.IsTrue(condition);
            Assert.IsTrue(brand);
        }
    }
}
