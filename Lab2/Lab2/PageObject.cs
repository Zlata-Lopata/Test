using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace SpecFlowProject.PageObjects
{
    public class BankingPage
    {
        private IWebDriver driver;

        public BankingPage()
        {
            this.driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/login");
           // this.LoginAsUser();
        }

        public void LoginAsUser()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[1]/div[1]/button")).Click();
            
            driver.FindElement(By.Id("userSelect")).Click();
           
            driver.FindElement(By.XPath("//*[@id=\"userSelect\"]/option[2]")).Click();
         
            driver.FindElement(By.CssSelector(".btn-default")).Click();
        }

        public void NavigateToBankingPage()
        {
            driver.FindElement(By.CssSelector(".btn-lg:nth-child(3)")).Click();
           // this.WithdrawAmount("100");
        }

        public void WithdrawAmount(string amount)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[4]/div/form/div/input")).Click(); // Ввод суми

            driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[4]/div/form/div/input")).SendKeys(amount); // Ввод суми
            driver.FindElement(By.CssSelector(".btn-default")).Click(); // Натискання кнопки Withdraw
        }

        public string GetText()
        {
            string balanceElement = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[4]/div/span")).Text;
            return balanceElement;
        }
    }
}
