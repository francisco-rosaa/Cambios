﻿using Cambios.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Cambios.Services
{
    public class ApiService
    {
        public async Task<Response> GetRates(string baseUrl, string controller)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(baseUrl);

                var response = await client.GetAsync(controller);

                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result
                    };
                }

                var rates = JsonConvert.DeserializeObject<List<Rate>>(result);

                return new Response
                {
                    IsSuccess = true,
                    Result = rates
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }
    }
}
