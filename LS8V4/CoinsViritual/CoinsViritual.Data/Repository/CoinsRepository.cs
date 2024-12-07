using CoinsViritul.Core;
using CoinsViritul.Core.Entity;
using CoinsViritul.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinsViritual.Data.Repository
{
    public class CoinsRepository:ICoinsRepository
    {
        readonly DataContext _dataContext;
        public CoinsRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public List<CoinsEntity> GetAllData()
        {
            string g = "ggg";
            g.CheckA();
            return _dataContext.Coins;
        }


        public bool AddCoins(CoinsEntity coin)
        {
            try
            {

                _dataContext.Coins.Add(coin);
                _dataContext.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }
    }
}
