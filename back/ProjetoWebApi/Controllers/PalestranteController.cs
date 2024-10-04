using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoWebApi.Data;
using ProjetoWebApi.Models;

namespace ProjetoWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PalestranteController : ControllerBase
    {
        private readonly DataContext context;

        public PalestranteController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Palestrante>> get() {
            var palestrantes = this.context.Palestrantes;
            return Ok(palestrantes);
        }
    }
}