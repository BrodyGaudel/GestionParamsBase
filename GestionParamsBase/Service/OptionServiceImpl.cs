using GestionParamsBase.Entity;
using GestionParamsBase.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionParamsBase.Service
{
    public class OptionServiceImpl : OptionService
    {
        OptionRepository optionRepository;
        public void DeleteOption(long IdO)
        {
            optionRepository.Supprimer(IdO);
        }

        public Option GetOption(long IdO)
        {
            return optionRepository.ListerSelonId(IdO);
        }

        public List<Option> GetOptions()
        {
            return (List<Option>)optionRepository.Lister();
        }

        public void UpdateOption(long IdO, Option o)
        {
            optionRepository.Modifier(IdO, o);
        }
        public void AddOption(Option o)
        {
            optionRepository.Ajouter(o);
        }
    }
}
