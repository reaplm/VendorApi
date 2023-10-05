using Vendor.Api.Queries;
using Vendor.Domain.Entitities;
using Vendor.Application.Common.Interface;
using MediatR;

namespace Vendor.Api.Handlers
{
    public class GetMerchantsHandler : IRequestHandler<GetMerchantsQuery, List<Merchant>>
    {
		private readonly IMerchantRepository _merchantRepository;

		public GetMerchantsHandler(IMerchantRepository merchantRepository)
		{
            _merchantRepository = merchantRepository;
		}

        public async Task<List<Merchant>> Handle(GetMerchantsQuery request,
            CancellationToken cancellationToken) =>
            await _merchantRepository.FindAll(request.MerchantParameters);

    }
}

