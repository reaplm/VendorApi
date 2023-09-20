using System;
using Vendor.Domain.Entitities;

namespace Vendor.Application.Common.Interface
{
	public interface IMerchantRepository
	{
        Task<List<Merchant>> FindAll();
        Task<Merchant> FindById(int id);
    }
}

