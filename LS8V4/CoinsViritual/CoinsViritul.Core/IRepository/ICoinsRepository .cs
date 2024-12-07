using CoinsViritul.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinsViritul.Core.IRepository
{
    public interface ICoinsRepository
    {
        List<CoinsEntity> GetAllData();
        bool AddCoins(CoinsEntity coin);
    }
}
