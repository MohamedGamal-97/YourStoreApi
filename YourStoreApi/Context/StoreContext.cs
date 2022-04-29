using Microsoft.EntityFrameworkCore;
using YourStoreApi.Models;

namespace YourStoreApi.Context
{
    public class StoreContext:DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
