using Microsoft.AspNetCore.Mvc;
using GestionParamsBase.Entity;
using GestionParamsBase.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionParamsBase.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParamsController : ControllerBase
    {
        ParamsService paramsService;
        public ParamsController()
        {

        }
        // GET all action
        [HttpGet]
        public ActionResult<List<Params>> GetAllParamss()
        {
            return paramsService.GetParamss();
        }

        // GET by Id action
        [HttpGet("{id}")]
        public ActionResult<Params> GetParams(int id)
        {
            var Params = paramsService.GetParams(id);

            if (Params == null)
                return NotFound();

            return Params;
        }
        //POST action
        [HttpPost]
        public IActionResult Create(Params p)
        {
            paramsService.AddParams(p);
            return CreatedAtAction(nameof(Create), new { id = p.IdP }, p);
        }

        // PUT action
        [HttpPut("{id}")]
        public IActionResult UpdateParams(int id, Params p)
        {
            if (id != p.IdP)
                return BadRequest();

            var existingParams = paramsService.GetParams(id);
            if (existingParams is null)
                return NotFound();

            paramsService.UpdateParams(id, p);

            return NoContent();
        }

        // DELETE action
        [HttpDelete("{id}")]
        public IActionResult DeleteParams(int id)
        {
            var p = paramsService.GetParams(id);

            if (p is null)
                return NotFound();

            paramsService.DeleteParams(id);

            return NoContent();
        }

    }
}
