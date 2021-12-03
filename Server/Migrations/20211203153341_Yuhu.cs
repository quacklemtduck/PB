using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PB.Server.Migrations
{
    public partial class Yuhu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectStudent_Students_CollabStudentsId",
                table: "ProjectStudent");

            migrationBuilder.DropColumn(
                name: "ContactInfo",
                table: "Supervisors");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Supervisors");

            migrationBuilder.DropColumn(
                name: "getNotification",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "CollabStudentsId",
                table: "ProjectStudent",
                newName: "ChosenStudentsId");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Projects",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "numberOfStudents",
                table: "Projects",
                newName: "Notification");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "TEXT",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Students",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UniversityId",
                table: "Students",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_UniversityId",
                table: "Students",
                column: "UniversityId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectStudent_Students_ChosenStudentsId",
                table: "ProjectStudent",
                column: "ChosenStudentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Universities_UniversityId",
                table: "Students",
                column: "UniversityId",
                principalTable: "Universities",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectStudent_Students_ChosenStudentsId",
                table: "ProjectStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Universities_UniversityId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_UniversityId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "UniversityId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "ChosenStudentsId",
                table: "ProjectStudent",
                newName: "CollabStudentsId");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Projects",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Notification",
                table: "Projects",
                newName: "numberOfStudents");

            migrationBuilder.AddColumn<string>(
                name: "ContactInfo",
                table: "Supervisors",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Supervisors",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "getNotification",
                table: "Projects",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectStudent_Students_CollabStudentsId",
                table: "ProjectStudent",
                column: "CollabStudentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
