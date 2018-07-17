using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //create reference for the browser
            IWebDriver driver = new ChromeDriver();

            //navigate to Google Page
            driver.Navigate().GoToUrl("https://www.google.com");

            //maximize window
            driver.Manage().Window.Maximize();

            //Find the search text Box element
            IWebElement element = driver.FindElement(By.Name("q"));

            //perform ops
            element.SendKeys("execute automation");

            //close window
            //driver.Close();
        }
    }
}
