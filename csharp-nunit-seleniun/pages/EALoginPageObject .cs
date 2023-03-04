using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;

namespace csharp_nunit_seleniun
{
    class EALoginPageObject
    {
        public EALoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        // public IWebElement txtUserName => PropertiesCollection.driver.FindElement(By.Name("UserName"));

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }


        public EAPageObject Login(string username, string password)
        {
            txtUserName.SendKeys(username);

            txtPassword.SendKeys(password);

            btnLogin.Submit();

            return new EAPageObject();
        }
    }
}
