using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_InterfaceWeb.Migrations
{
    public partial class CreateDbMedecinUI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Role_NewAccount_AccountNewAccountID",
                table: "Account_Role");

            migrationBuilder.DropForeignKey(
                name: "FK_Account_Role_Role_RoleId",
                table: "Account_Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Account_Role",
                table: "Account_Role");

            migrationBuilder.DropIndex(
                name: "IX_Account_Role_RoleId",
                table: "Account_Role");

            migrationBuilder.DropColumn(
                name: "AccountRoleId",
                table: "Account_Role");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Role",
                newName: "NewAccountID");

            migrationBuilder.RenameColumn(
                name: "AccountNewAccountID",
                table: "Account_Role",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Account_Role_AccountNewAccountID",
                table: "Account_Role",
                newName: "IX_Account_Role_AccountId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Role",
                type: "varchar(250)",
                unicode: false,
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "NewAccount",
                type: "varchar(250)",
                unicode: false,
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "NewAccount",
                type: "varchar(250)",
                unicode: false,
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "NewAccount",
                type: "varchar(250)",
                unicode: false,
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Account_Role",
                table: "Account_Role",
                columns: new[] { "RoleId", "AccountId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Role_Account",
                table: "Account_Role",
                column: "AccountId",
                principalTable: "NewAccount",
                principalColumn: "NewAccountID");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Role_Role",
                table: "Account_Role",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "NewAccountID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Role_Account",
                table: "Account_Role");

            migrationBuilder.DropForeignKey(
                name: "FK_Account_Role_Role",
                table: "Account_Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Account_Role",
                table: "Account_Role");

            migrationBuilder.RenameColumn(
                name: "NewAccountID",
                table: "Role",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Account_Role",
                newName: "AccountNewAccountID");

            migrationBuilder.RenameIndex(
                name: "IX_Account_Role_AccountId",
                table: "Account_Role",
                newName: "IX_Account_Role_AccountNewAccountID");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Role",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldUnicode: false,
                oldMaxLength: 250)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "NewAccount",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldUnicode: false,
                oldMaxLength: 250)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "NewAccount",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldUnicode: false,
                oldMaxLength: 250)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "NewAccount",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldUnicode: false,
                oldMaxLength: 250)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "AccountRoleId",
                table: "Account_Role",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Account_Role",
                table: "Account_Role",
                column: "AccountRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_Role_RoleId",
                table: "Account_Role",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Role_NewAccount_AccountNewAccountID",
                table: "Account_Role",
                column: "AccountNewAccountID",
                principalTable: "NewAccount",
                principalColumn: "NewAccountID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Role_Role_RoleId",
                table: "Account_Role",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
