using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class EAPageObject
    {

        //initialize page object using constructor
        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        //identify the dropdown box element by id value as TitleId
        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement ddlTitleID { get; set; }

        //identify the text box element by the id value as Initial
        [FindsBy(How = How.Id, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        //identify the button element by the name value as Save
        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        //method to do operation on the EA page once the Login is successfull
        public void FillUserForm(string initial, string firstName, string middleName)
        {
            txtInitial.SendKeys(initial);
            txtFirstName.SendKeys(firstName);
            txtMiddleName.SendKeys(middleName);
            btnSave.Click();

        }
    }
}
