using BackendCreditCards.BackendCreditCards.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BackendCreditCards.BackendCreditCards.Infrastructure.Repository
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        { 
        }
        public DbSet<CreditCard> CreditCard { get; set; }
    }
}
