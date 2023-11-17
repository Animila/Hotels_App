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
    internal class RoomService : IRoomInterface
    {
        const string baseUrl = "https://hackaton-yakse.ru/";

        public async Task<Room> create(Room room)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest("rooms", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var requestData = room;
            string jsonBody = JsonConvert.SerializeObject(requestData);
            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);
            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                var result = JsonConvert.DeserializeObject<RoomResponse>(rawResponse);


                if (result != null)
                {
                    Room rooms = result.data;
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

        public async Task<int> delete(int id)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest($"rooms/{id}", Method.Delete);
            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return id;
            }
            else
            {
                return 0;
            }
        }

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

        public async Task<Room> update(Room room)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest($"rooms/{room.id}", Method.Put);
            request.AddHeader("Content-Type", "application/json");
            var requestData = room;
            string jsonBody = JsonConvert.SerializeObject(requestData);
            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);
            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                var result = JsonConvert.DeserializeObject<RoomResponse>(rawResponse);


                if (result != null)
                {
                    Room rooms = result.data;
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
    }
}
