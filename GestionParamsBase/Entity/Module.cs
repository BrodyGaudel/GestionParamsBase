using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionParamsBase.Entity
{
    public class Module
    {
        //proprieté de base
        [Key]
        public long IdM { get; set; }

        [Required(ErrorMessage = "This field is required !")]
        [StringLength(25)]
        [MaxLength(50)]
        public string TitleM { get; set;}

        [DataType(DataType.MultilineText)]
        public string DescriptionM { get; set; }
        public double CreditM { get; set; }
        public double CoefEx { get; set; }
        public double CoefDS { get; set; }
        public double CoefCc { get; set; }
        public double CoefTp { get; set; }
        //proprieté de navigation

        [ForeignKey("IdO")]
        public virtual UE UE { get; set; }
        //constructor
        public Module(string titleM, string descriptionM, double creditM, double coefEx, double coefDS, double coefCc, double coefTp)
        {
            TitleM = titleM;
            DescriptionM = descriptionM;
            CreditM = creditM;
            CoefEx = coefEx;
            CoefDS = coefDS;
            CoefCc = coefCc;
        }
        //toString
        public override string ToString()
        {
            return base.ToString();
        }



    }
}
