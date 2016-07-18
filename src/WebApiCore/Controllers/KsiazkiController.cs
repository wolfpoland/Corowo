using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiCore.Models;


// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiCore.Controllers
{
    [Route("api/[controller]")]
    public class KsiazkiController : Controller
    {
        public KsiazkiController(IKsiazkiRepository lista)
        {
            this.lista = lista;
        }
        public KsiazkiController()
        {
            lista = new KsiazkiImplementacja();
        }
        public IKsiazkiRepository lista { get; set; }
        
        // GET: api/values
        [HttpGet]
        public IEnumerable<Ksiazki> Get()
        {
            return lista.getAll();
        }

        // GET api/values/5
        [HttpGet("{id}", Name ="GetKsiazka")]
        public IActionResult Get(string id)
        {
            var ksiazka = lista.Find(id);
            if (ksiazka == null)
            {
                return NotFound();
            }
            return new ObjectResult(ksiazka);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Ksiazki value)
        {
            if(value== null)
            {
                return BadRequest();
            }
            lista.Add(value);
            return CreatedAtRoute("GetKsiazka", value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody]Ksiazki value)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var ksiazki = lista.Find(id);
            if (ksiazki == null)
            {
                return NotFound();
            }
            lista.Update(value);
            return new NoContentResult();

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            lista.Remove(id);
        }
    }
}
