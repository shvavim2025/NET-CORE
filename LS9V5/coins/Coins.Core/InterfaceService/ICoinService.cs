using Coins.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins.Core.InterfaceService
{
    public  interface ICoinService
    {
        List<CoinEntity> GetList();

        CoinEntity Get(int id);
        CoinEntity Add(CoinEntity coin);
    }
}
