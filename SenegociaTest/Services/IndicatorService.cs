using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using SenegociaTest.Entities;

namespace SenegociaTest.Services
{
    public class IndicatorService : IIndicatorService
    {

        public Indicator ConsultUFValue(DateTime date, string url)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest($"/uf/{date:dd-MM-yyyy}", Method.GET);
                
                //var response = client.Execute<Indicator>(request);
                var response = client.Execute(request);
                return JsonConvert.DeserializeObject<Indicator>(response.Content);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
