using Microsoft.AspNetCore.Mvc;
using CreditProcessingAPI.Models;
using CreditProcessingAPI.Services;

namespace CreditProcessingAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreditController : ControllerBase
    {
        private readonly CreditService _service;

        public CreditController(CreditService service)
        {
            _service = service;
        }

        [HttpPost("process")]
        public IActionResult ProcessCreditRequest([FromBody] CreditRequest request)
        {
            var result = _service.ProcessCreditRequest(request);

            if (result.approved)
            {
                return Ok(new
                {
                    Status = "Aprovado",
                    TotalWithInterest = result.totalWithInterest,
                    InterestAmount = result.interestAmount
                });
            }
            else
            {
                return BadRequest("Solicitação de crédito recusada.");
            }
        }
    }
}
