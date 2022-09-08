using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExameBE.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Subject = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(300)", nullable: false),
                    AdType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ads", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Id", "AdType", "CreationDate", "Description", "Subject" },
                values: new object[] { 1, 0, new DateTime(2022, 6, 22, 21, 55, 44, 561, DateTimeKind.Local).AddTicks(8480), "Com garagem. Acessos. Escolas. Metro.", "T2, Vila Nova de Gaia, 2014, 250000€" });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Id", "AdType", "CreationDate", "Description", "Subject" },
                values: new object[] { 2, 2, new DateTime(2022, 6, 22, 21, 55, 44, 579, DateTimeKind.Local).AddTicks(7840), "Salário: 1500-2000€ mensais. Entrada imediata. Missões: - Avaliação Imobiliária! - Mediação e Angariação Imobiliária! - Apoio á construção, obras, remodelações e Projetos Arquitetura!", "Zome, Porto, Consultor, Júnior, Full-time" });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Id", "AdType", "CreationDate", "Description", "Subject" },
                values: new object[] { 3, 1, new DateTime(2022, 6, 22, 21, 55, 44, 579, DateTimeKind.Local).AddTicks(8540), "Revisão feita sempre na marca. Como novo.", "Mazda CX-5, 2018, 40000 Km, 27000€" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ads");
        }
    }
}
