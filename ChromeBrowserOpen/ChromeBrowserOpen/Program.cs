using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ChromeBrowserOpen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("노래 제목 입력");
            string result = Console.ReadLine();

            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://google.co.kr";
            driver.Manage().Window.Maximize();

            Thread.Sleep(3000);

            driver.FindElement(By.Name("q")).SendKeys(result + " 가사");

            Thread.Sleep(3000);

            driver.FindElement(By.Name("btnK")).Click();
        }
    }
}
