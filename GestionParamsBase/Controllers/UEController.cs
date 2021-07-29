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
    public class UEController : ControllerBase
    {
        UEService ueService;
        public UEController()
        {

        }
        // GET all action
        [HttpGet]
        public ActionResult<List<UE>> GetAllUE()
        {
            return ueService.GetUEs();
        }

        // GET by Id action
        [HttpGet("{id}")]
        public ActionResult<UE> GetUE(int id)
        {
            var UE = ueService.GetUE(id);

            if (UE == null)
                return NotFound();

            return UE;
        }
        //POST action
        [HttpPost]
        public IActionResult Create(UE u)
        {
            ueService.AddUE(u);
            return CreatedAtAction(nameof(Create), new { id = u.IdUE }, u);
        }

        // PUT action
        [HttpPut("{id}")]
        public IActionResult UpdateUE(int id, UE u)
        {
            if (id != u.IdUE)
                return BadRequest();

            var existingUE = ueService.GetUE(id);
            if (existingUE is null)
                return NotFound();

            ueService.UpdateUE(id, u);

            return NoContent();
        }

        // DELETE action
        [HttpDelete("{id}")]
        public IActionResult DeleteUE(int id)
        {
            var u = ueService.GetUE(id);

            if (u is null)
                return NotFound();

            ueService.DeleteUE(id);

            return NoContent();
        }
    }
}
