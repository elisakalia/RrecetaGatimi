using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RrecetaGatimi.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulli = table.Column<string>(type: "TEXT", nullable: false),
                    Pershkrimi = table.Column<string>(type: "TEXT", nullable: false),
                    Autori = table.Column<string>(type: "TEXT", nullable: false),
                    EmailiAutorit = table.Column<string>(type: "TEXT", nullable: false),
                    DataPublikimit = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receta", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receta");
        }
    }
}
