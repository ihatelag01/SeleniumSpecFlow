using OpenQA.Selenium;

namespace UnitTestProject1.PageObjects
{
    public class LoginPo : PageObject
    {
        private IWebDriver driver;

        public LoginPo(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement Email
        {
            get
            {
                return driver.FindElement(By.XPath("//*[@id=\"username\"]"));
            }
        }

        public IWebElement Password
        {
            get
            {
                return driver.FindElement(By.XPath("//*[@id=\"password\"]"));
            }
        }

        public IWebElement LoginButton
        {
            get
            {
                return driver.FindElement(By.XPath("//*[@id=\"login-section\"]/div[1]/form[2]/button"));
            }
        }

        public IWebElement ProfilePicture
        {
            get
            {
                return driver.FindElement(By.XPath("//*[@id=\"profile-picture-preview\"]"));
            }
        }

        public IWebElement InvalidCredentialsMessage
        {
            get
            {
                return driver.FindElement(
                    By.XPath("//*[@id=\"login-section\"]/div[1]/form[2]/div[1]/span/span/span/span[2]"));
            }
        }


    }
}

