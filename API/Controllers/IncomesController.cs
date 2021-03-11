using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IncomesController : ControllerBase
    {
        private readonly IIncomeRepository _repo;

        public IncomesController(IIncomeRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Income>>> GetIncomes()
        {
            var incomes = await _repo.GetIncomesAsync();
            return Ok(incomes);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Income>> GetIncome(int id)
        {
            return await _repo.GetIncomeByIdAsync(id);
        }
        [HttpGet("types")]
        public async Task<ActionResult<IReadOnlyList<IncomeType>>> GetIncomeType()
        {
            return Ok(await _repo.GetIncomeTypeAsync());
        }
    }
}