
using CoinsViritul.Core.Entity;
using CoinsViritul.Core.IRepository;
using CoinsViritul.Core.IService;

namespace CoinsViritual.Service
{
    public class CoinsService: ICoinsService
    {

        readonly ICoinsRepository _coinsRepository;
        public CoinsService(ICoinsRepository coinsRepository
            ) 
        { 
            _coinsRepository=coinsRepository;
        }


        public List<CoinsEntity>GetList()
        {
            return _coinsRepository.GetAllData(); 
        }

    }
}
