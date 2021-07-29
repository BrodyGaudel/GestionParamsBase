using System;
using System.Collections.Generic;
using GestionParamsBase.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace GestionParamsBase.Service
{
    public interface ParamsService
    {
        List<Params> GetParamss();
        Params GetParams(long IdP);
        void DeleteParams(long IdP);
        void UpdateParams(long IdP, Params p);
        void AddParams(Params p);
    }
}
