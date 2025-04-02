using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCORE_MYSQL.Models
{
    [Table("tb_escola")]
    public class Escola
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Escola { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório!")]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Nome da Escola")]
        [StringLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres!")]
        [MinLength(3, ErrorMessage = "O campo Nome deve ter no mínimo 3 caracteres!")]
        public string Nome { get; set; } = string.Empty;

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "O campo Endereço é obrigatório!")]
        [Display(Name = "Endereço")]
        [StringLength(100, ErrorMessage = "O campo Endereço deve ter no máximo 100 caracteres!")]
        [MinLength(3, ErrorMessage = "O campo Endereço deve ter no mínimo 3 caracteres!")]
        [DataType(DataType.MultilineText)]
        public string Endereco { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Cidade é obrigatório!")]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Cidade")]
        [StringLength(100, ErrorMessage = "O campo Cidade deve ter no máximo 100 caracteres!")]
        [MinLength(3, ErrorMessage = "O campo Cidade deve ter no mínimo 3 caracteres!")]
        public string Cidade { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Estado é obrigatório!")]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Estado")]
        [StringLength(100, ErrorMessage = "O campo Estado deve ter no máximo 100 caracteres!")]
        [MinLength(2, ErrorMessage = "O campo Estado deve ter no mínimo 2 caracteres!")]
        public string Estado { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo CEP é obrigatório!")]
        [Column(TypeName = "varchar(10)")]
        [Display(Name = "CEP")]
        [StringLength(10, ErrorMessage = "O campo CEP deve ter no máximo 10 caracteres!")]
        [MinLength(8, ErrorMessage = "O campo CEP deve ter no mínimo 8 caracteres!")]
        [DataType(DataType.PostalCode)]
        public string CEP { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Telefone é obrigatório!")]
        [Column(TypeName = "varchar(15)")]
        [Display(Name = "Telefone")]
        [StringLength(15, ErrorMessage = "O campo Telefone deve ter no máximo 15 caracteres!")]
        [MinLength(10, ErrorMessage = "O campo Telefone deve ter no mínimo 10 caracteres!")]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Email é obrigatório!")]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Email")]
        [StringLength(100, ErrorMessage = "O campo Email deve ter no máximo 100 caracteres!")]
        [MinLength(5, ErrorMessage = "O campo Email deve ter no mínimo 5 caracteres!")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "O campo Email deve ser um endereço de email válido!")]
        [RegularExpression(
            @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
            ErrorMessage = "O campo Email deve ser um endereço de email válido!"
        )]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo CNPJ é obrigatório!")]
        [Column(TypeName = "varchar(14)")]
        [Display(Name = "CNPJ")]
        [StringLength(14, ErrorMessage = "O campo CNPJ deve ter no máximo 14 caracteres!")]
        [MinLength(14, ErrorMessage = "O campo CNPJ deve ter no mínimo 14 caracteres!")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^\d{14}$", ErrorMessage = "O campo CNPJ deve conter apenas números!")]        
        public string CNPJ { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Responsável é obrigatório!")]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Responsável")]
        [StringLength(100, ErrorMessage = "O campo Responsável deve ter no máximo 100 caracteres!")]
        [MinLength(3, ErrorMessage = "O campo Responsável deve ter no mínimo 3 caracteres!")]
        [DataType(DataType.Text)]
        public string Responsavel { get; set; } = string.Empty;
    }
}
