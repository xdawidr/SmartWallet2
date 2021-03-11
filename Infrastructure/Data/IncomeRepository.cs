using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class IncomeRepository : IIncomeRepository
    {
        private readonly WalletContext _context;

        public IncomeRepository(WalletContext context)
        {
            _context = context;
        }

        public async Task<Income> GetIncomeByIdAsync(int id)
        {
            return await _context.Incomes.FindAsync();
        }

        public async Task<IReadOnlyList<Income>> GetIncomesAsync()
        {
            return await _context.Incomes.ToListAsync();
        }

        public async Task<IReadOnlyList<IncomeType>> GetIncomeTypeAsync()
        {
            return await _context.IncomeTypes.ToListAsync();
        }
    }
}