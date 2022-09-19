using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserDeployement.Migrations
{
    public partial class Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Pet_1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pet_1_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pet_2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pet_2_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pet_3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pet_3_Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
