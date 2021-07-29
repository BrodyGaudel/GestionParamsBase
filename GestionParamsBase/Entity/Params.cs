using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionParamsBase.Entity
{
    public class Params
    {
        [Key]
        public long IdP { get; set; }
        public string Logo { get; set; }
        public string Slogan { get; set; }
        public string Theme { get; set; }
        //constructor
        public Params(string logo, string slogan, string theme)
        {
            Logo = logo;
            Slogan = slogan;
            Theme = theme;
        }

    }
}
