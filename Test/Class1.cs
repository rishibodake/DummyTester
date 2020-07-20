using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Test
{
    public class Class1
    {
        public Class1(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "email")]
        [CacheLookup]
        public IWebElement Email;


        [FindsBy(How = How.Id, Using = "pass")]
        [CacheLookup]
        public IWebElement Password;


        [FindsBy(How = How.Id, Using = "u_0_b")]
        [CacheLookup]
        public IWebElement Login;

        public void Login1()
        {
            Email.SendKeys("");
            Password.SendKeys("");
            Login.Click();
        }
        //Test For RelesePipeLine
    }
}
