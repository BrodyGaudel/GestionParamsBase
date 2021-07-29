using System;
using GestionParamsBase.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionParamsBase.Repository
{
    public class UERepository : IRepository<UE>
    {
        private IList<UE> UEs { get; set; }
        public UERepository()
        {
            UEs = new List<UE>();
        }
        public void Ajouter(UE element)
        {
            UEs.Add(element);
        }

        public IList<UE> Lister()
        {
            return UEs;
        }

        public UE ListerSelonId(long id)
        {
            return UEs.Single(u => u.IdUE == id);
        }

        public void Modifier(long id, UE element)
        {
            var ancienneUE = UEs.SingleOrDefault(u => u.IdUE == id);
            ancienneUE.TitleUE = element.TitleUE;
            ancienneUE.DescriptionUE = element.DescriptionUE;
            ancienneUE.ClasseUE = element.ClasseUE;
            ancienneUE.CreditUE = element.CreditUE;
            ancienneUE.Option = element.Option;
        }

        public void Supprimer(long id)
        {
            var UE = UEs.SingleOrDefault(u => u.IdUE == id);
            UEs.Remove(UE);
        }
    }
}

