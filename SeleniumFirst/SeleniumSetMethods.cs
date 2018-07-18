using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class SeleniumSetMethods
    {
        //generic Enter Text method to support all text box controls for the application 
        public static void EnterText(IWebDriver driver, string element, string value, string elementype)
        {
            if (value == "ID")
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (value == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
        }
    }
}
