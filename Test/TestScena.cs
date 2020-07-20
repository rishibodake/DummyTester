﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Test
{
    [TestFixture]
    public class TestScena
    {
        IWebDriver driver;
        [OneTimeSetUp]
        public void Init()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com";
        }

        [Test]
        public void Login()
        {
            Class1 page = new Class1(driver);
            page.Login1();
        }

    }
}
