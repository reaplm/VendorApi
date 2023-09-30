using System;
namespace Vendor.Application.Models
{
	public class MerchantParameters
	{

        const int maxPageSize = 20;
        public int PageNumber { set; get; } = 1;
        private int _pageSize = 10;
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }
    }
}

