using Microsoft.EntityFrameworkCore;
using OrdersApp.Models;

namespace OrdersApp.Data
{
    public class OrdersAppDbContext: DbContext
    {
        public OrdersAppDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }
    }


}
