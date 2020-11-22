﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SharedModels.RoomService;
using StreamingService.Pages.Shared;

namespace StreamingService.Controllers
{
	[Route("api/[controller]")]
	public class RoomController : ControllerBase
	{
		IConfiguration configuration;
		IHttpClientFactory httpClientFactory;

		public RoomController(IConfiguration configuration, IHttpClientFactory clientFactory)
		{
			this.configuration = configuration;
			this.httpClientFactory = clientFactory;
		}

		[HttpPost]
		public async void GetRoom([FromForm] RoomIM Room)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync(configuration.GetValue<string>("RoomService") + "api/Participante/GetList");
			using var responseStream = await response.Content.ReadAsStreamAsync();
			var participantes = await JsonSerializer.DeserializeAsync
				<List<Participante>>(responseStream);

		}

		public class RoomIM
		{
			public string Room { get; set; }
		}
	}
}