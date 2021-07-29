using System;
using GestionParamsBase.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionParamsBase.Repository
{
    public class FilliereRepository : IRepository<Filliere>
    {
        private IList<Filliere> Fillieres { get; set; }
        public FilliereRepository()
        {
            Fillieres = new List<Filliere>();
        }
        public void Ajouter(Filliere element)
        {
            Fillieres.Add(element);
        }

        public IList<Filliere> Lister()
        {
            return Fillieres;
        }

        public Filliere ListerSelonId(long id)
        {
            return Fillieres.Single(f => f.IdF == id);
        }

        public void Modifier(long id, Filliere element)
        {
            var ancienneFilliere = Fillieres.SingleOrDefault(f => f.IdF == id);
            ancienneFilliere.TitleF = element.TitleF;
            ancienneFilliere.DescriptionF = element.DescriptionF;
        }

        public void Supprimer(long id)
        {
            var Filliere = Fillieres.SingleOrDefault(f => f.IdF == id);
            Fillieres.Remove(Filliere);
        }
    }
}
