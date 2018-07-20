﻿using NUnit.Framework;
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
       /*
        //create reference for the browser and set it as a global variable
        IWebdriver driver = new Chromedriver();*/

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            
        }

        [SetUp]
        public void Initialize()
        {

            //initialize the browser by creating an instance of the chrome PropertiesCollection.driver
            PropertiesCollection.driver = new ChromeDriver();

            //navigate to Google Page
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");

            //maximize window
            PropertiesCollection.driver.Manage().Window.Maximize();

            Console.WriteLine("Opened URL");

        }

        [Test]
        public void ExecuteTest()
        {
            //    //select the title by calling the SelectDropDown method in SeleniumSetMethods class
            //    SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);
            //    Console.WriteLine("Executed Test");

            //    //select the Initial from the Text Box
            //    SeleniumSetMethods.EnterText("Initial", "executeautomation", PropertyType.Name);

            //    Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetTextFromDropDownList("TitleId", PropertyType.Id));
            //    Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));
            //    //click
            //    SeleniumSetMethods.Click("Save", PropertyType.Name);


            //Initialize the page by calling its reference
            EAPageObject page = new EAPageObject();

            page.txtInitial.SendKeys("executeautomation");
            page.btnSave.Click();
            Console.WriteLine("Executed Page Object Model");
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
            PropertiesCollection.driver.Close();

            Console.WriteLine("Closed the browser");

        }
    }
}
