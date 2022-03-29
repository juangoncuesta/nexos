using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Titulo { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Año { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Genero { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string NumeroPaginas { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Editorial { get; set; }


        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Autor { get; set; }


        [Required]
        [Column(TypeName = "varchar(100)")]
        public string NombreCompleto { get; set; }


        [Required]
        [Column(TypeName = "varchar(100)")]
        public string FechaNacimiento { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Ciudad { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string CorreoElectronico { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string NombreEditorial { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string DirecciorCorrespondencia { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Telefono { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string CorreoEditorial { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string MaximoLibros { get; set; }

    }
}
