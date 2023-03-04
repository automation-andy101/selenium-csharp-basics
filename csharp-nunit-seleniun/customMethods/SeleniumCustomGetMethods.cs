using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_nunit_seleniun
{
    internal class SeleniumCustomGetMethods
    {

        // Get Text from input box
        public static string GetText(IWebElement element)
        {
           return element.GetAttribute("value");
        }

        // Get selected dropdown text from from dropdown
        public static string GetTextFromDropdown(IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;

        }
    }
}
