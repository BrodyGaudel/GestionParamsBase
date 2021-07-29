using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionParamsBase.Entity
{
    public class UE
    {
        //proprieté de base
        [Key]
        public long IdUE { get; set; }

        [Required(ErrorMessage = "This field is required !")]
        [StringLength(25)]
        [MaxLength(50)]
        public string TitleUE { get; set; }

        [DataType(DataType.MultilineText)]
        public string DescriptionUE { get; set; }

        [Required(ErrorMessage = "This field is required !")]
        public string ClasseUE { get; set; }

        [Required(ErrorMessage = "This field is required !")]
        public double CreditUE { get; set; }

        //proprieté de navigation
        public virtual ICollection<Module> Modules { get; set; }

        [ForeignKey("IdO")]
        public virtual Option Option { get; set; }
        //constructor
        public UE(string titleUE, string descriptionUE, double creditUE, string classeUE)
        {
            TitleUE = titleUE;
            DescriptionUE = descriptionUE;
            CreditUE = creditUE;
            ClasseUE = classeUE;
        }
        //toString
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
