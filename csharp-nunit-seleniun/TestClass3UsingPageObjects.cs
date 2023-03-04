using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace csharp_nunit_seleniun
{
    internal class TestClass3UsingPageObjects
    {


        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
        }

        [Test]
        public void TestCustomMethods()
        {
            // Enter text into text input box
            AutomationPracticePageObject page = new AutomationPracticePageObject();
            page.txtSwitchToAlertInput.SendKeys("Some random text");
            
            

            // Check that correct text appears in element
            Console.WriteLine("The value in the Switch to alert Example input box is: " + page.txtSwitchToAlertInput.Text);

            // Click a checkbox
            page.cbCheckboxExample.Click();


            // Select option1 from dropdown
            SeleniumCustomSetMethodsForPageObjects.SelectDropdown("dropdown-class-example", "Option1", PropertyType.Name);
            page.ddlExampleDropDown.Click();
            
        }


            [TearDown]
        public void Clean()
        {
            PropertiesCollection.driver.Close();
        }
    }
}
