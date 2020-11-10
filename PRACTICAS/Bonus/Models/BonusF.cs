using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace BonusF.Models
{
    [Table("t_bonus")]
    public class BonusC {

            [StringLength(8, ErrorMessage = "Ingrese un DNI valido", MinimumLength = 8)]
            [RegularExpression("^[0-9]*$", ErrorMessage = "* Solo se permiten números.")]
            [Required(ErrorMessage = "Por favor ingrese su DNI")]            
            [Column("id_bonus")]
            [Key]
            public String dni { get; set;}

            [Required(ErrorMessage = "Por favor ingrese su nombre")]            
            [Column("name_bonus")]
            public String Name { get; set;}

            [Required(ErrorMessage = "Por favor ingrese su apellido")]            
            [Column("lastname_bonus")]
            public String Lastname {get; set;}

            [Required(ErrorMessage = "Por favor ingrese su distrito")]            
            [Column("district_bonus")]
            public String District {get; set;}
            
            [Required(ErrorMessage = "Por favor ingrese el banco donde desea retirar")]            
            [Display(Name="Banco")]
            [Column("bank_bonus")] 
            public String Bank {get; set;}

            [NotMapped]
            public List<SelectListItem> Banks { get; } = new List<SelectListItem>
            {

            
            new SelectListItem { Value = "BN", Text = "Banco de la Nacion" },
            new SelectListItem { Value = "BCP", Text = "Banco de Credito del Peru" },
            new SelectListItem { Value = "BBVA", Text = "BBVA"  },
            new SelectListItem { Value = "Scotiabank", Text = "Scotiabank"  },
            new SelectListItem { Value = "Interbank", Text = "Interbank"  },
            new SelectListItem { Value = "CrediScotia", Text = "CrediScotia"  },
            new SelectListItem { Value = "Financiera Confianza", Text = "Financiera Confianza"  },
            new SelectListItem { Value = "Caja Rural Los Andes", Text = "Caja Rural Los Andes"  },
            new SelectListItem { Value = "Caja de Santa", Text = "Caja de Santa"  },
            new SelectListItem { Value = "Caja Raiz", Text = "Caja Raiz" },

            
            };

            [Range(18, 120, ErrorMessage = "Su edad debe estar entre 18 y 120")]
            [Required(ErrorMessage = "Por favor ingrese su edad")]            
            [Column("age_bonus")] 
            public int Age {get; set;}

            [Required(ErrorMessage = "Por favor ingrese su género")]            
            [Column("gender_bonus")] 
            [Display(Name="Género")] 
            public String Gender {get; set;}

            [NotMapped]
            public String Response { get; set; }




    }

}