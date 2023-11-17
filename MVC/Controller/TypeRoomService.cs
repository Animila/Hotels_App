using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.MVC.Interface;
using HotelApp.MVVM.Model;
using Newtonsoft.Json;
using RestSharp;

namespace HotelApp.MVC.Controller
{
    internal class TypeRoomService : ITypeRoomInterface
    {
        const string baseUrl = "https://hackaton-yakse.ru/";

        public async Task<TypeRoom> create(string title)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest("typesroom", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var requestData =
            new
            {
                title = title
            };
            string jsonBody = JsonConvert.SerializeObject(requestData);
            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);
            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                var result = JsonConvert.DeserializeObject<TypeRoomResponse>(rawResponse);


                if (result != null)
                {
                    TypeRoom positions = result.data;
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
            var request = new RestRequest($"typesroom/{id}", Method.Delete);
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

        public async Task<List<TypeRoom>> getAll()
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest("typesroom");
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                var result = JsonConvert.DeserializeObject<TypesRoomResponse>(rawResponse);


                if (result != null)
                {
                    List<TypeRoom> positions = result.data;
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

        public async Task<TypeRoom> getId(int id)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest($"typesroom/{id}");
            request.AddHeader("Content-Type", "application/json");
            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                var result = JsonConvert.DeserializeObject<TypeRoomResponse>(rawResponse);


                if (result != null)
                {
                    TypeRoom positions = result.data;
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

        public async Task<TypeRoom> update(int id, string title)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest($"typesroom/{id}", Method.Put);
            request.AddHeader("Content-Type", "application/json");
            var requestData =
            new
            {
                title = title
            };
            string jsonBody = JsonConvert.SerializeObject(requestData);
            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);
            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                var result = JsonConvert.DeserializeObject<TypeRoomResponse>(rawResponse);


                if (result != null)
                {
                    TypeRoom positions = result.data;
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
