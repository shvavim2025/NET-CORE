using Coins.Core.InterfaceRepository;
using Coins.Core.InterfaceService;
using Coins.Data.Repository;
using Coins.Data;
using Coins.Service;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;

namespace Coins.Api
{
    public  static class Extion
    {

        public static  void   ServiceScope(this string s )
        {
            s.Contains("אבא");
        }

        public static void ServieDependencyInjector(this IServiceCollection s)
        {
           s.AddScoped<ICoinService, CoinService>();
           s.AddScoped<ICoinRepository, CoinRepository>();
         
            s.AddDbContext<DataContext>(option =>
            {
                option.UseSqlServer("Data Source = sqlsrv; Initial Catalog = CoinsV5; Integrated Security = true; ");
                //  "User ID = shuli; Password = 1234; TrustServerCertificate = True; Encrypt = False");
            });
        }
    }
}
