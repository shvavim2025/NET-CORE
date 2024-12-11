using Coins.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins.Core.InterfaceRepository
{
    public interface ICoinRepository
    {
        List<CoinEntity> GetCoins();
        CoinEntity AddCoin(CoinEntity coin);
        CoinEntity GetCoinById(int coinId);
    }
}
