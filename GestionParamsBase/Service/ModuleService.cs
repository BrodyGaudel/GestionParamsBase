using System;
using GestionParamsBase.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionParamsBase.Service
{
    public interface ModuleService
    {
        List<Module> GetModules();
        Module GetModule(long IdM);
        void DeleteModule(long IdM);
        void UpdateModule(long IdM, Module m);
        void AddModule(Module m);
    }
}
