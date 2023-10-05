using System;
using MediatR;
using Vendor.Domain.Entitities;
using Vendor.Application.Models;

namespace Vendor.Api.Queries
{
	public class GetMerchantsQuery : IRequest<List<Merchant>>
    {
		public MerchantParameters MerchantParameters { set; get; }

    }

}

