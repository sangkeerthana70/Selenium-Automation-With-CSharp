using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace SeleniumFirst
{
    class SeleniumGetMethods
    {

        //method that returns  the string value out of the text box control
        public static string GetText(string element, string elementtype)
        {
            if (elementtype == "Id")
                return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementtype == "Name")
                return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
            else return String.Empty;


        }

        public static string GetTextFromDropDownList(string element, string elementtype)
        {
            if (elementtype == "Id")
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementtype == "Name")
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return String.Empty;


        }


    }
}
