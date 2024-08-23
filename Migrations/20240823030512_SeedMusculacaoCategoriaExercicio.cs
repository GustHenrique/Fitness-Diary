using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitnessDiary.Migrations
{
    /// <inheritdoc />
    public partial class SeedMusculacaoCategoriaExercicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Duracao",
                table: "Treinos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "CategoriaExercicios",
                columns: new[] { "IdCategoria", "Nome" },
                values: new object[,]
                {
                    { 1, "Força" },
                    { 2, "Core e Abdominais" },
                    { 3, "Exercícios com Peso Corporal" },
                    { 4, "Exercícios de Resistência" },
                    { 5, "Exercícios para Grupos Musculares Específicos" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoriaExercicios",
                keyColumn: "IdCategoria",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoriaExercicios",
                keyColumn: "IdCategoria",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoriaExercicios",
                keyColumn: "IdCategoria",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoriaExercicios",
                keyColumn: "IdCategoria",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CategoriaExercicios",
                keyColumn: "IdCategoria",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Duracao",
                table: "Treinos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
