using OpenQA.Selenium;

namespace UnitTestProject1.Utilities
{
    public class NewMethods
    {
        public void EnterText(IWebElement field, string text)
        {
            field.SendKeys(text);
        }

        public string GetValueFrom(IWebElement element)
        {
            return element.GetAttribute("value");
        }
    }
}
