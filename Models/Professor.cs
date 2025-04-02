using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCORE_MYSQL.Models
{
    [Table("tb_professor")]
    public class Professor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id_professor")]
        public int Id_professor { get; set; }

        [Column("nome")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres.")]
        [Display(Name = "Nome")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z\s]+$",
            ErrorMessage = "O campo Nome deve conter apenas letras e espaços."
        )]
        [MinLength(3, ErrorMessage = "O campo Nome deve ter no mínimo 3 caracteres.")]
        public string Nome { get; set; }

        [Column("cpf_professor")]
        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        [StringLength(11, ErrorMessage = "O campo CPF deve ter 11 dígitos.")]
        [Display(Name = "CPF")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "O campo CPF deve conter apenas números.")]
        [MinLength(11, ErrorMessage = "O campo CPF deve ter 11 dígitos.")]
        public string Cpf_professor { get; set; }

        [Column("email_professor")]
        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [StringLength(100, ErrorMessage = "O campo Email deve ter no máximo 100 caracteres.")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "O campo Email deve ser um endereço de email válido.")]
        [RegularExpression(
            @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
            ErrorMessage = "O campo Email deve ser um endereço de email válido."
        )]
        public string Email_professor { get; set; }

        [Column("telefone")]
        [Required(ErrorMessage = "O campo Telefone é obrigatório.")]
        [StringLength(15, ErrorMessage = "O campo Telefone deve ter no máximo 15 caracteres.")]
        [Display(Name = "Telefone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(
            @"^\d{10,15}$",
            ErrorMessage = "O campo Telefone deve conter apenas números."
        )]
        [MinLength(10, ErrorMessage = "O campo Telefone deve ter no mínimo 10 dígitos.")]
        public string Telefone { get; set; }

        [Column("endereco")]
        [Required(ErrorMessage = "O campo Endereço é obrigatório.")]
        [StringLength(200, ErrorMessage = "O campo Endereço deve ter no máximo 200 caracteres.")]
        [Display(Name = "Endereço")]
        [RegularExpression(
            @"^[a-zA-Z0-9\s.,-]+$",
            ErrorMessage = "O campo Endereço deve conter apenas letras, números, espaços e caracteres especiais."
        )]
        [MinLength(5, ErrorMessage = "O campo Endereço deve ter no mínimo 5 caracteres.")]
        [MaxLength(200, ErrorMessage = "O campo Endereço deve ter no máximo 200 caracteres.")]
        [DisplayFormat(ConvertEmptyStringToNull = true)]
        [DataType(DataType.MultilineText)]
        public string Endereco { get; set; }

        [Column("data_nascimento")]
        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório.")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [RegularExpression(
            @"^\d{4}-\d{2}-\d{2}$",
            ErrorMessage = "O campo Data de Nascimento deve estar no formato YYYY-MM-DD."
        )]
        [MinLength(
            10,
            ErrorMessage = "O campo Data de Nascimento deve ter no mínimo 10 caracteres."
        )]
        public string Data_nascimento { get; set; }
    }
}
