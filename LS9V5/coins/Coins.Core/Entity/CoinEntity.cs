using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coins.Core.Entity
{
    [Table("Coin")]
    public class CoinEntity
    {
        [Key]
        public int index { get; set; }
        public string id { get; set; }
       
        [MaxLength(100)]
        public string rank { get; set; }
        public string symbol { get; set; }

        public string? name { get; set; }

    }
}
