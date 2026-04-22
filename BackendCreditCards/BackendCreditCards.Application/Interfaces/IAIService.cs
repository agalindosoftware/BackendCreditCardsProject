using BackendCreditCards.BackendCreditCards.Domain.Entities;
using System.Threading.Tasks;

namespace BackendCreditCards.BackendCreditCards.Application.Interfaces
{
    public interface IAIService
    {
        Task<string> AnalyzeTransactionAsync(TransactionRequest request);
    }
}
