using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System.Configuration;

namespace SeleniumAutomationTest.Utils
{
    public class BrowserManager
    {
        public static IWebDriver DoBrowserSetup()
        {
            IWebDriver driver = null;
            //string browserName = ConfigurationManager.ConnectionStrings["browserName"].ConnectionString;
            
            string name = "Chrome";
            if (name.Equals("Chrome", StringComparison.OrdinalIgnoreCase))
            {
                //string pathExtension = ConfigurationManager.AppSettings["adBlock"].ToString();
                //Console.WriteLine(">>>>>>>>>>>>>>>>>>>> "+browserName);
                ChromeOptions chromeOptions = new ChromeOptions();
                //chromeOptions.AddArgument("load-extension=" + pathExtension);
                /*chromeOptions.AddArgument("--headless");
                chromeOptions.AddArgument("--silent");*/
                driver = new ChromeDriver(chromeOptions);
            }
            else if (name.Equals("Firefox", StringComparison.OrdinalIgnoreCase))
            {
                FirefoxOptions firefoxOptions = new FirefoxOptions();
                firefoxOptions.AddArgument("--headless");
                firefoxOptions.AddArgument("--private");
                driver = new FirefoxDriver(firefoxOptions);
            }
            return driver;
        }
    }
}
