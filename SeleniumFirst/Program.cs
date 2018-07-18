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
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");

            //maximize window
            driver.Manage().Window.Maximize();

            Console.WriteLine("Opened URL");

        }

        [Test]
        public void ExecuteTest()
        {
            //select the title by calling the SelectDropDown method in SeleniumSetMethods class
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");
            Console.WriteLine("Executed Test");

            //select the Initial from the Text Box
            SeleniumSetMethods.EnterText(driver, "Initial", "executeautomation", "Name");

            Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetText(driver, "TitleId", "Id"));
            Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText(driver, "Initial", "Name"));
            //click
            SeleniumSetMethods.Click(driver, "Save", "Name");
        }

     /*   [Test]
        public void NextTest()
        {
            Console.WriteLine("Executing next Test method");
        }
*/
        [TearDown]
        public void CleanUp()
        {
            //close window
            driver.Close();

            Console.WriteLine("Closed the browser");

        }
    }
}
