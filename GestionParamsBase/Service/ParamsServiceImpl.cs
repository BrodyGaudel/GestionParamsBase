using GestionParamsBase.Entity;
using GestionParamsBase.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionParamsBase.Service
{
    public class ParamsServiceImpl : ParamsService
    {
        ParamsRepository paramsRepository;

        public void DeleteParams(long IdP)
        {
            paramsRepository.Supprimer(IdP);
        }

        public Params GetParams(long IdP)
        {
            return paramsRepository.ListerSelonId(IdP);
        }

        public List<Params> GetParamss()
        {
            return (List<Params>)paramsRepository.Lister();
        }

        public void UpdateParams(long IdP, Params p)
        {
            paramsRepository.Modifier(IdP, p);
        }
        public void AddParams(Params p)
        {
            paramsRepository.Ajouter(p);
        }
    }
}
