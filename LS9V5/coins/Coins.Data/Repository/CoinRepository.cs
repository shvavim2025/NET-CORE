using Coins.Core.Entity;
using Coins.Core.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins.Data.Repository
{
    public class CoinRepository: ICoinRepository

    {
        readonly DataContext _dataContext;
        public CoinRepository(DataContext dataContext)
        {

            _dataContext = dataContext;

        }

        public List<CoinEntity> GetCoins()
        {
            return _dataContext.Coin.ToList();
        }

        public CoinEntity AddCoin(CoinEntity coin)
        {
            try
            {
                _dataContext.Coin.Add(coin);
                _dataContext.SaveChanges();
                return coin;
            }
            catch (Exception ex)
            {
                return null;
            }


        }
      

        public CoinEntity GetCoinById(int coinId)
        {
            //not   equal 
           //return  _dataContext.Coin.ToList().Where(coins => coins.index == coinId).FirstOrDefault();

        //  return _dataContext.Coin.Find(coinId);

           return _dataContext.Coin.Where(coins => coins.index == coinId).FirstOrDefault();
        }
    }
}
