using System;
using GestionParamsBase.Repository;
using GestionParamsBase.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionParamsBase.Service
{
    public interface FilliereService
    {
        List<Filliere> GetFillieres();
        Filliere GetFilliere(long IdF);
        void DeleteFilliere(long IdF);
        void UpdateFilliere(long IdF, Filliere f);
        void AddFilliere(Filliere f);
        
    }
}
