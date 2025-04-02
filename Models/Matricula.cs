using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCORE_MYSQL.Models
{
    [Table("tb_matricula")]
    public class Matricula
    {
        [Key]
        [Column("id_matricula")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_matricula { get; set; }

        [Column("id_aluno")]
        [ForeignKey("Aluno")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public int Id_aluno { get; set; }

        [Column("id_disciplina")]
        [ForeignKey("Disciplina")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public int Id_disciplina { get; set; }

        [Column("id_curso")]
        [ForeignKey("Id_curso")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public int Id_curso { get; set; }

        [Column("nome_disciplina")]
        [Required(ErrorMessage = "Campo nome disciplina é obrigatório!")]
        public string Nome_Disciplina { get; set; }

        [Column("ano_letivo")]
        [Required(ErrorMessage = "Campo ano letivo é obrigatório!")]
        public int Ano_Letivo { get; set; }

        [Column("semestre")]
        [Required(ErrorMessage = "Campo semestre é obrigatório!")]
        public int Semestre { get; set; }

        [Column("data_matricula")]
        [Required(ErrorMessage = "Campo data matrícula é obrigatório!")]
        public DateTime Data_Matricula { get; set; } = DateTime.Now;

        [Column("status_matricula")]
        [Required(ErrorMessage = "Campo status matrícula é obrigatório!")]
        public bool Status_Matricula { get; set; } = true;

        [Column("data_cancelamento")]
        public DateTime? Data_Cancelamento { get; set; } = null;

        [Column("motivo_cancelamento")]
        public string Motivo_Cancelamento { get; set; } = null;

        [Column("data_conclusao")]
        public DateTime? Data_Conclusao { get; set; } = null;

        [Column("status_conclusao")]
        public bool Status_Conclusao { get; set; } = false;

        [Column("data_aprovacao")]
        public DateTime? Data_Aprovacao { get; set; } = null;

        [Column("status_aprovacao")]
        public bool Status_Aprovacao { get; set; } = false;

        [Column("data_reprovacao")]
        public DateTime? Data_Reprovacao { get; set; } = null;

        [Column("status_reprovacao")]
        public bool Status_Reprovacao { get; set; } = false;

        [Column("data_exclusao")]
        public DateTime? Data_Exclusao { get; set; } = null;
    }
}
