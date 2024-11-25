using OpenQA.Selenium;
using SpecFlowProject.PageObjects;

namespace SpecFlowLab2.StepDefinitions
{
    [Binding]
    public sealed class StepDefinitions
    {
       
        BankingPage pagebank = new BankingPage();

        [Then("I am logged in as Hermione Granger")]
        public void LoginStep()
        {

            pagebank.LoginAsUser();

        }
        [Then("I am on the banking page")]
        public void BankingStep()
        {
           pagebank.NavigateToBankingPage();
        }

        [When("I withdraw 100 dollars")]
        public void WithdrawStep()
        {
            pagebank.WithdrawAmount("100");
        }

        [Then("I should see a message")]
        public string ResultStep()
        {
           return pagebank.GetText();

        }
       
    }
}
