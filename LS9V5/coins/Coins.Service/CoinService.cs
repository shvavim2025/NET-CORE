using Coins.Core.Entity;
using Coins.Core.InterfaceRepository;
using Coins.Core.InterfaceService;


namespace Coins.Service
{
    public class CoinService: ICoinService
    {

        readonly ICoinRepository _coinRepository;
         
        public CoinService(ICoinRepository coinRepository) {
        _coinRepository = coinRepository;
        }

        public CoinEntity Add(CoinEntity coin)
        {
           return  _coinRepository.AddCoin(coin);
        }

        public CoinEntity Get(int id)
        {
         return   _coinRepository.GetCoinById(id);
        }

        public List<CoinEntity> GetList()
        {

            ///בדיקה שהוא מנהל 
            ///
            //כתיבה לוגיקה עסקית 

            return _coinRepository.GetCoins();
        }
    }
}
