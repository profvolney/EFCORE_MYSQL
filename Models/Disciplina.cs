using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCORE_MYSQL.Models
{
    [Table("tb_disciplina")]
    public class Disciplina
    {
        [Key]
        [Column("id_disciplina")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_disciplina { get; set; }

        [Column("nome_disciplina")]
        [Required(ErrorMessage = "Campo nome disciplina é obrigatório!")]
        [StringLength(
            100,
            ErrorMessage = "Campo nome disciplina deve ter no máximo 100 caracteres!"
        )]
        [Display(Name = "Nome da Disciplina")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z0-9\s]+$",
            ErrorMessage = "Campo nome disciplina deve conter apenas letras e números!"
        )]
        [MinLength(3, ErrorMessage = "Campo nome disciplina deve ter no mínimo 3 caracteres!")]
        [MaxLength(100, ErrorMessage = "Campo nome disciplina deve ter no máximo 100 caracteres!")]
        [DisplayFormat(ConvertEmptyStringToNull = true)]
        public string Nome_Disciplina { get; set; }

        [Column("carga_horaria")]
        [Required(ErrorMessage = "Campo carga horária é obrigatório!")]
        [Display(Name = "Carga Horária")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[0-9]+$",
            ErrorMessage = "Campo carga horária deve conter apenas números!"
        )]
        [MinLength(1, ErrorMessage = "Campo carga horária deve ter no mínimo 1 caractere!")]
        [MaxLength(3, ErrorMessage = "Campo carga horária deve ter no máximo 3 caracteres!")]
        [DisplayFormat(ConvertEmptyStringToNull = true)]
        public int Carga_Horaria { get; set; }

        [Column("ano_letivo")]
        [Required(ErrorMessage = "Campo ano letivo é obrigatório!")]
        [Display(Name = "Ano Letivo")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[0-9]{4}$",
            ErrorMessage = "Campo ano letivo deve conter apenas números!"
        )]
        [MinLength(4, ErrorMessage = "Campo ano letivo deve ter no mínimo 4 caracteres!")]
        [MaxLength(4, ErrorMessage = "Campo ano letivo deve ter no máximo 4 caracteres!")]
        [DisplayFormat(ConvertEmptyStringToNull = true)]
        public int Ano_Letivo { get; set; }

        [Column("semestre")]
        [Required(ErrorMessage = "Campo semestre é obrigatório!")]
        [Display(Name = "Semestre")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[0-9]{1,2}$",
            ErrorMessage = "Campo semestre deve conter apenas números!"
        )]
        [MinLength(1, ErrorMessage = "Campo semestre deve ter no mínimo 1 caractere!")]
        [MaxLength(2, ErrorMessage = "Campo semestre deve ter no máximo 2 caracteres!")]
        [DisplayFormat(ConvertEmptyStringToNull = true)]
        public int Semestre { get; set; }

        [Column("status_disciplina")]
        [Required(ErrorMessage = "Campo status disciplina é obrigatório!")]
        [Display(Name = "Status Disciplina")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z0-9\s]+$",
            ErrorMessage = "Campo status disciplina deve conter apenas letras e números!"
        )]
        [MinLength(3, ErrorMessage = "Campo status disciplina deve ter no mínimo 3 caracteres!")]
        [MaxLength(20, ErrorMessage = "Campo status disciplina deve ter no máximo 20 caracteres!")]
        [DisplayFormat(ConvertEmptyStringToNull = true)]
        public string Status_Disciplina { get; set; } = "Ativo";

        [Column("data_cadastro")]
        [Display(Name = "Data Cadastro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data_Cadastro { get; set; } = DateTime.Now;

        [Column("data_atualizacao")]
        [Display(Name = "Data Atualização")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data_Atualizacao { get; set; } = DateTime.Now;

        [Column("data_cancelamento")]
        [Display(Name = "Data Cancelamento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Data_Cancelamento { get; set; } = null;

        [Column("motivo_cancelamento")]
        [Display(Name = "Motivo Cancelamento")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z0-9\s]+$",
            ErrorMessage = "Campo motivo cancelamento deve conter apenas letras e números!"
        )]
        [MinLength(3, ErrorMessage = "Campo motivo cancelamento deve ter no mínimo 3 caracteres!")]
        [MaxLength(
            100,
            ErrorMessage = "Campo motivo cancelamento deve ter no máximo 100 caracteres!"
        )]
        [DisplayFormat(ConvertEmptyStringToNull = true)]
        public string Motivo_Cancelamento { get; set; } = null;

        [Column("status_cadastro")]
        [Display(Name = "Status Cadastro")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z0-9\s]+$",
            ErrorMessage = "Campo status cadastro deve conter apenas letras e números!"
        )]
        [MinLength(3, ErrorMessage = "Campo status cadastro deve ter no mínimo 3 caracteres!")]
        [MaxLength(20, ErrorMessage = "Campo status cadastro deve ter no máximo 20 caracteres!")]
        [DisplayFormat(ConvertEmptyStringToNull = true)]
        public string Status_Cadastro { get; set; } = "Ativo";

        [Column("status_cancelamento")]
        [Display(Name = "Status Cancelamento")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z0-9\s]+$",
            ErrorMessage = "Campo status cancelamento deve conter apenas letras e números!"
        )]
        [MinLength(3, ErrorMessage = "Campo status cancelamento deve ter no mínimo 3 caracteres!")]
        [MaxLength(
            20,
            ErrorMessage = "Campo status cancelamento deve ter no máximo 20 caracteres!"
        )]
        [DisplayFormat(ConvertEmptyStringToNull = true)]
        public string Status_Cancelamento { get; set; } = "Inativo";

        [Display(Name = "Curso")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z0-9\s]+$",
            ErrorMessage = "Campo curso deve conter apenas letras e números!"
        )]
        public string Curso { get; set; }

        [Column("Professor")]
        [Display(Name = "Professor")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z0-9\s]+$",
            ErrorMessage = "Campo professor deve conter apenas letras e números!"
        )]
        public string Professor { get; set; } = null;
    }
}
