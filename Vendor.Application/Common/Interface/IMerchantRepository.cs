using System;
using Vendor.Application.Models;
using Vendor.Domain.Entitities;

namespace Vendor.Application.Common.Interface
{
	public interface IMerchantRepository
	{
        Task<List<Merchant>> FindAll(MerchantParameters merchantParameters);
        Task<Merchant> FindById(int id);
    }
}

