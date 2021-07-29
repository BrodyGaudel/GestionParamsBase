using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using GestionParamsBase.Entity;
using GestionParamsBase.Service;
using System.Linq;
using System.Threading.Tasks;

namespace GestionParamsBase.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilliereController : ControllerBase
    {
        FilliereService filliereService;
        public FilliereController()
        {

        }
        // GET all action
        [HttpGet]
        public ActionResult<List<Filliere>> GetAllFilliere()
        {
            return filliereService.GetFillieres();
        }

        // GET by Id action
        [HttpGet("{id}")]
        public ActionResult<Filliere> GetFilliere(int id)
        {
            var Filliere = filliereService.GetFilliere(id);

            if (Filliere == null)
                return NotFound();

            return Filliere;
        }
        //POST action
        [HttpPost]
        public IActionResult Create(Filliere f)
        {
            filliereService.AddFilliere(f);
            return CreatedAtAction(nameof(Create), new { id = f.IdF }, f);
        }

        // PUT action
        [HttpPut("{id}")]
        public IActionResult UpdateFilliere(int id, Filliere f)
        {
            if (id != f.IdF)
                return BadRequest();

            var existingFilliere = filliereService.GetFilliere(id);
            if (existingFilliere is null)
                return NotFound();

            filliereService.UpdateFilliere(id, f);

            return NoContent();
        }

        // DELETE action
        [HttpDelete("{id}")]
        public IActionResult DeleteFilliere(int id)
        {
            var f = filliereService.GetFilliere(id);

            if (f is null)
                return NotFound();

            filliereService.DeleteFilliere(id);

            return NoContent();
        }
    }
}
