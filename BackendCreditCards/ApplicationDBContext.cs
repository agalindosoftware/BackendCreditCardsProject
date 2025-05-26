using BackendCreditCards.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendCreditCards
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        { 
        }
        public DbSet<CreditCard> CreditCard { get; set; }
    }
}
