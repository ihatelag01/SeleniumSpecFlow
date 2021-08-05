using System;
using BoDi;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace UnitTestProject1.Drivers
{
    [Binding]
    public class Setup
   {
       
       private readonly IObjectContainer objectContainer;

       private IWebDriver driver;

       private static DriverFactory driverFactory;

       public Setup(IObjectContainer objectContainer)
       {
           this.objectContainer = objectContainer;
       }

       [BeforeTestRun]
       public static void BeforeTestRun()
       {
           driverFactory = new DriverFactory();
       }

       [BeforeScenario]
       public void BeforeScenario()
       {
           driver = driverFactory.CreateDriver();
           driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);
           driver.Manage().Window.Maximize();

           objectContainer.RegisterInstanceAs(driver);
       }

       [AfterScenario]
       public void AfterScenario()
       {
           if (driver!=null)
           {
               driver.Dispose();
               
           }
       }
   }
}
