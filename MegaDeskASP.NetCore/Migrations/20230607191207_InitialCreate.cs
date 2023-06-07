using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MegaDeskASP.NetCore.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Desk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuoteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeskWidth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeskDepth = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NumberOfDrawers = table.Column<int>(type: "int", nullable: false),
                    SurfaceMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryChoice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuoteTotal = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desk", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Desk");
        }
    }
}
