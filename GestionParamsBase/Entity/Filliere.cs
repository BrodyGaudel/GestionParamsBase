using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionParamsBase.Entity
{
    public class Filliere
    {
        //proprieté de base
        [Key]
        public long IdF { get; set; }

        [Required(ErrorMessage = "This field is required !")]
        [StringLength(25)]
        [MaxLength(50)]
        public string TitleF { get; set; }

        [DataType(DataType.MultilineText)]
        public string DescriptionF { get; set; }
        //proprieté de navigation
        public virtual ICollection<Option> Options { get; set; }
        //constructor
        public Filliere(long idF, string titleF, string descriptionF)
        {
            IdF = idF;
            TitleF = titleF;
            DescriptionF = descriptionF;
        }
        //toString
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
