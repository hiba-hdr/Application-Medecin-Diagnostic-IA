using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_InterfaceWeb.Migrations
{
    public partial class CreateDbMedecins : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Diagnostics",
                table: "Diagnostics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AjoutPatients",
                table: "AjoutPatients");

            migrationBuilder.RenameTable(
                name: "Diagnostics",
                newName: "Diagnostic");

            migrationBuilder.RenameTable(
                name: "AjoutPatients",
                newName: "AjoutPatient");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diagnostic",
                table: "Diagnostic",
                column: "DiagnosticId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AjoutPatient",
                table: "AjoutPatient",
                column: "AjoutPatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Diagnostic",
                table: "Diagnostic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AjoutPatient",
                table: "AjoutPatient");

            migrationBuilder.RenameTable(
                name: "Diagnostic",
                newName: "Diagnostics");

            migrationBuilder.RenameTable(
                name: "AjoutPatient",
                newName: "AjoutPatients");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diagnostics",
                table: "Diagnostics",
                column: "DiagnosticId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AjoutPatients",
                table: "AjoutPatients",
                column: "AjoutPatientId");
        }
    }
}
