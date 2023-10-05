using System;
using Microsoft.Extensions.DependencyInjection;
using Vendor.Api.Queries;

namespace Vendor.Api.Extensions
{
	public static class DependencyInjection
	{
		public static void AddApi(this IServiceCollection services,
			IConfiguration configuration)
		{
			//services.AddMediatR(typeof(GetMerchantsQuery));
			//services.AddMediatR(typeof(GetMerchantByIdQuery));
		}
	}
}

