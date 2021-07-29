using GestionParamsBase.Entity;
using GestionParamsBase.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionParamsBase.Controllers
{
    public class FilliereController : Controller
    {
        private IRepository<Filliere> Repository { get; }
        public FilliereController(IRepository<Filliere> repository)
        {
            Repository = repository;
        }



        public IActionResult Index()
        {
            var Fillieres = Repository.Lister();
            return View();
        }
    }
}
