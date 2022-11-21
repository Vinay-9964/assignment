using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V106.SystemInfo;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Testcase
{
    public class Program
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement radiobutton;
        static IWebElement checkbox;
        static IAlert alert;
        static IWebElement text;


        static void Main(string[] args)
        {
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            //excercise();
            exercisetwo();
            //exercisethree();
            //excercise4();
            //exercise4one();
            //exercise4two();
            //excercise5();
            //exercisesix();
            //exerciseseven();
            //exerciseeight();
            //excercisenine();


            //Console.WriteLine("Hello World!");
        }

        public static void excercise()
        {
            string[] option = { "1", "2", "3" };
            int i = 0;

            while(i<3)
            {
                radiobutton = driver.FindElement(By.XPath("//*[@id=\"radio-btn-example\"]/fieldset/label[" + option[i]+"]/input"));
                radiobutton.Click();

                if (radiobutton.GetAttribute("checked") == "true")
                {
                    Console.WriteLine("the radio button" + (i + 1) + " is checked!");
                }
                else
                {
                    Console.WriteLine("this is one of the unchecked radio buttons!");
                }
                i++;
                Thread.Sleep(4000);
            } 
            
       
        }
        public static void excercise4()
        {
            //string url = "https://rahulshettyacademy.com/AutomationPractice/";
            //string option = "1";
            //driver.Navigate().GoToUrl(url);

            string option = "1";



            IWebElement Checkbox1 = driver.FindElement(By.XPath("//*[@id=\"checkBoxOption" + option + "\"]"));
            Checkbox1.Click();
            Thread.Sleep(2000);
            Checkbox1.Click();

            Thread.Sleep(2000);

            Console.WriteLine(Checkbox1.GetAttribute("value"));

            string option2 = "2";

            IWebElement Checkbox2 = driver.FindElement(By.XPath("//*[@id=\"checkBoxOption" + option2 + "\"]"));
            Console.WriteLine(Checkbox2.GetAttribute("value"));
            Checkbox2.Click();
            Thread.Sleep(2000);
            Checkbox2.Click();

            string option3 = "3";

            IWebElement Checkbox3 = driver.FindElement(By.XPath("//*[@id=\"checkBoxOption" + option3 + "\"]"));
            Console.WriteLine(Checkbox3.GetAttribute("value"));

            Checkbox3.Click();
            Thread.Sleep(2000);
            Checkbox3.Click();
            Thread.Sleep(2000);
        }

        public static void exercise4one()
        {
            for (int i = 1; i <= 3; i++)
            {
                IWebElement Checkall = driver.FindElement(By.XPath("//*[@id=\"checkBoxOption" + i + "\"]"));
                Checkall.Click();
                Thread.Sleep(2000);
            }
        }

        public static void exercise4two()
        {
            for (int i = 1; i <= 3; i++)
            {
                IWebElement deselect = driver.FindElement(By.XPath("//*[@id=\"checkBoxOption" + i + "\"]"));
                deselect.Click();
                
            }
            Thread.Sleep(2000);
            //driver.Quit();
        }


        public static void exercisetwo()
        {
            IWebElement drop = driver.FindElement(By.Id("autocomplete"));
            drop.SendKeys("united kingdom");
            IList<IWebElement> sbox = driver.FindElements(By.XPath("//*[@id=\"ui-id-15\"]"));

            foreach (var selement in sbox)
            {
                if (selement.Text.Contains("United Kingdom (UK)"))
                {
                    selement.Click();
                }
            }
        }

        public static void exercisethree()
        {
            IWebElement drop1 = driver.FindElement(By.CssSelector("#dropdown-class-example"));

             for (int i = 2; i < 5; i++)
            {
                IWebElement drop2 = driver.FindElement(By.CssSelector("#dropdown-class-example > option:nth-child("+i+")"));
                drop1.Click();
                Thread.Sleep(2000);
                drop2.Click();
                Thread.Sleep(2000);
            }

        }

        public static void excercise5()
        {
            IWebElement data = driver.FindElement(By.XPath("//*[@id=\"openwindow\"]"));
            data.Click();
            Thread.Sleep(5000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Thread.Sleep(2000);
            //data.Click();

        }
        public static void exercisesix()
        {
            IWebElement data1 = driver.FindElement(By.XPath("//*[@id=\"opentab\"]"));
            data1.Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Thread.Sleep(2000);

        }

        public static void exerciseseven()
        {
            IWebElement alement = driver.FindElement(By.CssSelector("#name"));
            alement.SendKeys("vinay");
            Thread.Sleep(2000);
            IWebElement alertbtn = driver.FindElement(By.Id("alertbtn"));
            alertbtn.Click();
            Thread.Sleep(2000);
            var alert = driver.SwitchTo().Alert();
            alert.Accept();

        }
      public static void exerciseeight()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            Thread.Sleep(2000);
            js.ExecuteScript(String.Format("window.scrollTo({0}, {1})", 400, 627));                                  
            Thread.Sleep(1500);
            js.ExecuteScript("document.querySelector('.tableFixHead').scrollBy(0,6000)");                  
            Thread.Sleep(1000);


        }
        public static void excercisenine()
        {
             Actions a = new Actions(driver);
            IWebElement mouseHower = driver.FindElement(By.XPath("//*[@id=\"mousehover\"]"));                        
            a.MoveToElement(mouseHower).Click().Build().Perform();                              
            Thread.Sleep(3000);
            IWebElement mouseClick = driver.FindElement(By.XPath("/html/body/div[4]/div/fieldset/div/div/a[1]"));                   
            Thread.Sleep(3000);
            a.MoveToElement(mouseClick).Click().Build().Perform();
            Thread.Sleep(3000);
            //driver.Quit();

        }
    }
 }







