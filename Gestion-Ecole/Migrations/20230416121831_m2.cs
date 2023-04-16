using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestion_Ecole.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdSubject",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idGroupe",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isAccepted",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "groupes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groupes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "subjects",
                columns: table => new
                {
                    idSubject = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subjectName = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjects", x => x.idSubject);
                });

            migrationBuilder.CreateTable(
                name: "teacher_Groups",
                columns: table => new
                {
                    IdTeacher = table.Column<int>(type: "int", nullable: false),
                    IdGroupe = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teacher_Groups", x => new { x.IdTeacher, x.IdGroupe });
                    table.ForeignKey(
                        name: "FK_teacher_Groups_Teachers_IdTeacher",
                        column: x => x.IdTeacher,
                        principalTable: "Teachers",
                        principalColumn: "idTeacher",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_teacher_Groups_groupes_IdGroupe",
                        column: x => x.IdGroupe,
                        principalTable: "groupes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sarks",
                columns: table => new
                {
                    Idmark = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mark = table.Column<double>(type: "float", nullable: false),
                    idSubject = table.Column<int>(type: "int", nullable: false),
                    idStudent = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sarks", x => x.Idmark);
                    table.ForeignKey(
                        name: "FK_sarks_Students_idStudent",
                        column: x => x.idStudent,
                        principalTable: "Students",
                        principalColumn: "idStudent",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sarks_subjects_idSubject",
                        column: x => x.idSubject,
                        principalTable: "subjects",
                        principalColumn: "idSubject",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_IdSubject",
                table: "Teachers",
                column: "IdSubject");

            migrationBuilder.CreateIndex(
                name: "IX_Students_idGroupe",
                table: "Students",
                column: "idGroupe");

            migrationBuilder.CreateIndex(
                name: "IX_sarks_idStudent",
                table: "sarks",
                column: "idStudent");

            migrationBuilder.CreateIndex(
                name: "IX_sarks_idSubject",
                table: "sarks",
                column: "idSubject");

            migrationBuilder.CreateIndex(
                name: "IX_teacher_Groups_IdGroupe",
                table: "teacher_Groups",
                column: "IdGroupe");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_groupes_idGroupe",
                table: "Students",
                column: "idGroupe",
                principalTable: "groupes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_subjects_IdSubject",
                table: "Teachers",
                column: "IdSubject",
                principalTable: "subjects",
                principalColumn: "idSubject",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_groupes_idGroupe",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_subjects_IdSubject",
                table: "Teachers");

            migrationBuilder.DropTable(
                name: "sarks");

            migrationBuilder.DropTable(
                name: "teacher_Groups");

            migrationBuilder.DropTable(
                name: "subjects");

            migrationBuilder.DropTable(
                name: "groupes");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_IdSubject",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Students_idGroupe",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IdSubject",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "idGroupe",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "isAccepted",
                table: "Students");
        }
    }
}
