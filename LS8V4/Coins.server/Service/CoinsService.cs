using Coins.server.DTO;
using System.Text.Json;

namespace Coins.server.Service
{
    public class CoinsSerice
    {
        readonly IDataContext _dataContext;

        public CoinsSerice(IDataContext dataContext)
        {
                _dataContext = dataContext;
        }
        public List<string> getLists () 
        {
            var data = _dataContext.LoadData();
                if (data == null)
                return null;
            return data.Select(c=>c.id).ToList();

        }

        public CoinDTO getID(string id)
        {
            var data = _dataContext.LoadData();
 if (data == null)
                return null;
            return data.Where(c => c.id == id).FirstOrDefault();

        }

        public bool add(CoinDTO dTO)
        {
            var data = _dataContext.LoadData();
            if (data == null)
                return false;
            data.Add(dTO);
            return _dataContext.SaveData(data);

        }
    }
}
