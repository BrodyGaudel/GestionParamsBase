using System;
using System.Collections.Generic;
using GestionParamsBase.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace GestionParamsBase.Repository
{
    public class ParamsRepository : IRepository<Params>
    {
        private IList<Params> Paramss;
        public ParamsRepository()
        {
            Paramss = new List<Params>();
        }
        public void Ajouter(Params element)
        {
            Paramss.Add(element);
        }

        public IList<Params> Lister()
        {
            return Paramss;
        }

        public Params ListerSelonId(long id)
        {
            return Paramss.Single(p => p.IdP == id);;
        }

        public void Modifier(long id, Params element)
        {
            var ancienParams = Paramss.SingleOrDefault(p => p.IdP == id);
            ancienParams.Logo = element.Logo;
            ancienParams.Theme = element.Theme;
            ancienParams.Slogan = element.Slogan;
        }

        public void Supprimer(long id)
        {
            var Params = Paramss.SingleOrDefault(p => p.IdP == id);
            Paramss.Remove(Params);
        }
    }
}
