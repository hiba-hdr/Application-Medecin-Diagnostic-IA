using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_InterfaceWeb.Migrations
{
    public partial class CreateDbMedecin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NewAccounts",
                keyColumn: "Ville",
                keyValue: null,
                column: "Ville",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Ville",
                table: "NewAccounts",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DateNaissance",
                table: "NewAccounts",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateNaissance",
                table: "NewAccounts");

            migrationBuilder.AlterColumn<string>(
                name: "Ville",
                table: "NewAccounts",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
