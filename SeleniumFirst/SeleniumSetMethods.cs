using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    class SeleniumSetMethods
    {
        //generic Enter Text method to support all text box controls for the application 
        public static void EnterText(IWebElement element, string value)
        {
            //if (elementtype == PropertyType.Id)
            //    PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            //if (elementtype == PropertyType.Name)
            //    PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);

            element.SendKeys(value);
        }

        //custom method to perform a click operation on button, checkbox, option etc
        public static void Click(IWebElement element)
        {
            //if (elementtype == PropertyType.Id)
            //    PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            //if (elementtype == PropertyType.Name)
            //    PropertiesCollection.driver.FindElement(By.Name(element)).Click();
            element.Click();

        }

        //selecting a dropdown control
        public static void SelectDropDown(IWebElement element, string value)
        {
            
                new SelectElement(element).SelectByText(value);
            
        }
    }
}
