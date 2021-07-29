using System;
using GestionParamsBase.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionParamsBase.Repository
{
    public class ModuleRepository : IRepository<Module>
    {
        private IList<Module> Modules;
        public ModuleRepository()
        {
            Modules = new List<Module>();
        }
        public void Ajouter(Module element)
        {
            Modules.Add(element);
        }

        public IList<Module> Lister()
        {
            return Modules;
        }

        public Module ListerSelonId(long id)
        {
            return Modules.Single(m => m.IdM == id);
        }

        public void Modifier(long id, Module element)
        {
            var ancienModule = Modules.SingleOrDefault(m => m.IdM == id);
            ancienModule.TitleM = element.TitleM;
            ancienModule.DescriptionM = element.DescriptionM;
            ancienModule.CreditM = element.CreditM;
            ancienModule.CoefEx = element.CoefEx;
            ancienModule.CoefDS = element.CoefDS;
            ancienModule.CoefCc = element.CoefCc;
            ancienModule.CoefTp = element.CoefTp;
            ancienModule.UE = element.UE;
        }

        public void Supprimer(long id)
        {
            var Module = Modules.SingleOrDefault(m => m.IdM == id);
            Modules.Remove(Module);
        }
    }
}
