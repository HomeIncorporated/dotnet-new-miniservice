﻿using Company.Application.TodoWebApi.Infrastructure.Db;
using Microsoft.AspNetCore.Mvc;
using NetCoreKit.Infrastructure.EfCore.Extensions;
using System;

namespace Company.Application.TodoWebApi.v1
{
		[Route("")]
	[ApiVersionNeutral]
	[ApiExplorerSettings(IgnoreApi = true)]
	public class HealthController : Controller
	{
		private readonly IServiceProvider _serviceProvider;

		public HealthController(IServiceProvider serviceProvider)
		{
			_serviceProvider = serviceProvider;
		}

		[HttpGet("/healthz")]
		public ActionResult Get()
		{
			try
			{
				_serviceProvider.MigrateDbContext<TodoDbContext>();
			}
			catch (Exception)
			{

				return new BadRequestResult();
			}

			return Ok();
		}
	}
}