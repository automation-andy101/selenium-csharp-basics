using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace csharp_nunit_seleniun
{
    internal class TestClass4ForEaWebsiteUsingPageObjects
    {


        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("https://demosite.executeautomation.com/");
        }

        [Test]
        public void ExecuteTest()
        {
            EALoginPageObject loginPage = new EALoginPageObject();
            EAPageObject eaPage = loginPage.Login("execute", "automation");
            eaPage.FillUserForm("KK", "Andrew", "Short"); 
        }


            [TearDown]
        public void Clean()
        {
            PropertiesCollection.driver.Close();
        }
    }
}
