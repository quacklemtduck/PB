using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PB.Server.Migrations
{
    public partial class ProjectForm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Expiration = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Data = table.Column<string>(type: "TEXT", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Keys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Version = table.Column<int>(type: "INTEGER", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Use = table.Column<string>(type: "TEXT", nullable: true),
                    Algorithm = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    IsX509Certificate = table.Column<bool>(type: "INTEGER", nullable: false),
                    DataProtected = table.Column<bool>(type: "INTEGER", nullable: false),
                    Data = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Expiration = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Data = table.Column<string>(type: "TEXT", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Supervisors",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supervisors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TagName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Universities",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    SupervisorID = table.Column<string>(type: "TEXT", nullable: false),
                    Notification = table.Column<bool>(type: "INTEGER", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Supervisors_SupervisorID",
                        column: x => x.SupervisorID,
                        principalTable: "Supervisors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    UniversityId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Universities_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "Universities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Grade = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    UniversityID = table.Column<string>(type: "TEXT", nullable: true),
                    ProjectId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educations_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Educations_Universities_UniversityID",
                        column: x => x.UniversityID,
                        principalTable: "Universities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    StudentID = table.Column<int>(type: "INTEGER", nullable: false),
                    ProjectID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applications_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applications_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectStudent",
                columns: table => new
                {
                    ChosenStudentsId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProjectsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectStudent", x => new { x.ChosenStudentsId, x.ProjectsId });
                    table.ForeignKey(
                        name: "FK_ProjectStudent_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectStudent_Students_ChosenStudentsId",
                        column: x => x.ChosenStudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Universities",
                columns: new[] { "Id", "Name" },
                values: new object[] { "CBS", "Copenhagen Business School" });

            migrationBuilder.InsertData(
                table: "Universities",
                columns: new[] { "Id", "Name" },
                values: new object[] { "ITU", "IT-Universitet i København" });

            migrationBuilder.InsertData(
                table: "Universities",
                columns: new[] { "Id", "Name" },
                values: new object[] { "KU", "Københavns Universitet" });

            migrationBuilder.InsertData(
                table: "Universities",
                columns: new[] { "Id", "Name" },
                values: new object[] { "SDU", "Syddansk Universitet" });

            migrationBuilder.InsertData(
                table: "Universities",
                columns: new[] { "Id", "Name" },
                values: new object[] { "Uni abbrv", "Universitet" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 1, "Bachelor", "Tysk", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 2, "Kandidat", "Skovbrugsvidenskab", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 3, "Kandidat", "Kemi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 4, "Bachelor", "Asienstudier (koreastudier)", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 5, "Kandidat", "Teologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 6, "Kandidat", "Interkulturelle markedsstudier", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 7, "Kandidat", "Folkesundhedsvidenskab", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 8, "Kandidat", "Biokemi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 9, "Kandidat", "Cand.it. - Webkommunikation", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 10, "Kandidat", "Biokemi og molekylær biologi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 11, "Bachelor", "Audiologopædi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 12, "Kandidat", "Business Administration and Bioentrepreneurship", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 13, "Kandidat", "Erhvervsøkonomi og Jura", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 14, "Bachelor", "Matematik-økonomi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 15, "Kandidat", "Organisational Innovation and Entrepreneurship - Strategic Design and Entrepreneurship (cand.soc.)", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 16, "Bachelor", "Tysk sprog og kultur", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 17, "Kandidat", "Medicinalkemi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 18, "Kandidat", "Engelsk (Kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 19, "Bachelor", "Mellemøstens sprog og samfund (ægyptologi)", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 20, "Bachelor", "Spansk sprog og kultur", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 21, "Bachelor", "Kemi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 22, "Bachelor", "Engelsk", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 23, "Kandidat", "Comparative Public Policy and Welfare Studies", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 24, "Kandidat", "Klinisk biomekanik", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 25, "Kandidat", "Statistik", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 26, "Bachelor", "Folkesundhedsvidenskab", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 27, "Kandidat", "Anvendt kulturanalyse", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 28, "Kandidat", "Visuel kultur", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 29, "Bachelor", "Civilingeniør i energiteknologi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 30, "Bachelor", "Business Administration & Service Management", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 31, "Bachelor", "Interkulturel pædagogik og dansk som andetsprog", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 32, "Kandidat", "Erhvervsøkonomi - Finance and Investments", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 33, "Kandidat", "Humanbiologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 34, "Bachelor", "Psykologi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 35, "Kandidat", "Medievidenskab (Kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 36, "Kandidat", "Politisk Kommunikation og Ledelse", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 37, "Bachelor", "Biokemi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 38, "Kandidat", "International Business and Politics", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 39, "Bachelor", "Teater- og performancestudier", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 40, "Kandidat", "Cand. it. - Web Communication Design", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 41, "Kandidat", "Nanoscience", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 42, "Kandidat", "Revisorkandidat", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 43, "Kandidat", "Fødevarevidenskab", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 44, "Kandidat", "Geografi og geoinformatik", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 45, "Kandidat", "Engelsk", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 46, "Bachelor", "Informationsvidenskab, it og interaktionsdesign", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 47, "Kandidat", "Medicin / Lægevidenskab (3-årig kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 48, "Kandidat", "Erhvervsøkonomi - Brand and Communications Management", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 49, "Kandidat", "Public Management and Social Development (cand.soc.)", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 50, "Kandidat", "Humanistisk-samfundsvidenskabelig idrætsvidenskab", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 51, "Bachelor", "Civilingeniør i Product Development and Innovation", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 52, "Kandidat", "Mellemøstens sprog og samfund", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 53, "Kandidat", "Data Science", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 54, "Bachelor", "International Business & Politics", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 55, "Bachelor", "Civilingeniør i Electronics", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 56, "Bachelor", "Klinisk biomekanik", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 57, "Bachelor", "Diplomingeniør i elektrisk energiteknologi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 58, "Bachelor", "Film- og medievidenskab", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 59, "Kandidat", "Psykologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 60, "Kandidat", "Idræt og Sundhed (kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 61, "Kandidat", "Business, Language and Culture - Business and Development Studies", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 62, "Bachelor", "Diplomingeniør i produktion", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 63, "Kandidat", "Designstudier", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 64, "Kandidat", "Veterinærmedicin", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 65, "Kandidat", "Amerikanske studier (Kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 66, "Kandidat", "Kommunikation og it", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 67, "Kandidat", "Erhvervsøkonomi - International Business", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 68, "Kandidat", "Økonomi (cand.oecon. med profil i finansiering)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 69, "Bachelor", "HA(mat.)", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 70, "Bachelor", "Fransk sprog og kultur", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 71, "Kandidat", "Media Technology and Games", null, "ITU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 72, "Kandidat", "Matematik-økonomi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 73, "Bachelor", "Professionsbachelor i engelsk og digital markedskommunikation", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 74, "Bachelor", "Nanoscience", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 75, "Kandidat", "Lingvistik", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 76, "Kandidat", "Erhvervsøkonomi - Strategy, Organisation and Leadership", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 77, "Kandidat", "International Virksomhedskommunikation (Kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 78, "Kandidat", "Medicin", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 79, "Bachelor", "Asienstudier (japanstudier)", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 80, "Kandidat", "Erhvervsøkonomi og Matematik", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 81, "Kandidat", "Cand.merc. Market Anthropology", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 82, "Kandidat", "Cand.merc. Innovation and Business Development", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 83, "Kandidat", "Cand.merc. Marketing, Social Media, and Digitalization", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 84, "Kandidat", "Civilingeniør i Fysik og Teknologi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 85, "Bachelor", "HA(fil.)", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 86, "Kandidat", "Anvendt matematik", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 87, "Kandidat", "Latin", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 88, "Kandidat", "Business, Language and Culture - Diversity and Change Management", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 89, "Bachelor", "Market and Management Anthropology", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 90, "Kandidat", "Miljø- og naturressourceøkonomi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 91, "Kandidat", "Cultural Sociology", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 92, "Kandidat", "Civilingeniør i Engineering, Innovation and Business", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 93, "Kandidat", "Biologi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 94, "Kandidat", "Software Development and Technology", null, "ITU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 95, "Bachelor", "Litteraturvidenskab", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 96, "Kandidat", "Statskundskab", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 97, "Kandidat", "Social datavidenskab", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 98, "Kandidat", "Business Administration and Data Science", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 99, "Bachelor", "Veterinærmedicin", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 100, "Bachelor", "Civilingeniør i bygningsteknik", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 101, "Bachelor", "Diplomingeniør i integreret design", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 102, "Kandidat", "Farmaci (kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 103, "Kandidat", "Erhvervsøkonomi - Applied Economics and Finance", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 104, "Bachelor", "Matematik-økonomi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 105, "Kandidat", "Italiensk sprog og kultur", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 106, "Bachelor", "HA i projektledelse", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 107, "Kandidat", "Civilingeniør i Energiteknologi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 108, "Bachelor", "HA(kom.)", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 109, "Bachelor", "Diplomingeniør i Global Management and Manufacturing", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 110, "Kandidat", "Tværkulturelle studier", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 111, "Kandidat", "Cand.merc. International Business and Management", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 112, "Kandidat", "Samfundsfag", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 113, "Kandidat", "Farmaceutisk videnskab", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 114, "Bachelor", "Medicin", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 115, "Kandidat", "Civilingeniør i Miljøteknologi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 116, "Kandidat", "Environmental and Resource Management", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 117, "Bachelor", "Retorik", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 118, "Bachelor", "Diplomingeniør i Maskinteknik", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 119, "Bachelor", "HA i markeds- og kulturanalyse", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 120, "Kandidat", "Sundhedsfaglig kandidatuddannelse (kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 121, "Kandidat", "Business Administration and Information Systems", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 122, "Bachelor", "Fysik", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 123, "Bachelor", "Historie", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 124, "Bachelor", "HA(it.)", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 125, "Bachelor", "Miljø- og fødevareøkonomi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 126, "Bachelor", "Religionsvidenskab", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 127, "Kandidat", "Litteraturvidenskab", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 128, "Bachelor", "Latin", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 129, "Kandidat", "Naturforvaltning", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 130, "Bachelor", "HA(jur.)", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 131, "Bachelor", "Bibliotekskundskab og videnskommunikation", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 132, "Kandidat", "Humanfysiologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 133, "Kandidat", "Religionsstudier (Kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 134, "Kandidat", "Digital Innovation & Management", null, "ITU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 135, "Kandidat", "Jordemodervidenskab (kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 136, "Kandidat", "Landskabsarkitektur", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 137, "Bachelor", "Statskundskab", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 138, "Kandidat", "Litteraturvidenskab (Kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 139, "Kandidat", "Cand.merc. Sports and Event Management", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 140, "Bachelor", "Oldtidskundskab", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 141, "Kandidat", "Erhvervsøkonomi - Finansiering og Regnskab", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 142, "Kandidat", "Immunologi og inflammation", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 143, "Kandidat", "Fødevareinnovation og sundhed", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 144, "Bachelor", "Biologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 145, "Kandidat", "Fysik", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 146, "Bachelor", "Samfundsfag", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 147, "Kandidat", "Business Administration and Philosophy", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 148, "Kandidat", "Erhvervsøkonomi - Finance and Strategic Management", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 149, "Bachelor", "Diplomingeniør i robotteknologi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 150, "Bachelor", "Data Science", null, "ITU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 151, "Kandidat", "Pædagogik", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 152, "Kandidat", "Odontologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 153, "Bachelor", "Machine learning og datavidenskab", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 154, "Bachelor", "Kunsthistorie", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 155, "Bachelor", "Civilingeniør i fysik og teknologi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 156, "Kandidat", "Geologi - geoscience", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 157, "Kandidat", "Datalogi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 158, "Bachelor", "Designkultur", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 159, "Kandidat", "Migrationsstudier", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 160, "Kandidat", "Erhvervsøkonomi - Accounting, Strategy and Control", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 161, "Kandidat", "Erhvervsøkonomi - Sales Management", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 162, "Kandidat", "Cand.merc. Entreprenørskab og ledelse", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 163, "Kandidat", "Interkulturelle markedsstudier", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 164, "Bachelor", "Business, Language & Culture", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 165, "Kandidat", "Sprogpsykologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 166, "Kandidat", "Human ernæring", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 167, "Kandidat", "Matematik", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 168, "Bachelor", "Landskabsarkitektur", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 169, "Bachelor", "Erhvervsøkonomi, HA", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 170, "Bachelor", "Digital Design and Interactive Technologies", null, "ITU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 171, "Bachelor", "International Business", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 172, "Kandidat", "Cand.merc. Management Accounting", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 173, "Kandidat", "Civilingeniør i Product Development and Innovation", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 174, "Bachelor", "Idræt og sundhed", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 175, "Kandidat", "Mellemøststudier (Kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 176, "Kandidat", "Filosofi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 177, "Kandidat", "Civilingeniør i Mechatronics", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 178, "Kandidat", "Erhvervsøkonomi og Psykologi", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 179, "Bachelor", "Musikvidenskab", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 180, "Kandidat", "Dansk", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 181, "Bachelor", "Informationsstudier", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 182, "Kandidat", "Erhvervsøkonomi-erhvervssprog (negot) i international turisme og fritidsmanagement", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 183, "Kandidat", "Global udvikling", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 184, "Kandidat", "International Security and Law", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 185, "Bachelor", "Fødevarer og ernæring", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 186, "Bachelor", "Geologi - geoscience", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 187, "Bachelor", "Farmaci", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 188, "Kandidat", "Cand.merc. Styring og Ledelse", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 189, "Kandidat", "Kultur og formidling (Kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 190, "Kandidat", "Journalistik (cand.mag.)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 191, "Kandidat", "Historie", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 192, "Kandidat", "Psykologi (kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 193, "Bachelor", "Medicinalkemi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 194, "Grad", "Uddannelsesnavn", null, "Uni abbrv" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 195, "Kandidat", "Civilingeniør i Spiludvikling og læringsteknologi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 196, "Bachelor", "Historie", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 197, "Bachelor", "Religionsstudier", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 198, "Kandidat", "Jura", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 199, "Bachelor", "Folkesundhedsvidenskab", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 200, "Kandidat", "Husdyrvidenskab", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 201, "Bachelor", "Civilingeniør i Mechatronics", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 202, "Kandidat", "Civilingeniør i Software Engineering", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 203, "Kandidat", "Business Administration and Ebusiness", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 204, "Kandidat", "Civilingeniør i Sundheds- og Velfærdsteknologi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 205, "Kandidat", "Advanced Economics and Finance (cand.oecon.)", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 206, "Kandidat", "Erhvervsøkonomi - Management of Innovation and Business Development", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 207, "Bachelor", "Naturressourcer", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 208, "Kandidat", "Cand.merc.jur. (Erhvervsjura)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 209, "Kandidat", "Assyriologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 210, "Bachelor", "Indianske sprog og kulturer", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 211, "Kandidat", "Sociologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 212, "Bachelor", "Erhvervsøkonomi og jura, HA (jur.)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 213, "Kandidat", "European Master in Tourism Management", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 214, "Bachelor", "Diplomingeniør i Electronics", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 215, "Bachelor", "Erhvervsøkonomi-erhvervssprog (negot)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 216, "Kandidat", "Cand.merc. Global Marketing and Consumer Culture", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 217, "Kandidat", "Asienstudier", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 218, "Kandidat", "Økonomi (cand.oecon.)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 219, "Bachelor", "HA i europæisk business", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 220, "Kandidat", "Biomedicin", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 221, "Kandidat", "Nærorientalsk arkæologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 222, "Kandidat", "Antropologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 223, "Kandidat", "Erhvervsøkonomi - People and Business Development", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 224, "Kandidat", "Civilingeniør i Robotteknologi (Avanceret robotteknologi/Droner og autonome systemer)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 225, "Kandidat", "Journalistik (cand.public.)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 226, "Kandidat", "Molekylær biomedicin", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 227, "Bachelor", "Idræt og fysisk aktivitet", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 228, "Bachelor", "Journalistik", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 229, "Bachelor", "Amerikanske studier", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 230, "Bachelor", "Jura", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 231, "Kandidat", "Organisational Innovation and Entrepreneurship (cand.soc.)", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 232, "Bachelor", "Diplomingeniør i elektronik", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 233, "Kandidat", "Digital Design and Interactive Technologies", null, "ITU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 234, "Bachelor", "Civilingeniør i kemi og bioteknologi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 235, "Bachelor", "Økonomi (oecon.)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 236, "Kandidat", "Civilingeniør i Operations Management", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 237, "Bachelor", "International virksomhedskommunikation - 2 fremmedsprog", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 238, "Kandidat", "Økonomi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 239, "Kandidat", "Ergoterapi (kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 240, "Kandidat", "Matematik", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 241, "Kandidat", "Kemi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 242, "Kandidat", "Cand.merc.aud. (Revisor)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 243, "Kandidat", "Portugisiske og brasilianske studier", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 244, "Kandidat", "Sundhedsfaglig kandidatuddannelse", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 245, "Bachelor", "International Business in Asia - Chinese", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 246, "Bachelor", "Sociologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 247, "Kandidat", "Global sundhed", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 248, "Kandidat", "Cand.merc.int., Sønderborg", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 249, "Kandidat", "Filosofi (Kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 250, "Kandidat", "Interreligiøse islamstudier", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 251, "Kandidat", "Forsikringsmatematik", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 252, "Bachelor", "Medievidenskab", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 253, "Kandidat", "Biomedicinsk informatik", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 254, "Bachelor", "Biomedicin", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 255, "Kandidat", "Farmaci", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 256, "Bachelor", "Antropologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 257, "Kandidat", "Human Resource Management", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 258, "Bachelor", "International virksomhedskommunikation - Tysk", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 259, "Kandidat", "Cand.merc. Business Controlling", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 260, "Bachelor", "Tandplejeruddannelsen", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 261, "Kandidat", "Business Administration and Innovation in Health Care", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 262, "Bachelor", "Molekylær biomedicin", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 263, "Kandidat", "Cand.merc. Brand Management and Marketing Communication", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 264, "Kandidat", "Medicinalkemi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 265, "Bachelor", "Geografi og geoinformatik", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 266, "Bachelor", "Civilingeniør i Innovation and Business", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 267, "Kandidat", "Statskundskab", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 268, "Bachelor", "Farmaci", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 269, "Bachelor", "Odontologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 270, "Bachelor", "Biokemi og molekylær biologi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 271, "Bachelor", "Sundhed og informatik", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 272, "Bachelor", "Engelsk", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 273, "Bachelor", "Business Administration & Digital Management", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 274, "Bachelor", "Datalogi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 275, "Bachelor", "Diplomingeniør i kemi- og bioteknologi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 276, "Kandidat", "Cand.merc. Human Resource Management", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 277, "Kandidat", "Religionsvidenskab", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 278, "Bachelor", "Mellemøstens sprog og samfund", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 279, "Bachelor", "Business Administration & Sociology", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 280, "Bachelor", "Asienstudier (kinastudier)", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 281, "Bachelor", "Forsikringsmatematik", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 282, "Kandidat", "Samfundsfag", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 283, "Kandidat", "Bioinformatik", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 284, "Kandidat", "Klinisk sygepleje (kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 285, "Bachelor", "Psykologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 286, "Bachelor", "Medicin", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 287, "Kandidat", "Europæisk etnologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 288, "Kandidat", "Grønlandske og arktiske studier", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 289, "Kandidat", "Klassisk arkæologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 290, "Kandidat", "Østeuropastudier", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 291, "Kandidat", "Forhistorisk arkæologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 292, "Kandidat", "Designledelse", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 293, "Bachelor", "Filosofi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 294, "Bachelor", "Lingvistik", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 295, "Bachelor", "Dansk", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 296, "Kandidat", "Afrikastudier", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 297, "Bachelor", "Statskundskab", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 298, "Kandidat", "Sikkerheds- og risikoledelse", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 299, "Kandidat", "Moderne kultur", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 300, "Kandidat", "Historie (Kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 301, "Bachelor", "HA almen", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 302, "Bachelor", "International Shipping & Trade", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 303, "Bachelor", "Klassisk græsk", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 304, "Kandidat", "Cand. it. - Product Design", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 305, "Kandidat", "Erhvervsøkonomi - Supply Chain Management", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 306, "Bachelor", "Teologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 307, "Kandidat", "Retorik", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 308, "Kandidat", "Ægyptologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 309, "Bachelor", "Biologi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 310, "Kandidat", "Fysik", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 311, "Kandidat", "Naturressourcer og udvikling", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 312, "Kandidat", "Lægemiddelvidenskab", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 313, "Bachelor", "Skov- og landskabsingeniørvirksomhed", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 314, "Bachelor", "Samfundsfag", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 315, "Kandidat", "Klimaforandringer", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 316, "Kandidat", "Audiologopædi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 317, "Bachelor", "Grønlandske og arktiske studier", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 318, "Bachelor", "Klassisk arkæologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 319, "Bachelor", "Forhistorisk arkæologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 320, "Bachelor", "Designkultur og økonomi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 321, "Bachelor", "Audiologi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 322, "Kandidat", "Matematik-økonomi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 323, "Bachelor", "Matematik og Anvendt matematik", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 324, "Bachelor", "Italiensk sprog og kultur", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 325, "Kandidat", "Agronomi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 326, "Bachelor", "Kommunikation og it", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 327, "Bachelor", "European Studies", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 328, "Kandidat", "Audiologi (Kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 329, "Bachelor", "Husdyrvidenskab", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 330, "Kandidat", "Datalogi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 331, "Kandidat", "Dansk (Kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 332, "Bachelor", "Civilingeniør i Software Engineering", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 333, "Kandidat", "Erhvervsøkonomi og Virksomhedskommunikation", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 334, "Kandidat", "Erhvervsøkonomi - Økonomisk Markedsføring", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 335, "Kandidat", "Jordbrugsøkonomi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 336, "Kandidat", "Folkesundhedsvidenskab (kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 337, "Bachelor", "Civilingeniør i robotteknologi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 338, "Bachelor", "HA(psyk.)", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 339, "Bachelor", "Global Business Informatics", null, "ITU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 340, "Kandidat", "Miljøvidenskab", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 341, "Kandidat", "Biologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 342, "Kandidat", "Management of Creative Business Processes (cand.soc.)", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 343, "Bachelor", "Litteraturvidenskab", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 344, "Kandidat", "Musikvidenskab", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 345, "Kandidat", "Teater- og performancestudier", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 346, "Kandidat", "Computer Science", null, "ITU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 347, "Kandidat", "Pædagogik (Kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 348, "Bachelor", "Mellemøstens sprog og samfund (nærorientalsk ark.)", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 349, "Kandidat", "Sundhed og informatik", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 350, "Bachelor", "Sociologi og kulturanalyse", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 351, "Kandidat", "Europas religiøse rødder", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 352, "Kandidat", "It og kognition", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 353, "Kandidat", "Kunsthistorie", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 354, "Bachelor", "Audiologopædi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 355, "Kandidat", "Fysioterapi (kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 356, "Bachelor", "Software Development", null, "ITU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 357, "Kandidat", "Klassiske studier: Oldtidskundskab (Kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 358, "Kandidat", "Erhvervsøkonomi-erhvervssprog (negot) - engelsk eller tysk (Kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 359, "Kandidat", "Informationsvidenskab og kulturformidling", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 360, "Kandidat", "Fødevarevidenskab/mejeriingeniør", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 361, "Bachelor", "Diplomingeniør i bygningsteknik", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 362, "Bachelor", "Mellemøstens sprog og samfund (assyriologi)", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 363, "Bachelor", "International virksomhedskommunikation - Engelsk", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 364, "Kandidat", "Stem-undervisning", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 365, "Kandidat", "Civilingeniør i Electronics", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 366, "Bachelor", "Kemi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 367, "Bachelor", "Datalogi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 368, "Bachelor", "Fysik", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 369, "Bachelor", "Økonomi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 370, "Kandidat", "Cand.merc. Forretnings- & Markedsudvikling", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 371, "Bachelor", "Diplomingeniør i softwareteknologi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 372, "Bachelor", "Pædagogik", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 373, "Kandidat", "Cand.soc. i jura", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 374, "Kandidat", "Cand.merc. Strategy and Organization", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 375, "Kandidat", "Film- og medievidenskab", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 376, "Bachelor", "Civilingeniør i Maskinteknik", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 377, "Kandidat", "Neuroscience", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 378, "Kandidat", "Erhvervsøkonomi - International Marketing and Management", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 379, "Kandidat", "Bioteknologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 380, "Kandidat", "Cand.merc. International Business and Marketing", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 381, "Bachelor", "Civilingeniør i spiludvikling og læringsteknologi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 382, "Kandidat", "Jura", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 383, "Kandidat", "Fransk sprog og kultur", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 384, "Bachelor", "Filosofi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 385, "Bachelor", "Matematik", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 386, "Bachelor", "Diplomingeniør i Mechatronics", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 387, "Kandidat", "Klinisk ernæring", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 388, "Bachelor", "Dansk", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 389, "Kandidat", "Integrerede fødevarestudier", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 390, "Bachelor", "International erhvervsøkonomi med fremmedsprog (BA int.)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 391, "Kandidat", "Civilingeniør i Konstruktionsteknik", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 392, "Kandidat", "Tysk (Kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 393, "Bachelor", "International Business in Asia - Japanese", null, "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 394, "Kandidat", "Civilingeniør i Kemi og bioteknologi (kandidat)", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 395, "Bachelor", "Datalogi-økonomi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 396, "Bachelor", "Civilingeniør i Sundheds- og velfærdsteknologi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 397, "Kandidat", "Audiologopædi", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 398, "Bachelor", "Bioteknologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 399, "Kandidat", "Kognition og kommunikation", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 400, "Bachelor", "Europæisk etnologi", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 401, "Kandidat", "Tysk sprog og kultur", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 402, "Bachelor", "Østeuropastudier", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 403, "Bachelor", "Jura", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 404, "Kandidat", "Cand.merc. Accounting and Finance", null, "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 405, "Bachelor", "Moderne indien og sydasienstudier", null, "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "ProjectId", "UniversityID" },
                values: new object[] { 406, "Kandidat", "Spansk sprog og kultur", null, "KU" });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ProjectID",
                table: "Applications",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_StudentID",
                table: "Applications",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_ProjectId",
                table: "Educations",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_UniversityID",
                table: "Educations",
                column: "UniversityID");

            migrationBuilder.CreateIndex(
                name: "IX_Keys_Use",
                table: "Keys",
                column: "Use");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants",
                column: "ConsumedTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_SupervisorID",
                table: "Projects",
                column: "SupervisorID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectStudent_ProjectsId",
                table: "ProjectStudent",
                column: "ProjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UniversityId",
                table: "Students",
                column: "UniversityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "ProjectStudent");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Supervisors");

            migrationBuilder.DropTable(
                name: "Universities");
        }
    }
}
