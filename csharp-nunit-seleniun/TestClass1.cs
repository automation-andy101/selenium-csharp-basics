using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace csharp_nunit_seleniun
{
    internal class TestClass1
    {
        public static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [Test]
        public void Test1()
        {
            IWebElement usernameInput = PropertiesCollection.driver.FindElement(By.Name("user-name"));
            usernameInput.SendKeys("standard_user");

            IWebElement passwordInput = PropertiesCollection.driver.FindElement(By.Name("password"));
            passwordInput.SendKeys("secret_sauce");

            IWebElement loginBtn = PropertiesCollection.driver.FindElement(By.Name("login-button"));
            loginBtn.Click();
        }



        [TearDown]
        public void Clean()
        {
            PropertiesCollection.driver.Close();
        }
    }
}
