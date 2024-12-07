using CoinsViritual.Service;
using CoinsViritul.Core.Entity;
using CoinsViritul.Core.IService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoinsViritual.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoinsController : ControllerBase
    {
        readonly ICoinsService _coinsService;
        public CoinsController(ICoinsService coinsService)
        {
                _coinsService = coinsService;
        }

        // GET: api/<CoinsController>
        [HttpGet]
        public ActionResult<List<CoinsEntity>> Get()
        {
            return _coinsService.GetList();
        }

        // GET api/<CoinsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CoinsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CoinsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CoinsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
