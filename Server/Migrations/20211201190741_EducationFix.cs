using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PB.Server.Migrations
{
    public partial class EducationFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Universities",
                columns: new[] { "Id", "Name", "ProjectId" },
                values: new object[] { "ITU", "IT University", null });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 1, "Bachelor", "Software Udvikling", "ITU" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: "ITU");
        }
    }
}
