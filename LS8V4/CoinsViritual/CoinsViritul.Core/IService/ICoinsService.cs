using CoinsViritul.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinsViritul.Core.IService
{
    public interface ICoinsService
    {
        List<CoinsEntity> GetList();
    }
}
