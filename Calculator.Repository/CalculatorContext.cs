using Microsoft.EntityFrameworkCore;

namespace Calculator.Repository
{
    public class CalculatorContext : DbContext
    {
        public CalculatorContext(DbContextOptions<CalculatorContext> options)
            : base(options)
        {
        }

        public DbSet<ApiRequestLog> ApiRequestLogs { get; set; }
    }

}
