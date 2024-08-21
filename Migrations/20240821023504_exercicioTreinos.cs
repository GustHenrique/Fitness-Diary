using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessDiary.Migrations
{
    /// <inheritdoc />
    public partial class exercicioTreinos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriaExercicio",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaExercicio", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "GrupoMuscular",
                columns: table => new
                {
                    IdGrupoMuscular = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoMuscular", x => x.IdGrupoMuscular);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimeiroNome = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NomeDoMeio = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DtaNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: true),
                    Altura = table.Column<double>(type: "float", nullable: true),
                    PathImagem = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NomeImagem = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Treino",
                columns: table => new
                {
                    IdTreino = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Duracao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CaloriasQueimadas = table.Column<double>(type: "float", nullable: false),
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treino", x => x.IdTreino);
                    table.ForeignKey(
                        name: "FK_Treino_CategoriaExercicio_IdCategoria",
                        column: x => x.IdCategoria,
                        principalTable: "CategoriaExercicio",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exercicio",
                columns: table => new
                {
                    IdExercicio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Repeticoes = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Series = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false),
                    IdTreino = table.Column<int>(type: "int", nullable: false),
                    IdGrupoMuscular = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercicio", x => x.IdExercicio);
                    table.ForeignKey(
                        name: "FK_Exercicio_GrupoMuscular_IdGrupoMuscular",
                        column: x => x.IdGrupoMuscular,
                        principalTable: "GrupoMuscular",
                        principalColumn: "IdGrupoMuscular",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exercicio_Treino_IdTreino",
                        column: x => x.IdTreino,
                        principalTable: "Treino",
                        principalColumn: "IdTreino",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercicio_IdGrupoMuscular",
                table: "Exercicio",
                column: "IdGrupoMuscular");

            migrationBuilder.CreateIndex(
                name: "IX_Exercicio_IdTreino",
                table: "Exercicio",
                column: "IdTreino");

            migrationBuilder.CreateIndex(
                name: "IX_Treino_IdCategoria",
                table: "Treino",
                column: "IdCategoria");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercicio");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "GrupoMuscular");

            migrationBuilder.DropTable(
                name: "Treino");

            migrationBuilder.DropTable(
                name: "CategoriaExercicio");
        }
    }
}
