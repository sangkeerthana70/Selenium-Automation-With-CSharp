﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace SeleniumFirst
{
    class SeleniumGetMethods
    {

        //method that returns  the string value out of the text box control
        public static string GetText(IWebElement element)
        {
            //if (elementtype == PropertyType.Id)
            //    return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
            //if (elementtype == PropertyType.Name)
            //    return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
            //else return String.Empty;

            return element.GetAttribute("value");


        }

        public static string GetTextFromDropDownList(IWebElement element)
        {           
                return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
 
        }


    }
}
