using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JobTindProyecto.Dominio
{
    public class Empresa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpresaId { get; set; }

        [Display(Name = "Nombre_Empresa")]
        [Required(ErrorMessage = "DATO OBLIGATORIO")]
        public string Nombre_Empresa { get; set; }

        [Display(Name = "Telefono")]
        [Required(ErrorMessage = "DATO OBLIGATORIO")]
        public int TelefonoEmp { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "DATO OBLIGATORIO")]
        public string EmailEmp { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "DATO OBLIGATORIO")]
        public string ContraseñaEmp { get; set; }

        [Display(Name = "Vacante")]
        [Required(ErrorMessage = "DATO OBLIGATORIO")]
        public string Vacante { get; set; }

        [Display(Name = "Categoría")]
        [Required(ErrorMessage = "DATO OBLIGATORIO")]
        public int CategoriaID { get; set; }

        public Categoria Categoria { get; set; }

        public ICollection<Anuncio> Anuncios { get; set; }

    }
}

