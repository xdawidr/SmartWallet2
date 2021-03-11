using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpensesController : ControllerBase
    {
        private readonly IExpenseRepository _repo;

        public ExpensesController(IExpenseRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Expense>>> GetExpenses()
        {
            var expenses = await _repo.GetExpensesAsync();
            return Ok(expenses);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Expense>> GetExpense(int id)
        {
            return await _repo.GetExpenseByIdAsync(id);
        }
        [HttpGet("types")]
        public async Task<ActionResult<IReadOnlyList<ExpenseType>>> GetExpenseType()
        {
            return Ok(await _repo.GetExpenseTypeAsync());
        }
    }
}