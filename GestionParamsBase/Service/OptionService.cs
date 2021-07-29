using System;
using System.Collections.Generic;
using GestionParamsBase.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace GestionParamsBase.Service
{
    public interface OptionService
    {
        List<Option> GetOptions();
        Option GetOption(long IdO);
        void DeleteOption(long IdO);
        void UpdateOption(long IdO, Option o);
        void AddOption(Option o);
    }
}
