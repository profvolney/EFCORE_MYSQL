using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCORE_MYSQL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate_01_04_25 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_curso",
                columns: table => new
                {
                    id_curso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome_curso = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    duracao = table.Column<int>(type: "int", nullable: false),
                    data_inicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    data_fim = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    status_curso = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CursoId_curso = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_curso", x => x.id_curso);
                    table.ForeignKey(
                        name: "FK_tb_curso_tb_curso_CursoId_curso",
                        column: x => x.CursoId_curso,
                        principalTable: "tb_curso",
                        principalColumn: "id_curso");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_aluno",
                columns: table => new
                {
                    Id_aluno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataNascimento = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Endereco = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cidade = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CEP = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Curso = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataMatricula = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Observacoes = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataAtualizacao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioCriador = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioAtualizador = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataExclusao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioExcluidor = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataRecuperacao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioRecuperador = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataExclusaoLogica = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioExcluidorLogico = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataRecuperacaoLogica = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioRecuperadorLogico = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCancelamento = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioCancelador = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataReativacao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioReativador = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataBloqueio = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioBloqueador = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataDesbloqueio = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioDesbloqueador = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataSuspensao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioSuspensor = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataDesuspensao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioDesuspensor = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataTransferencia = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CursoId_curso = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_aluno", x => x.Id_aluno);
                    table.ForeignKey(
                        name: "FK_tb_aluno_tb_curso_CursoId_curso",
                        column: x => x.CursoId_curso,
                        principalTable: "tb_curso",
                        principalColumn: "id_curso");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_disciplina",
                columns: table => new
                {
                    id_disciplina = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome_disciplina = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    carga_horaria = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    ano_letivo = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    semestre = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    status_disciplina = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    data_cadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    data_atualizacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    data_cancelamento = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    motivo_cancelamento = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    status_cadastro = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    status_cancelamento = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Curso = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Professor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CursoId_curso = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_disciplina", x => x.id_disciplina);
                    table.ForeignKey(
                        name: "FK_tb_disciplina_tb_curso_CursoId_curso",
                        column: x => x.CursoId_curso,
                        principalTable: "tb_curso",
                        principalColumn: "id_curso");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_matricula",
                columns: table => new
                {
                    id_matricula = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_aluno = table.Column<int>(type: "int", nullable: false),
                    id_disciplina = table.Column<int>(type: "int", nullable: false),
                    id_curso = table.Column<int>(type: "int", nullable: false),
                    nome_disciplina = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ano_letivo = table.Column<int>(type: "int", nullable: false),
                    semestre = table.Column<int>(type: "int", nullable: false),
                    data_matricula = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    status_matricula = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    data_cancelamento = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    motivo_cancelamento = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    data_conclusao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    status_conclusao = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    data_aprovacao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    status_aprovacao = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    data_reprovacao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    status_reprovacao = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    data_exclusao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CursoId_curso = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_matricula", x => x.id_matricula);
                    table.ForeignKey(
                        name: "FK_tb_matricula_tb_curso_CursoId_curso",
                        column: x => x.CursoId_curso,
                        principalTable: "tb_curso",
                        principalColumn: "id_curso");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_nota",
                columns: table => new
                {
                    id_nota = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_matricula = table.Column<int>(type: "int", nullable: false),
                    Id_disciplina = table.Column<int>(type: "int", nullable: false),
                    nota1 = table.Column<double>(type: "double", nullable: false),
                    nota2 = table.Column<double>(type: "double", nullable: false),
                    nota3 = table.Column<double>(type: "double", nullable: false),
                    nota4 = table.Column<double>(type: "double", nullable: false),
                    media = table.Column<double>(type: "double", nullable: false),
                    situacao = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    data_nota = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    id_aluno = table.Column<int>(type: "int", nullable: false),
                    data_aprovacao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    id_curso = table.Column<int>(type: "int", nullable: false),
                    CursoId_curso = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_nota", x => x.id_nota);
                    table.ForeignKey(
                        name: "FK_tb_nota_tb_curso_CursoId_curso",
                        column: x => x.CursoId_curso,
                        principalTable: "tb_curso",
                        principalColumn: "id_curso");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_professor",
                columns: table => new
                {
                    id_professor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cpf_professor = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_professor = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telefone = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    endereco = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    data_nascimento = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CursoId_curso = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_professor", x => x.id_professor);
                    table.ForeignKey(
                        name: "FK_tb_professor_tb_curso_CursoId_curso",
                        column: x => x.CursoId_curso,
                        principalTable: "tb_curso",
                        principalColumn: "id_curso");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_tb_aluno_CursoId_curso",
                table: "tb_aluno",
                column: "CursoId_curso");

            migrationBuilder.CreateIndex(
                name: "IX_tb_curso_CursoId_curso",
                table: "tb_curso",
                column: "CursoId_curso");

            migrationBuilder.CreateIndex(
                name: "IX_tb_disciplina_CursoId_curso",
                table: "tb_disciplina",
                column: "CursoId_curso");

            migrationBuilder.CreateIndex(
                name: "IX_tb_matricula_CursoId_curso",
                table: "tb_matricula",
                column: "CursoId_curso");

            migrationBuilder.CreateIndex(
                name: "IX_tb_nota_CursoId_curso",
                table: "tb_nota",
                column: "CursoId_curso");

            migrationBuilder.CreateIndex(
                name: "IX_tb_professor_CursoId_curso",
                table: "tb_professor",
                column: "CursoId_curso");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_aluno");

            migrationBuilder.DropTable(
                name: "tb_disciplina");

            migrationBuilder.DropTable(
                name: "tb_matricula");

            migrationBuilder.DropTable(
                name: "tb_nota");

            migrationBuilder.DropTable(
                name: "tb_professor");

            migrationBuilder.DropTable(
                name: "tb_curso");
        }
    }
}
