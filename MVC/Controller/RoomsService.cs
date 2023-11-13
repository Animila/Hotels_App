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
    internal class RoomsService : IRoomsEnterface
    {
        const string baseUrl = "https://hackaton-yakse.ru/";

        public async Task<List<Room>> GetAll()
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest("rooms");
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                var result = JsonConvert.DeserializeObject<RoomsResponse>(rawResponse);


                if (result != null)
                {
                    List<Room> rooms = result.data;
                    return rooms;
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

        public async Task<StatisticRooms> getStatistics()
        {
            
            var client = new RestClient(baseUrl);
            var request = new RestRequest("rooms/statics");
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                var result = JsonConvert.DeserializeObject<StatisticRoomsResponse>(rawResponse);


                if (result != null)
                {
                    StatisticRooms room = result.data;
                    return room;
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
