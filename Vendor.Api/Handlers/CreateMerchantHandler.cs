using MediatR;
using Vendor.Api.Commands;
using Vendor.Application.Common.Interface;
using Vendor.Domain.Entitities;

namespace Vendor.Api.Handlers
{
	public class CreateMerchantHandler : IRequestHandler<CreateMerchantCommand, Merchant>
	{
		private IMerchantRepository _merchantRepository;

		public CreateMerchantHandler(IMerchantRepository merchantRepository)
		{
			_merchantRepository = merchantRepository;
		}

		public async Task<Merchant> Handle(CreateMerchantCommand request, CancellationToken cancellationToken)
		=> await _merchantRepository.AddMerchant(request.Merchant);
    }
}
