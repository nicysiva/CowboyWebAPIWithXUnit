using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CowboyWebAPI.Migrations
{
    public partial class InitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_CowboyDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Hair = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(12,9)", precision: 12, scale: 9, nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(12,9)", precision: 12, scale: 9, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_Date = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Updated_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_Date = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CowboyDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_CowboyDetails");
        }
    }
}
