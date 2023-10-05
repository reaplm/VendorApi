using MediatR;
using Microsoft.AspNetCore.Mvc;
using Vendor.Api.Commands;
using Vendor.Api.Queries;
using Vendor.Application.Models;
using Vendor.Domain.Entitities;

namespace Vendor.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MerchantController : ControllerBase
    {
        private IMediator _mediatR;


        public MerchantController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        // GET: /<controller>/
        [HttpGet]
        public async Task<IActionResult> Get(MerchantParameters merchantParameters)
        {
            try
            {
                var vendors = await _mediatR.Send(
                    new GetMerchantsQuery { MerchantParameters = merchantParameters });

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
                var vendor = await _mediatR.Send(
                    new GetMerchantByIdQuery { Id = id });

                return Ok(vendor);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There was an exception retrieving records");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody]Merchant merchant)
        {
            try
            {

                var merchantResult = await _mediatR.Send(new CreateMerchantCommand { Merchant = merchant });
                return StatusCode(201, merchantResult);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There was an exception retrieving records");
            }
        }
    }

}

