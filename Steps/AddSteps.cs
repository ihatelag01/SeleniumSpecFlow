using FluentAssertions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using UnitTestProject1.Models;
using UnitTestProject1.PageObjects;
using UnitTestProject1.Utilities;

namespace UnitTestProject1.Steps
{
    [Binding]
    public class AddSteps
    {
        private readonly AddPo addPo;
        private NewMethods newMethods;
        public AddSteps(IWebDriver driver)
        {
            addPo = new AddPo(driver);
            newMethods = new NewMethods();
        }
        [When(@"I enter (.*), (.*), (.*)")]
        public void WhenIEnter_(string name, string email, string phone)
        {
            newMethods.EnterText(addPo.Name, name);
            newMethods.EnterText(addPo.Email, email);
            newMethods.EnterText(addPo.Phone, phone);

        }

        [Then(@"(.*),(.*),(.*) should be displayed")]
        public void ThenShouldBeDisplayed(string name, string email, string phone)
        {
            string actualName = newMethods.GetValueFrom(addPo.Name);
            string actualEmail = newMethods.GetValueFrom(addPo.Email);
            string actualPhone = newMethods.GetValueFrom(addPo.Phone);

            actualName.Should().Be(name);
            actualEmail.Should().Be(email);
            actualPhone.Should().Be(phone);
        }

        [When(@"I enter the details")]
        public void WhenIEnterTheDetails(Table table)
        {
            Contact contact = table.CreateInstance<Contact>();

            newMethods.EnterText(addPo.Name, contact.Name);
            newMethods.EnterText(addPo.Email, contact.Email);
            newMethods.EnterText(addPo.Phone, contact.Phone);
        }

        [Then(@"the values should be displayed")]
        public void ThenTheValuesShouldBeDisplayed(Table table)
        {
            Contact contact = table.CreateInstance<Contact>();

            string actualName = newMethods.GetValueFrom(addPo.Name);
            string actualEmail = newMethods.GetValueFrom(addPo.Email);
            string actualPhone = newMethods.GetValueFrom(addPo.Phone);

            actualName.Should().Be(contact.Name);
            actualEmail.Should().Be(contact.Email);
            actualPhone.Should().Be(contact.Phone);
        }

    }
}
