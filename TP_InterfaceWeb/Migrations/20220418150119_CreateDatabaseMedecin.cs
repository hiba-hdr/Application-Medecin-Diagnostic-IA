using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_InterfaceWeb.Migrations
{
    public partial class CreateDatabaseMedecin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Infomedecins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NewAccounts",
                table: "NewAccounts");

            migrationBuilder.RenameTable(
                name: "NewAccounts",
                newName: "NewAccount");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewAccount",
                table: "NewAccount",
                column: "NewAccountID");

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Account_Role",
                columns: table => new
                {
                    AccountRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    AccountNewAccountID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account_Role", x => x.AccountRoleId);
                    table.ForeignKey(
                        name: "FK_Account_Role_NewAccount_AccountNewAccountID",
                        column: x => x.AccountNewAccountID,
                        principalTable: "NewAccount",
                        principalColumn: "NewAccountID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Account_Role_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Account_Role_AccountNewAccountID",
                table: "Account_Role",
                column: "AccountNewAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Account_Role_RoleId",
                table: "Account_Role",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account_Role");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NewAccount",
                table: "NewAccount");

            migrationBuilder.RenameTable(
                name: "NewAccount",
                newName: "NewAccounts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewAccounts",
                table: "NewAccounts",
                column: "NewAccountID");

            migrationBuilder.CreateTable(
                name: "Infomedecins",
                columns: table => new
                {
                    InfomedecinId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DateDebutCarriere = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateNaissance = table.Column<int>(type: "int", nullable: false),
                    FemmeCheck = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HommeCheck = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Mail = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nom = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Prenom = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ville = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Infomedecins", x => x.InfomedecinId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
