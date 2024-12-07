using Coins.server.DTO;

namespace Coins.server
{
    public interface IDataContext
    {
        public List<CoinDTO> LoadData();
        public bool SaveData(List<CoinDTO> data);
    }
}
