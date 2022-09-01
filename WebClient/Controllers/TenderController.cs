﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WebClient.Models.DeserializeModels;

namespace WebClient.Controllers
{

    public class TenderController : Controller
    {
        private readonly HttpClient client = new HttpClient();
        public async Task<IActionResult> Index()
        {
            var response = await client.GetAsync(new Uri("http://localhost:5166/api/Tender/GetAll"));

            var content = await response.Content.ReadAsStringAsync();

            var data = JsonSerializer.Deserialize<TenderData>(content);

            return View(data);
        }

        public IActionResult TenderDetail()
        {
            return View();
        }
    }
}