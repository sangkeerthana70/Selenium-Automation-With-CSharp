using NUnit.Framework;
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
       
        //create reference for the browser and set it as a global variable
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            
        }

        [SetUp]
        public void Initialize()
        {
            //navigate to Google Page
            driver.Navigate().GoToUrl("https://http://executeautomation.com/demosite/Login.html/UserName=&Password=&Login=Login");

            //maximize window
            driver.Manage().Window.Maximize();

            Console.WriteLine("Opened URL");

        }

        [Test]
        public void ExecuteTest()
        {
            //Find the search text Box element of the webpage
            IWebElement element = driver.FindElement(By.Name("q"));

            //perform ops
            element.SendKeys("execute automation");

            Console.WriteLine("Executed Test");

        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Executing next Test method");
        }

        [TearDown]
        public void CleanUp()
        {
            //close window
            driver.Close();

            Console.WriteLine("Closed the browser");

        }
    }
}
