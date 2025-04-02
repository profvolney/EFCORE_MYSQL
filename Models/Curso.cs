using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using EFCORE_MYSQL.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCORE_MYSQL.Models
{
    [Table("tb_curso")]
    public class Curso
    {
        [Key]
        [Column("id_curso")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_curso { get; set; }

        [Column("nome_curso")]
        [Required(ErrorMessage = "Campo nome curso é obrigatório!")]
        [StringLength(100, ErrorMessage = "O nome do curso deve ter no máximo 100 caracteres.")]
        public string Nome_Curso { get; set; } = null;

        [Column("duracao")]
        [Required(ErrorMessage = "Campo duração é obrigatório!")]
        [Display(Name = "Duração")]
        [Range(1, 10, ErrorMessage = "A duração deve ser entre 1 e 10 anos.")]
        public int Duracao { get; set; } = 1;

        [Column("data_inicio")]
        [Required(ErrorMessage = "Campo data início é obrigatório!")]
        [Display(Name = "Data Início")]
        [DataType(DataType.Date)]
        public DateTime Data_Inicio { get; set; } = DateTime.Now;

        [Column("data_fim")]
        [Display(Name = "Data Fim")]
        [DataType(DataType.Date)]
        public DateTime? Data_Fim { get; set; } = null;

        [Column("status_curso")]
        [Required(ErrorMessage = "Campo status curso é obrigatório!")]
        [Display(Name = "Status Curso")]
        public bool Status_Curso { get; set; } = true;
        public List<Matricula> Matriculas { get; set; } = new List<Matricula>();
        public List<Disciplina> Disciplinas { get; set; } = new List<Disciplina>();
        public List<Nota> Notas { get; set; } = new List<Nota>();
        public List<Professor> Professores { get; set; } = new List<Professor>();
        public List<Aluno> Alunos { get; set; } = new List<Aluno>();
        public List<Curso> Cursos { get; set; } = new List<Curso>();
        private void InitializeCollections()
        {
            Matriculas = new List<Matricula>();            
            Disciplinas = new List<Disciplina>();
            Notas = new List<Nota>();            
            Professores = new List<Professor>();
            Alunos = new List<Aluno>();
            Cursos = new List<Curso>();
            Professores = new List<Professor>();
            Disciplinas = new List<Disciplina>();
        }

        private void CriarCurso()
        {
            // Lógica para criar um curso
            // Exemplo: Adicionar um novo curso à lista de cursos
            var novoCurso = new Curso
            {
                Nome_Curso = "Novo Curso",
                Duracao = 4,
                Data_Inicio = DateTime.Now,
                Status_Curso = true,
            };
            Cursos.Add(novoCurso);
        }

        private void ListarCursos()
        {
            // Lógica para listar os cursos
            // Exemplo: Exibir todos os cursos na lista de cursos
            foreach (var curso in Cursos)
            {
                Console.WriteLine(
                    $"Curso: {curso.Nome_Curso}, Duração: {curso.Duracao} anos, Status: {(curso.Status_Curso ? "Ativo" : "Inativo")}"
                );
            }
        }
    }
}
