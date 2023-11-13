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
    internal class UsersService : IUsersInterface
    {
        const string baseUrl = "https://hackaton-yakse.ru/";

        public async Task<Users> login(string login, string password)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest("users/login", Method.Post);
            request.AddHeader("Content-Type", "application/json");

            var requestData = new
            {
                login = login,
                password = password
            };

            // Конвертируем объект в JSON
            string jsonBody = JsonConvert.SerializeObject(requestData);

            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);

            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                var result = JsonConvert.DeserializeObject<UserResponce>(rawResponse);


                if (result != null)
                {
                    Users rooms = result.data;
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

        public async Task<Users> update(int id, string login, string password)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest($"users/{id}", Method.Put);
            request.AddHeader("Content-Type", "application/json");
            
            var requestData = new
            {
                login = login,
                password = password
            };
            string jsonBody = JsonConvert.SerializeObject(requestData);
            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);
            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                var result = JsonConvert.DeserializeObject<UserResponce>(rawResponse);


                if (result != null)
                {
                    Users rooms = result.data;
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
