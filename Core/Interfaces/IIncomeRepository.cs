using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IIncomeRepository
    {
        Task<Income> GetIncomeByIdAsync(int id);
        Task<IReadOnlyList<Income>> GetIncomesAsync();
        Task<IReadOnlyList<IncomeType>> GetIncomeTypeAsync();
    }
}