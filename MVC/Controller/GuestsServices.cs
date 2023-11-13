using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.MVVM.Interface;
using HotelApp.MVVM.Model;
using Newtonsoft.Json;
using RestSharp;

namespace HotelApp.MVVM.Controller
{
    public class GuestsServices : IGuestsInterface
    {
        const string baseUrl = "https://hackaton-yakse.ru/";
        public async Task<StatisticGuest> getStatistics()
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest("guests/statics");
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                var result = JsonConvert.DeserializeObject<StatisticGuestResponse>(rawResponse);


                if (result != null)
                {
                    StatisticGuest employees = result.data;
                    return employees;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
