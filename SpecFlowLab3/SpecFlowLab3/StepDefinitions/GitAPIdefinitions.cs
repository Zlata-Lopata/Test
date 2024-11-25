using System;
using RestSharp;
using TechTalk.SpecFlow;

namespace Lab3TestApi.StepDefinitions
{
    [Binding]
    public sealed class TestGithubDefinitions
    {
        RestClient client = new RestClient("https://http.cat/status/226");

        [Given("github url http cat")]
        public string GoToURL()
        {
            string clientURL = "https://http.cat/status/226";
            return clientURL;

        }

        [Then("i test api method get")]
        public int GETtest()
        {
            RestRequest request = new RestRequest(this.GoToURL(), Method.Get);
            var response = client.Execute(request).StatusCode;
            return (int)response; 
        }


    }
}
