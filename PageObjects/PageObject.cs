using OpenQA.Selenium;

namespace UnitTestProject1.PageObjects
{
    public class PageObject
   {
       private readonly IWebDriver driver;

       private readonly string BaseUrl = "https://testing-angular-applications.github.io/";

       public PageObject(IWebDriver driver)
       {
           this.driver = driver;
       }

       public void Navigate()
       {
           Navigate(BaseUrl);
       }

       public void Navigate(string url)
       {
           driver.Url = url;
       }
   }
}
