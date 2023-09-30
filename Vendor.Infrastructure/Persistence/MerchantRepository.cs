using System;
using Microsoft.EntityFrameworkCore;
using Vendor.Application.Common.Interface;
using Vendor.Application.Models;
using Vendor.Domain.Entitities;
using Vendor.Infrastructure.Context;

namespace Vendor.Infrastructure.Persistence
{
    public class MerchantRepository : IMerchantRepository
    {
        private VendorContext _context;

        public MerchantRepository(VendorContext context)
        {
            _context = context;
        }

        public async Task<List<Merchant>> FindAll(MerchantParameters merchantParameters)
        {
            return await _context.Merchants
                .ToListAsync();
        }

        public async Task<Merchant> FindById(int id)
        {
            return await _context.Merchants
                .Where(x => x.ID == id)
                .SingleAsync();
        }
    }
}

