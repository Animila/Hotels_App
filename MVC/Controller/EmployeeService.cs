using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HotelApp.MVVM.Interface;
using HotelApp.MVVM.Model;
using Newtonsoft.Json;
using RestSharp;
using Newtonsoft;

namespace HotelApp.MVVM.Controller
{
    internal class EmployeeService : IEmployeeInterface
    {
        const string baseUrl = "https://hackaton-yakse.ru/";
        public async Task<List<Employee>> getAll()
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest("employees");
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                var result = JsonConvert.DeserializeObject<EmployeesResponse>(rawResponse);


                if (result != null)
                {
                    List<Employee> employees = result.data;
                    return employees;
                } else
                {
                    return null;
                }
            } else
            {
                return null;
            }
        }

        public Task<Employee> getCreate()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> getId()
        {
            throw new NotImplementedException();
        }

        public async Task<StatisticEmployee> getStatistics()
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest("employees/statics");
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                var result = JsonConvert.DeserializeObject<StatisticEmployeeResponse>(rawResponse);


                if (result != null)
                {
                    StatisticEmployee employees = result.data;
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

        public async Task<Employee> create(Employee employee)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest("employees", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var requestData = employee;
            string jsonBody = JsonConvert.SerializeObject(requestData);
            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);
            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                var result = JsonConvert.DeserializeObject<EmployeeResponse>(rawResponse);


                if (result != null)
                {
                    Employee rooms = result.data;
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

      
        public async Task<Employee> update(MergeAccount person)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest($"employees/{person.id}", Method.Put);
            request.AddHeader("Content-Type", "application/json");
            var requestData = person;
            string jsonBody = JsonConvert.SerializeObject(requestData);
            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);
            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                var result = JsonConvert.DeserializeObject<EmployeeResponse>(rawResponse);


                if (result != null)
                {
                    Employee rooms = result.data;
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
            var request = new RestRequest($"employees/{id}", Method.Delete);
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
    }
}
