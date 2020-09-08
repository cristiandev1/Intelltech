using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Intelltech.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Directories",
                columns: table => new
                {
                    Id = table.Column<byte[]>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeometricShapes",
                columns: table => new
                {
                    Id = table.Column<byte[]>(nullable: false),
                    DirectoriesId = table.Column<byte[]>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Pixels = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeometricShapes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeometricShapes_Directories_DirectoriesId",
                        column: x => x.DirectoriesId,
                        principalTable: "Directories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GeometricShapes_DirectoriesId",
                table: "GeometricShapes",
                column: "DirectoriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeometricShapes");

            migrationBuilder.DropTable(
                name: "Directories");
        }
    }
}
