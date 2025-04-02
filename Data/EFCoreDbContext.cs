using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCORE_MYSQL.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCORE_MYSQL.Data
{
    public class EFCoreDbContext : DbContext
    {
        public EFCoreDbContext(DbContextOptions<EFCoreDbContext> options)
            : base(options) { }

        public DbSet<Aluno> _alunos { get; set; }
        public DbSet<Curso> _cursos { get; set; }
        public DbSet<Professor> _professores { get; set; }
        public DbSet<Disciplina> _disciplinas { get; set; }
        public DbSet<Matricula> _matriculas { get; set; }
        public DbSet<Nota> _notas { get; set; }
    }
}
