using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionParamsBase.Entity
{
    public class Option
    {
        //proprieté de base

        [Key]
        public long IdO { get; set; }
        [Required(ErrorMessage = "This field is required !")]
        [StringLength(25)]
        [MaxLength(50)]
        public String TitleO { get; set; }
        [DataType(DataType.MultilineText)]
        public string DescriptionO {get; set;}
        //proprieté de navigation

        [ForeignKey("IdF")]
        public virtual Filliere Filliere { get; set; }
        public virtual ICollection<UE> UEs { get; set; }
        //constructor
        public Option(string titleO, string descriptionO)
        {
            TitleO = titleO;
            DescriptionO = descriptionO;
        }

        //toString
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
