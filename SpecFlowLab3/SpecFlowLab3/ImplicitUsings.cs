using Lab3TestApi.StepDefinitions;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;

namespace SeleniumNunit
{
    [TestFixture]
    public class ExampleTest
    {

        TestGithubDefinitions CatTest = new TestGithubDefinitions();
            ApiStepDefinitions bookTest = new ApiStepDefinitions(); 

        [Test]
        public void ApiTestPost()
        {

            Assert.AreEqual(200, bookTest.POSTtest());

        }
        [Test]
        public void ApiTestGet()
        {

            Assert.AreEqual(200, bookTest.GETtest());

        }

        [Test]
        public void ApiTestPut()
        {

            Assert.AreEqual(200, bookTest.PUTtest());

        }

        [Test]
        public void ApiTestDelete()
        {

            Assert.AreEqual(201, bookTest.DELETEtest());

        }


        [Test]
        public void ApiTestGetGithub()
        {

            Assert.AreEqual(200, CatTest.GETtest());

        }


    }
}