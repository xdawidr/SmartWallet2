using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly WalletContext _context;

        public ExpenseRepository(WalletContext context)
        {
            _context = context;
        }

        public async Task<Expense> GetExpenseByIdAsync(int id)
        {
            return await _context.Expenses
                .Include(p => p.ExpenseType)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IReadOnlyList<Expense>> GetExpensesAsync()
        {
            return await _context.Expenses
                .Include(p => p.ExpenseType)
                .ToListAsync();
        }

        public async Task<IReadOnlyList<ExpenseType>> GetExpenseTypeAsync()
        {
           return await _context.ExpenseTypes.ToListAsync();
        }
    }
}