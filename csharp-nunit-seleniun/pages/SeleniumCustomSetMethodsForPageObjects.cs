using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_nunit_seleniun
{
    internal class SeleniumCustomSetMethodsForPageObjects
    {

        // Enter Text
        public static void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        // Click a button, checkbox, option etc
        public static void Click(IWebElement element)
        {
            element.Click();
        }

        // For selecting a dropdown control
        public static void SelectDropdown(IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
