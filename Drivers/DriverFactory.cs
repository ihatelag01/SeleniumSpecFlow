using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1.Drivers
{
    public class DriverFactory
    {
        private readonly string browser = "CHROME";

        public IWebDriver CreateDriver()
        {
            switch (browser.ToUpperInvariant())
            {
                case "CHROME":
                    return new ChromeDriver();
                default:
                    throw new NotSupportedException($"Browser {browser} not supported!");
            }
            
        }
    }
}
