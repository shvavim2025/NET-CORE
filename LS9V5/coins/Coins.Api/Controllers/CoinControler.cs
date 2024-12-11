using Coins.Core.Entity;
using Coins.Core.InterfaceService;
using Coins.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Coins.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoinControler : ControllerBase
    {
        // GET: api/<CoinControler>
        readonly ICoinService _coinService;
        public CoinControler(ICoinService coinService) 
        {
            _coinService = coinService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<CoinEntity>> Get()
        {
            return _coinService.GetList();
        }

        // GET api/<CoinControler>/5
        [HttpGet("{id}")]
        public CoinEntity Get(int id)
        {
           return _coinService.Get(id);
        }

        // POST api/<CoinControler>
        [HttpPost]
        public ActionResult<CoinEntity> Post([FromBody] CoinEntity value)
        {
            return _coinService.Add(value);
           
        }

        // PUT api/<CoinControler>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CoinControler>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
