using Coins.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Coins.Data
{
    public class DataContext:DbContext
    {
        public DbSet<CoinEntity> Coin { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.LogTo(mesege => Console.Write(mesege));
        }



    }
}
