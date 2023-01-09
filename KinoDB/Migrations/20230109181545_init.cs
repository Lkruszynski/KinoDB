using Microsoft.EntityFrameworkCore.Migrations;

namespace KinoDB.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Films",
                table: "Films");

            migrationBuilder.RenameTable(
                name: "Films",
                newName: "Kinos");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Kinos",
                newName: "Ulica");

            migrationBuilder.AddColumn<string>(
                name: "Miejscowosc",
                table: "Kinos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kinos",
                table: "Kinos",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Kinos",
                table: "Kinos");

            migrationBuilder.DropColumn(
                name: "Miejscowosc",
                table: "Kinos");

            migrationBuilder.RenameTable(
                name: "Kinos",
                newName: "Films");

            migrationBuilder.RenameColumn(
                name: "Ulica",
                table: "Films",
                newName: "Year");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Films",
                table: "Films",
                column: "ID");
        }
    }
}
