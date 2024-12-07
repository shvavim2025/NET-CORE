using CoinsViritul.Core.Entity;
using System.Text.Json;

namespace CoinsViritual.Data
{
    public class DataContext
    {

        public List<CoinsEntity> Coins { get; set; }


        public DataContext()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");



            string jsonString = File.ReadAllText(path);
            Coins = JsonSerializer.Deserialize<List<CoinsEntity>>(jsonString);// typeof(DataCoins)); ;

         
        }
        
        public void SaveChange()
        {
            
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");



                string jsonString = JsonSerializer.Serialize<List<CoinsEntity>>(Coins);

                File.WriteAllText(path, jsonString);
               ;
           
        }
    }
}
