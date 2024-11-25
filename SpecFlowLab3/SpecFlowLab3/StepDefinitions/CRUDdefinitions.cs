using System;
using RestSharp;
using TechTalk.SpecFlow;

namespace Lab3TestApi.StepDefinitions
{
    [Binding]
    public sealed class ApiStepDefinitions
    {
        RestClient client = new RestClient("https://restful-booker.herokuapp.com/");

        [Given("url to test")]
        public string GoToURL()
        {
            string clientURL = "https://restful-booker.herokuapp.com/";
            return clientURL;

        }

        [Then("i test post")]
        public int POSTtest()
        {
            RestRequest request = new RestRequest(this.GoToURL() + "auth", Method.Post);
            var response = client.Execute(request).StatusCode;
            return (int)response;
        }

        [Then("i test get")]
        public int GETtest()
        {
            RestRequest request = new RestRequest(this.GoToURL() + "booking", Method.Get);
            var response = client.Execute(request).StatusCode;
            return (int)response;
        }

        [Then("i test put")]
        public int PUTtest()
        {


            RestRequest request = new RestRequest(this.GoToURL() + "booking/73", Method.Put);

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", "Basic YWRtaW46cGFzc3dvcmQxMjM=");

            request.AddJsonBody(new
            {
                firstname = "James",
                lastname = "Brown",
                totalprice = 111,
                depositpaid = true,
                bookingdates = new
                {
                    checkin = "2018-01-01",
                    checkout = "2019-01-01"
                },
                additionalneeds = "Breakfast"

            }
                );

            var response = client.Execute(request).StatusCode;
            return (int)response;
        }

        [Then("i test delete")]
        public int DELETEtest()
        {
            RestRequest request = new RestRequest(this.GoToURL() + "booking/73", Method.Delete);
            request.AddHeader("Authorization", "Basic YWRtaW46cGFzc3dvcmQxMjM=");
            var response = client.Execute(request).StatusCode;
            return (int)response;
        }




    }
}