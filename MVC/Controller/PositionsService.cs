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
    internal class PositionsService : IPositionsInterface
    {
        const string baseUrl = "https://hackaton-yakse.ru/";

        public async Task<Position> create(string title, int salary)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest("positions", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var requestData =
            new {
                title = title,
                salary = salary
            };
            string jsonBody = JsonConvert.SerializeObject(requestData);
            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);
            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                var result = JsonConvert.DeserializeObject<PositionResponse>(rawResponse);


                if (result != null)
                {
                    Position positions = result.data;
                    return positions;
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
            var request = new RestRequest($"positions/{id}", Method.Delete);
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

        public async Task<List<Position>> getAll()
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest("positions");
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                var result = JsonConvert.DeserializeObject<PositionsResponse>(rawResponse);


                if (result != null)
                {
                    List<Position> positions = result.data;
                    return positions;
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

        public async Task<Position> getId(int id)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest($"positions/{id}");
            request.AddHeader("Content-Type", "application/json");
            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                var result = JsonConvert.DeserializeObject<PositionResponse>(rawResponse);


                if (result != null)
                {
                    Position positions = result.data;
                    return positions;
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

        public async Task<Position> update(int id, string title, int salary)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest($"positions/{id}", Method.Put);
            request.AddHeader("Content-Type", "application/json");
            var requestData =
            new
            {
                title = title,
                salary = salary
            };
            string jsonBody = JsonConvert.SerializeObject(requestData);
            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);
            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                var result = JsonConvert.DeserializeObject<PositionResponse>(rawResponse);


                if (result != null)
                {
                    Position positions = result.data;
                    return positions;
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
