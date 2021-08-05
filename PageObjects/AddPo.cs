using OpenQA.Selenium;

namespace UnitTestProject1.PageObjects
{
    public class AddPo:PageObject
    {
        private readonly IWebDriver driver;

        public AddPo(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement Name
        {
            get
            {
                return driver.FindElement(By.Id("contact-name"));
            }
        }

        public IWebElement Email
        {
            get
            {
                return driver.FindElement(By.Id("contact-email"));
            }
        }

        public IWebElement Phone
        {
            get
            {
                return driver.FindElement(By.Id("contact-tel"));
            }
        }
    }
}
