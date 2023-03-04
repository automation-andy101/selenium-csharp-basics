using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace csharp_nunit_seleniun
{
    internal class TestClass2
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
            SeleniumCustomSetMethods.EnterText("name", "Some random text", PropertyType.Id);

            // Check that correct text appears in element
            Console.WriteLine("The value in the Switch to alert Example input box is: " + SeleniumCustomGetMethods.GetText("name", "Some random text", PropertyType.Id));

            // Click a checkbox
            SeleniumCustomSetMethods.Click("checkBoxOption1", PropertyType.Id);

            // Select option1 from dropdown
            SeleniumCustomSetMethods.SelectDropdown("dropdown-class-example", "Option1", PropertyType.Name);

            // Check that correct text appears in element
            Console.WriteLine("The value in the Dropdown Example dropdown list is: " + SeleniumCustomGetMethods.GetTextFromDropdown("dropdown-class-example", "Option1", PropertyType.Name));
        }
        

        [TearDown]
        public void Clean()
        {
            PropertiesCollection.driver.Close();
        }
    }
}
