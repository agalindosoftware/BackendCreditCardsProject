using BackendCreditCards.BackendCreditCards.Application.Interfaces;
using BackendCreditCards.BackendCreditCards.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenAI;
using BackendCreditCards.BackendCreditCards.Application.Services;
using OpenAI.Chat;

namespace BackendCreditCards.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var apiKey = configuration["OpenAI:ApiKey"];

            // REGISTRO CORRECTO DEL CHATCLIENT
            services.AddSingleton(sp =>
            {
                return new ChatClient(
                    model: "gpt-4o-mini",
                    apiKey: apiKey
                );
            });

            // REGISTRO DEL SERVICIO DE AI
            services.AddScoped<IAIService, AIService>();

            return services;
           
            // PON TU API KEY DIRECTAMENTE AQUÍ SOLO PARA PROBAR
            //var apiKey = "";

            //services.AddSingleton(sp =>
            //{
            //    return new ChatClient(
            //        model: "gpt-4o-mini",
            //        apiKey: apiKey
            //    );
            //});

            //services.AddScoped<IAIService, AIService>();

            //return services;
        }
    }
}
