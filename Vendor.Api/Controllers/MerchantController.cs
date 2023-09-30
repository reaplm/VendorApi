using Microsoft.AspNetCore.Mvc;
using Vendor.Application.Common.Interface;
using Vendor.Application.Models;
using Vendor.Domain.Entitities;

namespace Vendor.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MerchantController : ControllerBase
    {
        private IMerchantRepository _merchantRepository;


        public MerchantController(IMerchantRepository merchantRepository)
        {
            _merchantRepository = merchantRepository;
        }

        // GET: /<controller>/
        [HttpGet]
        public async Task<IActionResult> Get(MerchantParameters merchantParameters)
        {
            try
            {
                List<Merchant> vendors = await _merchantRepository.FindAll(merchantParameters);

                return Ok(vendors);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There was an exception retrieving records");
            }

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var vendor = await _merchantRepository.FindById(id);

                return Ok(vendor);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There was an exception retrieving records");
            }
        }
    }

}

