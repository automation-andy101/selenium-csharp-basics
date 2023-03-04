using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;

namespace csharp_nunit_seleniun
{
    class AutomationPracticePageObject
    {
        public AutomationPracticePageObject() 
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }


        [FindsBy(How = How.Id, Using = "name")]
        public IWebElement txtSwitchToAlertInput { get; set; }

        [FindsBy(How = How.Name, Using = "dropdown-class-example")]
        public IWebElement ddlExampleDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "checkBoxOption1")]
        public IWebElement cbCheckboxExample { get; set; }
    }
}
