﻿using bookify_service.Interfaces;
using bookify_service.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookify_service
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddServices(this IServiceCollection service)
		{
			service.AddTransient<IAuthenServices, AuthenServices>();

			return service;
		}
	}
}
