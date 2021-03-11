using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IExpenseRepository
    {
        Task<Expense> GetExpenseByIdAsync(int id);
        Task<IReadOnlyList<Expense>> GetExpensesAsync();
        Task<IReadOnlyList<ExpenseType>> GetExpenseTypeAsync();
    }
}