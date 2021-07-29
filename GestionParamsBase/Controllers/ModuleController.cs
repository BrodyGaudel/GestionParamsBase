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
    public class ModuleController : ControllerBase
    {
        ModuleService moduleService;
        public ModuleController()
        {

        }
        // GET all action
        [HttpGet]
        public ActionResult<List<Module>> GetAllModule()
        {
            return moduleService.GetModules();
        }

        // GET by Id action
        [HttpGet("{id}")]
        public ActionResult<Module> GetModule(int id)
        {
            var Module = moduleService.GetModule(id);

            if (Module == null)
                return NotFound();

            return Module;
        }
        //POST action
        [HttpPost]
        public IActionResult Create(Module m)
        {
            moduleService.AddModule(m);
            return CreatedAtAction(nameof(Create), new { id = m.IdM }, m);
        }

        // PUT action
        [HttpPut("{id}")]
        public IActionResult UpdateModule(int id, Module m)
        {
            if (id != m.IdM)
                return BadRequest();

            var existingModule = moduleService.GetModule(id);
            if (existingModule is null)
                return NotFound();

            moduleService.UpdateModule(id, m);

            return NoContent();
        }

        // DELETE action
        [HttpDelete("{id}")]
        public IActionResult DeleteModule(int id)
        {
            var m = moduleService.GetModule(id);

            if (m is null)
                return NotFound();

            moduleService.DeleteModule(id);

            return NoContent();
        }

    }
}
