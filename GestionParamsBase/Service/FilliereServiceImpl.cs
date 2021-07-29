using System;
using System.Collections.Generic;
using GestionParamsBase.Repository;
using GestionParamsBase.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace GestionParamsBase.Service
{
    public class FilliereServiceImpl : FilliereService
    {
        FilliereRepository filliereRepository;

        public void DeleteFilliere(long IdF)
        {
            filliereRepository.Supprimer(IdF);
        }

        public Filliere GetFilliere(long IdF)
        {
            return filliereRepository.ListerSelonId(IdF);
        }

        public List<Filliere> GetFillieres()
        {
            return (List<Filliere>)filliereRepository.Lister();
        }

        public void UpdateFilliere(long IdF, Filliere f)
        {
            filliereRepository.Modifier(IdF, f);
        }

        public void AddFilliere(Filliere f)
        {
            filliereRepository.Ajouter(f);
        }
    }
}
