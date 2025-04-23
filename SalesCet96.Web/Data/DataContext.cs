using Microsoft.EntityFrameworkCore;
using SalesCet96.Web.Data.Entities;

namespace SalesCet96.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }


        public DbSet<Country> Countries { get; set; }

    }
}
