using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCORE_MYSQL.Models
{
    [Table("tb_nota")]
    public class Nota
    {
        [Key]
        [Column("id_nota")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public int Id_nota { get; set; }

        [Column("Id_matricula")]
        [ForeignKey("Matricula")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Id Matricula")]
        public int Id_matricula { get; set; }

        [Column("Id_disciplina")]
        [ForeignKey("Disciplina")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public int Id_disciplina { get; set; }

        [Column("nota1")]
        [Required(ErrorMessage = "Campo nota 1 é obrigatório!")]
        public double Nota1 { get; set; }

        [Column("nota2")]
        [Required(ErrorMessage = "Campo nota 2 é obrigatório!")]
        public double Nota2 { get; set; }

        [Column("nota3")]
        [Required(ErrorMessage = "Campo nota 3 é obrigatório!")]
        public double Nota3 { get; set; }

        [Column("nota4")]
        [Required(ErrorMessage = "Campo nota 4 é obrigatório!")]
        public double Nota4 { get; set; }

        [Column("media")]
        [Required(ErrorMessage = "Campo média é obrigatório!")]
        [Display(Name = "Média")]
        [Range(0, 10, ErrorMessage = "A média deve ser entre 0 e 10.")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [DataType(DataType.Currency)]         
        public double Media { get; set; }

        [Column("situacao")]
        [Required(ErrorMessage = "Campo situação é obrigatório!")]
        [Display(Name = "Situação")]
        [StringLength(50, ErrorMessage = "A situação deve ter no máximo 50 caracteres.")]
        public string Situacao { get; set; } = null;

        [Column("data_nota")]
        [Required(ErrorMessage = "Campo data nota é obrigatório!")]
        [Display(Name = "Data Nota")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Data_nota { get; set; } = DateTime.Now;

        [Column("id_aluno")]
        [Display(Name = "Id Aluno")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public int Id_aluno { get; set; }

        [Column("data_aprovacao")]
        [Display(Name = "Data Aprovação")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? Data_aprovacao { get; set; } = null;

        [Column("id_curso")]
        [ForeignKey("Curso")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Id Curso")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public int Id_curso { get; set; }
    }
}
