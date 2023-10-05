using System;
using MediatR;
using Vendor.Domain.Entitities;

namespace Vendor.Api.Queries
{
	public class GetMerchantByIdQuery : IRequest<Merchant>
	{
		public int Id { set; get; }
	}
}

