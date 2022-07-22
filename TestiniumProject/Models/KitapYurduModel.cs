using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;
using TestiniumProject.WebDriver;

namespace TestiniumProject.Models
{
    public class KitapYurduModel
    {
        

        public void OpenPage(string url)
        {
            Driver.GoToUrl(url);
        }

        public void AnasayfaKontrol()
        {
            Driver.ElementIsVisible(By.XPath("//div[@id='header']"), 5);
        }
         
        public void UrunArama(string filePath)
        {
            Driver.FindElementXpath("//input[@id='search-input']").Click();
            Driver.FindElementXpath("//input[@id='search-input']").SendKeys(Driver.FileRead(filePath));
            Driver.FindElementXpath("//input[@id='search-input']").SendKeys(Keys.Enter);
        }
        
        public void KitapSecimi()
        {
            Driver.ElementIsVisible(By.XPath("//div[@id='product-table']//div[@class='name']"), 5);
            ReadOnlyCollection <IWebElement> elements = Driver.FindElementsXpath("//div[@id='product-table']//div[@class='name']");
            int count = elements.Count;
            Random random = new Random();
            int rnd = random.Next(count);
            Driver.MoveToElement(elements[rnd]);
            elements[rnd].Click();            
        }
        
        public void SepetEkle()
        {
            Driver.ElementIsVisible(By.XPath("//a[@id='button-cart']"), 5);
            Driver.FindElementXpath("//a[@id='button-cart']").Click();
        }
        
        public string IkonKontrol()
        {
            Driver.Wait(1000);
            return Driver.FindElementXpath("//span[@id='cart-items']").Text;
        }
        
        public void SepetimClick()
        {
            Driver.ElementIsVisible(By.XPath("//div[@id='cart']"), 1);
            Driver.FindElementXpath("//div[@id='cart']").Click();
        }
        
        public void SepeteGitClick()
        {
            Driver.ElementIsVisible(By.XPath("//a[@id='js-cart']"), 5);
            Driver.FindElementXpath("//a[@id='js-cart']").Click();
        }
        
        public void UrunAdet()
        {
            Driver.ElementIsVisible(By.XPath("//input[@name='quantity']"), 5);
            Driver.FindElementXpath("//input[@name='quantity']").Click();
            Driver.FindElementXpath("//input[@name='quantity']").Clear();
            Driver.FindElementXpath("//input[@name='quantity']").SendKeys("2");
        }
        
        public void YenileClick()
        {
            Driver.FindElementXpath("//i[@class='fa fa-refresh green-icon']").Click();
        }
        
        public string GuncellemeKontrol()
        {
            Driver.Wait(1000);
            return Driver.FindElementXpath("//h2[@id='swal2-title']").Text;
        }
        
        public void CarpıClick()
        {
            Driver.ElementIsVisible(By.XPath("//i[@class='fa fa-times red-icon']"), 5);
            Driver.FindElementXpath("//i[@class='fa fa-times red-icon']").Click();
        }
        
        public string SepetKontrol()
        {
            Driver.Wait(1000);
            return Driver.FindElementXpath("//span[@id='cart-items']").Text;
        }

    }
}
