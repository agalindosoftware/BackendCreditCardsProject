using Microsoft.AspNetCore.Mvc;
using BackendCreditCards.BackendCreditCards.Application.Interfaces;
using BackendCreditCards.BackendCreditCards.Domain.Entities;
using System.Threading.Tasks;

namespace BackendCreditCards.BackendCreditCards.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AIController : ControllerBase
    {
        private readonly IAIService _aiService;

        public AIController(IAIService aiService)
        {
            _aiService = aiService;
        }

        [HttpPost("analyze-transaction")]
        public async Task<IActionResult> Analyze(TransactionRequest request)
        {
            var result = await _aiService.AnalyzeTransactionAsync(request);
            return Ok(result);
        }
    }
}
