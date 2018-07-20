using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class LoginPageObject
    {

        //initialize page using constructor
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }


        //identify the name element with value as Username
        [FindsBy(How = How.Name, Using = "Username")]
        public IWebElement txtUserName { get; set; }
        //identify the name element with value as Password
        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }
        //identify the name element with value as Login
        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }


        //method
        public EAPageObject Login(string userName, string password)
        {
            //operation to enter username
            txtUserName.SendKeys(userName);
            //operation to enter password
            txtPassword.SendKeys(password);
            //submit button
            btnLogin.Submit();

            //Return the Page object 
            return new EAPageObject();
        }

    }
}
