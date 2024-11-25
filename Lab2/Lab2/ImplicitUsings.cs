global using FluentAssertions;
global using Microsoft.VisualStudio.TestTools.UnitTesting;
global using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using SpecFlowLab2.StepDefinitions;

namespace Seleniumtest
{
    [TestClass]
    public class ExampleTest
    {


        [TestMethod]
        public void SampleTest()
        {
          
             var testStep = new StepDefinitions();

            testStep.LoginStep();
            testStep.BankingStep();
            testStep.WithdrawStep();
             string actual = testStep.ResultStep();
            string expexted = "Transaction successful";
            Assert.AreEqual(actual, expexted);





        }


    }
}