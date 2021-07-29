using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionParamsBase.Repository
{
    public interface IRepository<T>
    {
        IList<T> Lister();
        T ListerSelonId(long id);
        void Ajouter(T element);
        void Modifier(long id, T element);
        void Supprimer(long id);
    }
}
