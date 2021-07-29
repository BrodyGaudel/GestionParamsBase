using System;
using System.Collections.Generic;
using GestionParamsBase.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace GestionParamsBase.Service
{
    public interface UEService
    {
        List<UE> GetUEs();
        UE GetUE(long IdUE);
        void DeleteUE(long IdUE);
        void UpdateUE(long IdO, UE u);
        void AddUE(UE u);
    }
}
