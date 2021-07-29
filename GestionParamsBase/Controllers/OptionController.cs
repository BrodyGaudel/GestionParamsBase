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
    public class OptionController : ControllerBase
    {
        OptionService optionService;
        public OptionController()
        {

        }
        // GET all action
        [HttpGet]
        public ActionResult<List<Option>> GetAllOption()
        {
            return optionService.GetOptions();
        }

        // GET by Id action
        [HttpGet("{id}")]
        public ActionResult<Option> GetOption(int id)
        {
            var Option = optionService.GetOption(id);

            if (Option == null)
                return NotFound();

            return Option;
        }
        //POST action
        [HttpPost]
        public IActionResult Create(Option o)
        {
            optionService.AddOption(o);
            return CreatedAtAction(nameof(Create), new { id = o.IdO }, o);
        }

        // PUT action
        [HttpPut("{id}")]
        public IActionResult UpdateOption(int id, Option o)
        {
            if (id != o.IdO)
                return BadRequest();

            var existingFilliere = optionService.GetOption(id);
            if (existingFilliere is null)
                return NotFound();

            optionService.UpdateOption(id, o);

            return NoContent();
        }

        // DELETE action
        [HttpDelete("{id}")]
        public IActionResult DeleteOption(int id)
        {
            var o = optionService.GetOption(id);

            if (o is null)
                return NotFound();

            optionService.DeleteOption(id);

            return NoContent();
        }
    }
}
