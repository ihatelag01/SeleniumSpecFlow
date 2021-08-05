using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using UnitTestProject1.PageObjects;
using UnitTestProject1.Utilities;

namespace UnitTestProject1.Steps
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPo loginPo;
        private NewMethods newMethods;

        public LoginSteps(IWebDriver driver)
        {
            loginPo = new LoginPo(driver);
            newMethods = new NewMethods();
        }
        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            loginPo.Navigate("https://stagiipebune.ro/login/?next=/home/");
        }
        [When(@"I input (.*), (.*)")]
        public void WhenIEnter(string email, string password)
        {
             loginPo.Email.Click();
             newMethods.EnterText(loginPo.Email,email);
             newMethods.EnterText(loginPo.Password,password);
             
        }


        [When(@"I Click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            loginPo.LoginButton.Click();
            Thread.Sleep(1000);
            
        }


        [Then(@"I should be redirected to the home page")]
        public void ThenIShouldBeRedirectedToTheLoginPage()
        {
            Assert.That(loginPo.ProfilePicture.Displayed);
        }

        [Then(@"Invalid credentials message should be visible")]
        public void ThenInvalidCredentialsMessageShouldBeVisible()
        {
            Assert.That(loginPo.InvalidCredentialsMessage.Displayed);
        }

    }
}
