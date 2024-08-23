using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitnessDiary.Migrations
{
    /// <inheritdoc />
    public partial class SeedMusculacaoCategoriaExercicioSs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GruposMusculares",
                columns: new[] { "IdGrupoMuscular", "Nome" },
                values: new object[,]
                {
                    { 1, "Peitoral" },
                    { 2, "Dorsal" },
                    { 3, "Ombros" },
                    { 4, "Bíceps" },
                    { 5, "Tríceps" },
                    { 6, "Quadríceps" },
                    { 7, "Isquiotibiais" },
                    { 8, "Glúteos" },
                    { 9, "Panturrilhas" },
                    { 10, "Abdômen" },
                    { 11, "Lombar" },
                    { 12, "Músculos do Core" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GruposMusculares",
                keyColumn: "IdGrupoMuscular",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GruposMusculares",
                keyColumn: "IdGrupoMuscular",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GruposMusculares",
                keyColumn: "IdGrupoMuscular",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GruposMusculares",
                keyColumn: "IdGrupoMuscular",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GruposMusculares",
                keyColumn: "IdGrupoMuscular",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GruposMusculares",
                keyColumn: "IdGrupoMuscular",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GruposMusculares",
                keyColumn: "IdGrupoMuscular",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GruposMusculares",
                keyColumn: "IdGrupoMuscular",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GruposMusculares",
                keyColumn: "IdGrupoMuscular",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GruposMusculares",
                keyColumn: "IdGrupoMuscular",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GruposMusculares",
                keyColumn: "IdGrupoMuscular",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "GruposMusculares",
                keyColumn: "IdGrupoMuscular",
                keyValue: 12);
        }
    }
}
