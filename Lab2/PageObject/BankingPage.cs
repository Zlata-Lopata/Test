using OpenQA.Selenium;


namespace SpecFlowProject.PageObjects
{
    public class BankingPage
    {
        private IWebDriver driver;

        public BankingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void LoginAsUser(string userName)
        {
            driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/login");
            driver.FindElement(By.Id("userSelect")).Click();
            driver.FindElement(By.XPath($"//option[. = '{userName}']")).Click();
            driver.FindElement(By.CssSelector(".btn-default")).Click();
        }

        public void NavigateToBankingPage()
        {
            driver.FindElement(By.CssSelector(".btn-lg:nth-child(3)")).Click(); 
        }

        public void WithdrawAmount(string amount)
        {
            driver.FindElement(By.CssSelector(".form-control")).SendKeys(amount); // Ввод суми
            driver.FindElement(By.CssSelector(".btn-default")).Click(); // Натискання кнопки Withdraw
        }

        public string GetBalance()
        {
            var balanceElement = driver.FindElement(By.CssSelector(".ng-binding"));
            return balanceElement.Text;
        }
    }
}
