using Coins.server.DTO;
using Coins.server.Service;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Coins.server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoinsController : ControllerBase
    {


        
        readonly CoinsSerice _coinsSerice;
        

        public CoinsController(CoinsSerice coinsSerice)
        {
            _coinsSerice=   coinsSerice;
        }

        [HttpGet]
        public ActionResult<List<string>> Get()
        {
            List<String> result = _coinsSerice.getLists();
            if (result == null) { return NotFound(); }
            return (result);
        }

        [HttpGet("GetById")]    
        public ActionResult<CoinDTO> GetById(string id)
        {
            if (id == null) { return Unauthorized(); }
            CoinDTO result = _coinsSerice.getID(id);
            if (result == null) { return NotFound(); }
            return (result);
        }

        [HttpPost]

        public ActionResult<bool> Add(CoinDTO dTO)
        {
            if (_coinsSerice.getID(dTO.id) != null)
            {
                return BadRequest();
            }
            var result = _coinsSerice.add(dTO);
            if(!result)
            {
                return BadRequest(false);
            }
            else 
                return true;
        }
    }
}
