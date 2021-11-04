using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JobTindProyecto.Dominio
{
    public class Anuncio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnuncioId { get; set; }

        [Display(Name = "Anuncio")]
        [Required(ErrorMessage = "DATO OBLIGATORIO")]
        public string Anuncios { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "DATO OBLIGATORIO")]
        public int UsuarioID { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "DATO OBLIGATORIO")]
        public int EmpresaID { get; set; }


        public Usuario Usuario { get; set; }

        public Empresa Empresa { get; set; }
    }
}

