using Microsoft.EntityFrameworkCore;
using W_webovka_W_sigma2281337.Models;

namespace W_webovka_W_sigma2281337.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<OrderSubmission> OrderSubmissions { get; set; }
    }
}