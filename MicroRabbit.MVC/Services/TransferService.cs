﻿using MicroRabbit.MVC.Models.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _apiClient;
        public TransferService(HttpClient apiclient)
        {
            _apiClient = apiclient;
        }
        public async Task Transfer(TransferDTO transferDto)
        {
            var uri = "http://localhost:5000/Banking";
            var transferContent = new StringContent(JsonConvert.SerializeObject(transferDto),Encoding.UTF8,"application/json");
            var response = await _apiClient.PostAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
