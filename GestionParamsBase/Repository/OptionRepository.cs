using System;
using GestionParamsBase.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionParamsBase.Repository
{
    public class OptionRepository : IRepository<Option>
    {
        private IList<Option> Options { get; set; }
        public OptionRepository()
        {
            Options = new List<Option>();
        }

        public void Ajouter(Option element)
        {
            Options.Add(element);
        }

        public IList<Option> Lister()
        {
            return Options;
        }

        public Option ListerSelonId(long id)
        {
            return Options.Single(o => o.IdO == id);
        }

        public void Modifier(long id, Option element)
        {
            var ancienneOption = Options.SingleOrDefault(o => o.IdO == id);
            ancienneOption.TitleO = element.TitleO;
            ancienneOption.DescriptionO = element.DescriptionO;
            ancienneOption.Filliere = element.Filliere;
        }

        public void Supprimer(long id)
        {
            var Option = Options.SingleOrDefault(o => o.IdO == id);
            Options.Remove(Option);
        }
    }
}
