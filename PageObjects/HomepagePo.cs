using OpenQA.Selenium;

namespace UnitTestProject1.PageObjects
{
    public class HomepagePo: PageObject
    {
        private readonly IWebDriver driver;

        public HomepagePo(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement AddButton
        {
            get
            {
              return  driver.FindElement(By.Id("add-contact"));
            }
        }
    }
}
