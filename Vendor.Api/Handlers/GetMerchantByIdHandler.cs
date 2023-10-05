using System;
using MediatR;
using Org.BouncyCastle.Asn1.Ocsp;
using Vendor.Api.Queries;
using Vendor.Application.Common.Interface;
using Vendor.Domain.Entitities;
using Vendor.Infrastructure.Persistence;

namespace Vendor.Api.Handlers
{
    public class GetMerchantByIdHandler : IRequestHandler<GetMerchantByIdQuery, Merchant>
    {
        private readonly IMerchantRepository _merchantRepository;

        public GetMerchantByIdHandler(IMerchantRepository merchantRepository)
        {
            _merchantRepository = merchantRepository;
        }

        public async Task<Merchant> Handle(GetMerchantByIdQuery request, CancellationToken cancellationToken)
        =>  await _merchantRepository.FindById(request.Id);
    }
}

