using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    class SeleniumSetMethods
    {
        //generic Enter Text method to support all text box controls for the application 
        public static void EnterText(string element, string value, string elementype)
        {
            if (elementype == "ID")
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementype == "Name")
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //custom method to perform a click operation on button, checkbox, option etc
        public static void Click(string element,  string elementype)
        {
            if (elementype == "ID")
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            if (elementype == "Name")
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();

        }

        //selecting a dropdown control
        public static void SelectDropDown(string element, string value, string elementype)
        {
            if (elementype == "Id")
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementype == "Name")
                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
