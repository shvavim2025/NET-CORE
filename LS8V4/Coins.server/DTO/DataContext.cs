using System.Text.Json;

namespace Coins.server.DTO
{
    public class DataContext:IDataContext
    {

        public List<CoinDTO> LoadData()
        {

            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");



                string jsonString = File.ReadAllText(path);
                var AllCoins = JsonSerializer.Deserialize<List<CoinDTO>>(jsonString);// typeof(DataCoins)); ;

                if (AllCoins == null) { return null; }

                return AllCoins;
            }
            catch
            {
                return null;
            }
        }

        public bool SaveData(List<CoinDTO> data)
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");



                string jsonString = JsonSerializer.Serialize<List<CoinDTO>>(data);

                File.WriteAllText(path, jsonString);
                return true;
            }
            catch { return false; }
        }


    }
}
