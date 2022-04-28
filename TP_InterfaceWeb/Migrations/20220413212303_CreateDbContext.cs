using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_InterfaceWeb.Migrations
{
    public partial class CreateDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateNaissance",
                table: "NewAccounts");

            migrationBuilder.DropColumn(
                name: "Tab1",
                table: "Medecins");

            migrationBuilder.DropColumn(
                name: "Tab2",
                table: "Medecins");

            migrationBuilder.DropColumn(
                name: "Tab3",
                table: "Medecins");

            migrationBuilder.AlterColumn<string>(
                name: "Ville",
                table: "NewAccounts",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "HommeCheck",
                table: "NewAccounts",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "FemmeCheck",
                table: "NewAccounts",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "NewAccounts",
                keyColumn: "HommeCheck",
                keyValue: null,
                column: "HommeCheck",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "HommeCheck",
                table: "NewAccounts",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "NewAccounts",
                keyColumn: "FemmeCheck",
                keyValue: null,
                column: "FemmeCheck",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "FemmeCheck",
                table: "NewAccounts",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "DateNaissance",
                table: "NewAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Tab1",
                table: "Medecins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Tab2",
                table: "Medecins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Tab3",
                table: "Medecins",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
