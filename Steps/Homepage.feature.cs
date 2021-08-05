using FluentAssertions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using UnitTestProject1.PageObjects;

namespace UnitTestProject1.Steps
{
    [Binding]
    public class HomepageSteps
    {
        private readonly HomepagePo homepagePo;

        

        public HomepageSteps(IWebDriver driver)
        {
            homepagePo = new HomepagePo(driver);
        }
        [Given(@"I open the application")]
        [When(@"I open the application")]
        public void WhenIOpenTheApplication()
        {
            homepagePo.Navigate();
        }
        [Given(@"I click add button")]
        public void GivenIClickAddButton()
        {
            homepagePo.AddButton.Click();
        }


        [Then(@"the Add button should be displayed")]
        public void ThenTheAddButtonShouldBeDisplayed()
        {
            homepagePo.AddButton.Displayed.Should().BeTrue("Add button is not displayed");
        }
    }
}
