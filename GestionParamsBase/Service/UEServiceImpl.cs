using GestionParamsBase.Entity;
using GestionParamsBase.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionParamsBase.Service
{
    public class UEServiceImpl : UEService
    {
        UERepository uERepository;
        public void DeleteUE(long IdUE)
        {
            uERepository.Supprimer(IdUE);
        }

        public UE GetUE(long IdUE)
        {
            return uERepository.ListerSelonId(IdUE);
        }

        public List<UE> GetUEs()
        {
            return (List<UE>)uERepository.Lister();
        }

        public void UpdateUE(long IdO, UE u)
        {
            uERepository.Modifier(IdO, u);
        }
        public void AddUE(UE u)
        {
            uERepository.Ajouter(u);
        }
    }
}
