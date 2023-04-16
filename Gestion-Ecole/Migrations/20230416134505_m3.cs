using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestion_Ecole.Migrations
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sarks_Students_idStudent",
                table: "sarks");

            migrationBuilder.DropForeignKey(
                name: "FK_sarks_subjects_idSubject",
                table: "sarks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sarks",
                table: "sarks");

            migrationBuilder.DropColumn(
                name: "roles",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "roles",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "roles",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "roles",
                table: "Administrators");

            migrationBuilder.RenameTable(
                name: "sarks",
                newName: "marks");

            migrationBuilder.RenameIndex(
                name: "IX_sarks_idSubject",
                table: "marks",
                newName: "IX_marks_idSubject");

            migrationBuilder.RenameIndex(
                name: "IX_sarks_idStudent",
                table: "marks",
                newName: "IX_marks_idStudent");

            migrationBuilder.AddPrimaryKey(
                name: "PK_marks",
                table: "marks",
                column: "Idmark");

            migrationBuilder.CreateTable(
                name: "accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    roles = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accounts", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_marks_Students_idStudent",
                table: "marks",
                column: "idStudent",
                principalTable: "Students",
                principalColumn: "idStudent",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_marks_subjects_idSubject",
                table: "marks",
                column: "idSubject",
                principalTable: "subjects",
                principalColumn: "idSubject",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_marks_Students_idStudent",
                table: "marks");

            migrationBuilder.DropForeignKey(
                name: "FK_marks_subjects_idSubject",
                table: "marks");

            migrationBuilder.DropTable(
                name: "accounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_marks",
                table: "marks");

            migrationBuilder.RenameTable(
                name: "marks",
                newName: "sarks");

            migrationBuilder.RenameIndex(
                name: "IX_marks_idSubject",
                table: "sarks",
                newName: "IX_sarks_idSubject");

            migrationBuilder.RenameIndex(
                name: "IX_marks_idStudent",
                table: "sarks",
                newName: "IX_sarks_idStudent");

            migrationBuilder.AddColumn<int>(
                name: "roles",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "roles",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "roles",
                table: "Directors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "roles",
                table: "Administrators",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_sarks",
                table: "sarks",
                column: "Idmark");

            migrationBuilder.AddForeignKey(
                name: "FK_sarks_Students_idStudent",
                table: "sarks",
                column: "idStudent",
                principalTable: "Students",
                principalColumn: "idStudent",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sarks_subjects_idSubject",
                table: "sarks",
                column: "idSubject",
                principalTable: "subjects",
                principalColumn: "idSubject",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
