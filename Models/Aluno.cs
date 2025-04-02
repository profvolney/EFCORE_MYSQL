using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCORE_MYSQL.Models
{
    [Table("tb_aluno")]
    public class Aluno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_aluno { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Nome")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z\s]+$",
            ErrorMessage = "O nome só pode conter letras e espaços."
        )]
        public string Nome { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "O e-mail não é válido.")]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Telefone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(
            @"^\d{10,15}$",
            ErrorMessage = "O telefone deve conter entre 10 e 15 dígitos."
        )]
        public string Telefone { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Endereço")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z0-9\s,.-]+$",
            ErrorMessage = "O endereço só pode conter letras, números, espaços e os caracteres: , . -"
        )]
        public string Endereco { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Cidade")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z\s]+$",
            ErrorMessage = "A cidade só pode conter letras e espaços."
        )]
        public string Cidade { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Estado")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z\s]+$",
            ErrorMessage = "O estado só pode conter letras e espaços."
        )]
        public string Estado { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "CEP")]
        [DataType(DataType.PostalCode)]
        [RegularExpression(
            @"^\d{5}-\d{3}$",
            ErrorMessage = "O CEP deve estar no formato 00000-000."
        )]
        public string CEP { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Curso")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z\s]+$",
            ErrorMessage = "O curso só pode conter letras e espaços."
        )]
        public string Curso { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Data de Matrícula")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataMatricula { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Status")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^(Ativo|Inativo)$",
            ErrorMessage = "O status deve ser 'Ativo' ou 'Inativo'."
        )]
        public string Status { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Observações")]
        [DataType(DataType.MultilineText)]
        [RegularExpression(
            @"^[a-zA-Z0-9\s,.-]+$",
            ErrorMessage = "As observações só podem conter letras, números, espaços e os caracteres: , . -"
        )]
        public string Observacoes { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Data de Criação")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataCriacao { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Data de Atualização")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataAtualizacao { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Usuário Criador")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z0-9\s]+$",
            ErrorMessage = "O usuário criador só pode conter letras, números e espaços."
        )]
        public string UsuarioCriador { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Usuário Atualizador")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z0-9\s]+$",
            ErrorMessage = "O usuário atualizador só pode conter letras, números e espaços."
        )]
        public string UsuarioAtualizador { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Data de Exclusão")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DataExclusao { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Usuário Excluidor")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z0-9\s]+$",
            ErrorMessage = "O usuário excluidor só pode conter letras, números e espaços."
        )]
        public string UsuarioExcluidor { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Data de Recuperação")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DataRecuperacao { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Usuário Recuperador")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z0-9\s]+$",
            ErrorMessage = "O usuário recuperador só pode conter letras, números e espaços."
        )]
        public string UsuarioRecuperador { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Data de Exclusão Lógica")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DataExclusaoLogica { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Usuário Excluidor Lógico")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z0-9\s]+$",
            ErrorMessage = "O usuário excluidor lógico só pode conter letras, números e espaços."
        )]
        public string UsuarioExcluidorLogico { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Data de Recuperação Lógica")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DataRecuperacaoLogica { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Usuário Recuperador Lógico")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z0-9\s]+$",
            ErrorMessage = "O usuário recuperador lógico só pode conter letras, números e espaços."
        )]
        public string UsuarioRecuperadorLogico { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Data de Cancelamento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DataCancelamento { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Usuário Cancelador")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z0-9\s]+$",
            ErrorMessage = "O usuário cancelador só pode conter letras, números e espaços."
        )]
        public string UsuarioCancelador { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Data de Reativação")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DataReativacao { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Usuário Reativador")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z0-9\s]+$",
            ErrorMessage = "O usuário reativador só pode conter letras, números e espaços."
        )]
        public string UsuarioReativador { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Data de Bloqueio")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DataBloqueio { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Usuário Bloqueador")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z0-9\s]+$",
            ErrorMessage = "O usuário bloqueador só pode conter letras, números e espaços."
        )]
        public string UsuarioBloqueador { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Data de Desbloqueio")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DataDesbloqueio { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Usuário Desbloqueador")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z0-9\s]+$",
            ErrorMessage = "O usuário desbloqueador só pode conter letras, números e espaços."
        )]
        public string UsuarioDesbloqueador { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Data de Suspensão")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DataSuspensao { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Usuário Suspensor")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z0-9\s]+$",
            ErrorMessage = "O usuário suspensor só pode conter letras, números e espaços."
        )]
        public string UsuarioSuspensor { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Data de Desuspensão")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DataDesuspensao { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Usuário Desuspensor")]
        [DataType(DataType.Text)]
        [RegularExpression(
            @"^[a-zA-Z0-9\s]+$",
            ErrorMessage = "O usuário desuspensor só pode conter letras, números e espaços."
        )]
        public string UsuarioDesuspensor { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Data de Transferência")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DataTransferencia { get; set; }
    }
}
