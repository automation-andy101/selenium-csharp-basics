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
            SeleniumCustomSetMethodsForPageObjects.EnterText("name", "Some random text", PropertyType.Id);

            // Check that correct text appears in element
            Console.WriteLine("The value in the Switch to alert Example input box is: " + SeleniumCustomGetMethodsForPageObjects.GetText("name", "Some random text", PropertyType.Id));

            // Click a checkbox
            SeleniumCustomSetMethodsForPageObjects.Click("checkBoxOption1", PropertyType.Id);

            // Select option1 from dropdown
            SeleniumCustomSetMethodsForPageObjects.SelectDropdown("dropdown-class-example", "Option1", PropertyType.Name);

            // Check that correct text appears in element
            Console.WriteLine("The value in the Dropdown Example dropdown list is: " + SeleniumCustomGetMethodsForPageObjects.GetTextFromDropdown("dropdown-class-example", "Option1", PropertyType.Name));
        }
        

        [TearDown]
        public void Clean()
        {
            PropertiesCollection.driver.Close();
        }
    }
}
