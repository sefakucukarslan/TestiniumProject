using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestiniumProject.WebDriver
{
    public static class Driver
    {
        private static IWebDriver driver;
        private static WebDriverWait wait;
        private static FileStream stream;
        private static StreamReader reader;
        private static Actions action;

        public static void DriverStart()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        
        public static void DriverQuit()
        {
            driver.Quit();
        }
        
        public static void GoToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public static void ActionClick(IWebElement element)
        {
            action = new Actions(driver);
            action.Click(element).Build().Perform();
        }

        public static IWebElement FindElementXpath(string xPath)
        {
            return driver.FindElement(By.XPath(xPath));
        }

        public static ReadOnlyCollection<IWebElement> FindElementsXpath(string xPath)
        {
            return driver.FindElements(By.XPath(xPath));
        }

        public static IWebElement FindElementId(string id)
        {
            return driver.FindElement(By.XPath(id));
        }

        public static void MoveToElement(IWebElement element)
        {
            action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        public static void Wait(int milliseconds)
        {
            Thread.Sleep(milliseconds);
        }

        public static void ElementIsVisible(By xpath, int second)
        {
            try
            {
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(second));
                wait.Until(ExpectedConditions.ElementIsVisible(xpath));
            }
            catch
            {
                throw new ElementNotVisibleException("Element bulunamadı !!!");
            }

        }

        public static string FileRead(string path)
        {
            stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }

    }
}
