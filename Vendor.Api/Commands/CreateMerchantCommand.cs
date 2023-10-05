using MediatR;
using Vendor.Domain.Entitities;

namespace Vendor.Api.Commands
{
	public class CreateMerchantCommand : IRequest<Merchant>
    {
        public Merchant? Merchant { set; get; }
    }
}

