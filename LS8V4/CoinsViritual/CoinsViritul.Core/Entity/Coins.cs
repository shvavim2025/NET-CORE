using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinsViritul.Core.Entity
{
    public class CoinsEntity
    {
        
            public string id { get; set; }
            public string rank { get; set; }
            public string symbol { get; set; }

            public string name { get; set; }

        public decimal supply { get; set; }


        public decimal priceUsd { get; set; }
       
       
        public string explorer { get; set; }

        
    }
}
