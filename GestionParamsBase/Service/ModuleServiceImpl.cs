using GestionParamsBase.Entity;
using GestionParamsBase.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionParamsBase.Service
{

    public class ModuleServiceImpl : ModuleService
    {
        ModuleRepository moduleRepository;
        public void DeleteModule(long IdM)
        {
            moduleRepository.Supprimer(IdM);
        }

        public Module GetModule(long IdM)
        {
            return moduleRepository.ListerSelonId(IdM);
        }

        public List<Module> GetModules()
        {
            return (List<Module>)moduleRepository.Lister();
        }

        public void UpdateModule(long IdM, Module m)
        {
            moduleRepository.Modifier(IdM, m);
        }
        public void AddModule(Module m)
        {
            moduleRepository.Ajouter(m);
        }
    }
}
