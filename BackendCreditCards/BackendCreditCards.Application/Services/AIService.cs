using OpenAI;
using OpenAI.Chat;
using BackendCreditCards.BackendCreditCards.Application.Interfaces;
using BackendCreditCards.BackendCreditCards.Domain.Entities;
using System.Threading.Tasks;

namespace BackendCreditCards.BackendCreditCards.Application.Services
{
    public class AIService : IAIService
    {
        private readonly ChatClient _chatClient;

        public AIService(ChatClient chatClient)
        {
            _chatClient = chatClient;
        }

        public async Task<string> AnalyzeTransactionAsync(TransactionRequest request)
        {
            var prompt = $@"
            Analyze this credit card transaction and determine if it's fraudulent.

            Amount: {request.Amount}
            Country: {request.Country}
            Attempts: {request.Attempts}

            Respond with:
            - Fraud risk (Low, Medium, High)
            - Short explanation
            ";

            var response = await _chatClient.CompleteChatAsync(prompt);

            return response.Value.Content[0].Text;
        }
    }


}
