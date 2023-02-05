using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using RrecetaGatimi.Data.Model;
using RrecetaGatimi.Data.VM;
using RrecetaGatimi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RrecetaGatimi.Controllers
{
    [Route("api/[controller]")]
    public class RecetaController : Controller
    {
        readonly IRecetaService _recetaService;
        public RecetaController(IRecetaService service)
        {
            _recetaService = service;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Receta> Get()
        {
            return _recetaService.Recetat();
        }

        // GET api/values/5
        [HttpGet("{titulli}")]
        public Receta Get(string titulli)
        {
            return _recetaService.GetReceten(titulli);
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody] RecetaVM receta)
        {
            return _recetaService.Create(receta);
        }

        // PUT api/values/5
        [HttpPut("{titulli}")]
        public string Put([FromBody] RecetaVM receta)
        {
            return _recetaService.UpdateReceta(receta);
        }

        // DELETE api/values/5
        [HttpDelete("{titulli}")]
        public string Delete(string titulli)
        {
            return _recetaService.DeleteReceta(titulli);
        }
    }
}

