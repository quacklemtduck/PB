using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PB.Server.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 71, "Kandidat", "Media Technology and Games", "ITU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 94, "Kandidat", "Software Development and Technology", "ITU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 134, "Kandidat", "Digital Innovation & Management", "ITU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 150, "Bachelor", "Data Science", "ITU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 170, "Bachelor", "Digital Design and Interactive Technologies", "ITU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 233, "Kandidat", "Digital Design and Interactive Technologies", "ITU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 339, "Bachelor", "Global Business Informatics", "ITU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 346, "Kandidat", "Computer Science", "ITU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 356, "Bachelor", "Software Development", "ITU" });

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: "ITU",
                column: "Name",
                value: "IT-Universitet i København");

            migrationBuilder.InsertData(
                table: "Universities",
                columns: new[] { "Id", "Name", "ProjectId" },
                values: new object[] { "CBS", "Copenhagen Business School", null });

            migrationBuilder.InsertData(
                table: "Universities",
                columns: new[] { "Id", "Name", "ProjectId" },
                values: new object[] { "KU", "Københavns Universitet", null });

            migrationBuilder.InsertData(
                table: "Universities",
                columns: new[] { "Id", "Name", "ProjectId" },
                values: new object[] { "SDU", "Syddansk Universitet", null });

            migrationBuilder.InsertData(
                table: "Universities",
                columns: new[] { "Id", "Name", "ProjectId" },
                values: new object[] { "Uni abbrv", "Universitet", null });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "UniversityID" },
                values: new object[] { "Tysk", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 2, "Kandidat", "Skovbrugsvidenskab", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 3, "Kandidat", "Kemi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 4, "Bachelor", "Asienstudier (koreastudier)", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 5, "Kandidat", "Teologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 6, "Kandidat", "Interkulturelle markedsstudier", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 7, "Kandidat", "Folkesundhedsvidenskab", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 8, "Kandidat", "Biokemi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 9, "Kandidat", "Cand.it. - Webkommunikation", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 10, "Kandidat", "Biokemi og molekylær biologi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 11, "Bachelor", "Audiologopædi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 12, "Kandidat", "Business Administration and Bioentrepreneurship", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 13, "Kandidat", "Erhvervsøkonomi og Jura", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 14, "Bachelor", "Matematik-økonomi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 15, "Kandidat", "Organisational Innovation and Entrepreneurship - Strategic Design and Entrepreneurship (cand.soc.)", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 16, "Bachelor", "Tysk sprog og kultur", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 17, "Kandidat", "Medicinalkemi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 18, "Kandidat", "Engelsk (Kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 19, "Bachelor", "Mellemøstens sprog og samfund (ægyptologi)", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 20, "Bachelor", "Spansk sprog og kultur", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 21, "Bachelor", "Kemi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 22, "Bachelor", "Engelsk", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 23, "Kandidat", "Comparative Public Policy and Welfare Studies", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 24, "Kandidat", "Klinisk biomekanik", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 25, "Kandidat", "Statistik", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 26, "Bachelor", "Folkesundhedsvidenskab", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 27, "Kandidat", "Anvendt kulturanalyse", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 28, "Kandidat", "Visuel kultur", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 29, "Bachelor", "Civilingeniør i energiteknologi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 30, "Bachelor", "Business Administration & Service Management", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 31, "Bachelor", "Interkulturel pædagogik og dansk som andetsprog", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 32, "Kandidat", "Erhvervsøkonomi - Finance and Investments", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 33, "Kandidat", "Humanbiologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 34, "Bachelor", "Psykologi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 35, "Kandidat", "Medievidenskab (Kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 36, "Kandidat", "Politisk Kommunikation og Ledelse", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 37, "Bachelor", "Biokemi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 38, "Kandidat", "International Business and Politics", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 39, "Bachelor", "Teater- og performancestudier", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 40, "Kandidat", "Cand. it. - Web Communication Design", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 41, "Kandidat", "Nanoscience", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 42, "Kandidat", "Revisorkandidat", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 43, "Kandidat", "Fødevarevidenskab", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 44, "Kandidat", "Geografi og geoinformatik", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 45, "Kandidat", "Engelsk", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 46, "Bachelor", "Informationsvidenskab, it og interaktionsdesign", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 47, "Kandidat", "Medicin / Lægevidenskab (3-årig kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 48, "Kandidat", "Erhvervsøkonomi - Brand and Communications Management", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 49, "Kandidat", "Public Management and Social Development (cand.soc.)", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 50, "Kandidat", "Humanistisk-samfundsvidenskabelig idrætsvidenskab", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 51, "Bachelor", "Civilingeniør i Product Development and Innovation", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 52, "Kandidat", "Mellemøstens sprog og samfund", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 53, "Kandidat", "Data Science", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 54, "Bachelor", "International Business & Politics", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 55, "Bachelor", "Civilingeniør i Electronics", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 56, "Bachelor", "Klinisk biomekanik", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 57, "Bachelor", "Diplomingeniør i elektrisk energiteknologi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 58, "Bachelor", "Film- og medievidenskab", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 59, "Kandidat", "Psykologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 60, "Kandidat", "Idræt og Sundhed (kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 61, "Kandidat", "Business, Language and Culture - Business and Development Studies", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 62, "Bachelor", "Diplomingeniør i produktion", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 63, "Kandidat", "Designstudier", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 64, "Kandidat", "Veterinærmedicin", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 65, "Kandidat", "Amerikanske studier (Kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 66, "Kandidat", "Kommunikation og it", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 67, "Kandidat", "Erhvervsøkonomi - International Business", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 68, "Kandidat", "Økonomi (cand.oecon. med profil i finansiering)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 69, "Bachelor", "HA(mat.)", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 70, "Bachelor", "Fransk sprog og kultur", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 72, "Kandidat", "Matematik-økonomi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 73, "Bachelor", "Professionsbachelor i engelsk og digital markedskommunikation", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 74, "Bachelor", "Nanoscience", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 75, "Kandidat", "Lingvistik", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 76, "Kandidat", "Erhvervsøkonomi - Strategy, Organisation and Leadership", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 77, "Kandidat", "International Virksomhedskommunikation (Kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 78, "Kandidat", "Medicin", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 79, "Bachelor", "Asienstudier (japanstudier)", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 80, "Kandidat", "Erhvervsøkonomi og Matematik", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 81, "Kandidat", "Cand.merc. Market Anthropology", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 82, "Kandidat", "Cand.merc. Innovation and Business Development", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 83, "Kandidat", "Cand.merc. Marketing, Social Media, and Digitalization", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 84, "Kandidat", "Civilingeniør i Fysik og Teknologi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 85, "Bachelor", "HA(fil.)", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 86, "Kandidat", "Anvendt matematik", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 87, "Kandidat", "Latin", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 88, "Kandidat", "Business, Language and Culture - Diversity and Change Management", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 89, "Bachelor", "Market and Management Anthropology", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 90, "Kandidat", "Miljø- og naturressourceøkonomi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 91, "Kandidat", "Cultural Sociology", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 92, "Kandidat", "Civilingeniør i Engineering, Innovation and Business", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 93, "Kandidat", "Biologi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 95, "Bachelor", "Litteraturvidenskab", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 96, "Kandidat", "Statskundskab", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 97, "Kandidat", "Social datavidenskab", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 98, "Kandidat", "Business Administration and Data Science", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 99, "Bachelor", "Veterinærmedicin", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 100, "Bachelor", "Civilingeniør i bygningsteknik", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 101, "Bachelor", "Diplomingeniør i integreret design", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 102, "Kandidat", "Farmaci (kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 103, "Kandidat", "Erhvervsøkonomi - Applied Economics and Finance", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 104, "Bachelor", "Matematik-økonomi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 105, "Kandidat", "Italiensk sprog og kultur", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 106, "Bachelor", "HA i projektledelse", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 107, "Kandidat", "Civilingeniør i Energiteknologi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 108, "Bachelor", "HA(kom.)", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 109, "Bachelor", "Diplomingeniør i Global Management and Manufacturing", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 110, "Kandidat", "Tværkulturelle studier", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 111, "Kandidat", "Cand.merc. International Business and Management", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 112, "Kandidat", "Samfundsfag", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 113, "Kandidat", "Farmaceutisk videnskab", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 114, "Bachelor", "Medicin", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 115, "Kandidat", "Civilingeniør i Miljøteknologi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 116, "Kandidat", "Environmental and Resource Management", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 117, "Bachelor", "Retorik", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 118, "Bachelor", "Diplomingeniør i Maskinteknik", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 119, "Bachelor", "HA i markeds- og kulturanalyse", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 120, "Kandidat", "Sundhedsfaglig kandidatuddannelse (kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 121, "Kandidat", "Business Administration and Information Systems", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 122, "Bachelor", "Fysik", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 123, "Bachelor", "Historie", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 124, "Bachelor", "HA(it.)", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 125, "Bachelor", "Miljø- og fødevareøkonomi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 126, "Bachelor", "Religionsvidenskab", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 127, "Kandidat", "Litteraturvidenskab", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 128, "Bachelor", "Latin", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 129, "Kandidat", "Naturforvaltning", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 130, "Bachelor", "HA(jur.)", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 131, "Bachelor", "Bibliotekskundskab og videnskommunikation", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 132, "Kandidat", "Humanfysiologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 133, "Kandidat", "Religionsstudier (Kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 135, "Kandidat", "Jordemodervidenskab (kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 136, "Kandidat", "Landskabsarkitektur", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 137, "Bachelor", "Statskundskab", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 138, "Kandidat", "Litteraturvidenskab (Kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 139, "Kandidat", "Cand.merc. Sports and Event Management", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 140, "Bachelor", "Oldtidskundskab", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 141, "Kandidat", "Erhvervsøkonomi - Finansiering og Regnskab", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 142, "Kandidat", "Immunologi og inflammation", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 143, "Kandidat", "Fødevareinnovation og sundhed", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 144, "Bachelor", "Biologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 145, "Kandidat", "Fysik", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 146, "Bachelor", "Samfundsfag", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 147, "Kandidat", "Business Administration and Philosophy", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 148, "Kandidat", "Erhvervsøkonomi - Finance and Strategic Management", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 149, "Bachelor", "Diplomingeniør i robotteknologi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 151, "Kandidat", "Pædagogik", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 152, "Kandidat", "Odontologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 153, "Bachelor", "Machine learning og datavidenskab", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 154, "Bachelor", "Kunsthistorie", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 155, "Bachelor", "Civilingeniør i fysik og teknologi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 156, "Kandidat", "Geologi - geoscience", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 157, "Kandidat", "Datalogi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 158, "Bachelor", "Designkultur", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 159, "Kandidat", "Migrationsstudier", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 160, "Kandidat", "Erhvervsøkonomi - Accounting, Strategy and Control", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 161, "Kandidat", "Erhvervsøkonomi - Sales Management", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 162, "Kandidat", "Cand.merc. Entreprenørskab og ledelse", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 163, "Kandidat", "Interkulturelle markedsstudier", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 164, "Bachelor", "Business, Language & Culture", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 165, "Kandidat", "Sprogpsykologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 166, "Kandidat", "Human ernæring", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 167, "Kandidat", "Matematik", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 168, "Bachelor", "Landskabsarkitektur", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 169, "Bachelor", "Erhvervsøkonomi, HA", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 171, "Bachelor", "International Business", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 172, "Kandidat", "Cand.merc. Management Accounting", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 173, "Kandidat", "Civilingeniør i Product Development and Innovation", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 174, "Bachelor", "Idræt og sundhed", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 175, "Kandidat", "Mellemøststudier (Kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 176, "Kandidat", "Filosofi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 177, "Kandidat", "Civilingeniør i Mechatronics", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 178, "Kandidat", "Erhvervsøkonomi og Psykologi", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 179, "Bachelor", "Musikvidenskab", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 180, "Kandidat", "Dansk", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 181, "Bachelor", "Informationsstudier", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 182, "Kandidat", "Erhvervsøkonomi-erhvervssprog (negot) i international turisme og fritidsmanagement", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 183, "Kandidat", "Global udvikling", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 184, "Kandidat", "International Security and Law", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 185, "Bachelor", "Fødevarer og ernæring", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 186, "Bachelor", "Geologi - geoscience", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 187, "Bachelor", "Farmaci", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 188, "Kandidat", "Cand.merc. Styring og Ledelse", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 189, "Kandidat", "Kultur og formidling (Kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 190, "Kandidat", "Journalistik (cand.mag.)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 191, "Kandidat", "Historie", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 192, "Kandidat", "Psykologi (kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 193, "Bachelor", "Medicinalkemi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 194, "Grad", "Uddannelsesnavn", "Uni abbrv" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 195, "Kandidat", "Civilingeniør i Spiludvikling og læringsteknologi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 196, "Bachelor", "Historie", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 197, "Bachelor", "Religionsstudier", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 198, "Kandidat", "Jura", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 199, "Bachelor", "Folkesundhedsvidenskab", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 200, "Kandidat", "Husdyrvidenskab", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 201, "Bachelor", "Civilingeniør i Mechatronics", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 202, "Kandidat", "Civilingeniør i Software Engineering", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 203, "Kandidat", "Business Administration and Ebusiness", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 204, "Kandidat", "Civilingeniør i Sundheds- og Velfærdsteknologi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 205, "Kandidat", "Advanced Economics and Finance (cand.oecon.)", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 206, "Kandidat", "Erhvervsøkonomi - Management of Innovation and Business Development", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 207, "Bachelor", "Naturressourcer", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 208, "Kandidat", "Cand.merc.jur. (Erhvervsjura)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 209, "Kandidat", "Assyriologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 210, "Bachelor", "Indianske sprog og kulturer", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 211, "Kandidat", "Sociologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 212, "Bachelor", "Erhvervsøkonomi og jura, HA (jur.)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 213, "Kandidat", "European Master in Tourism Management", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 214, "Bachelor", "Diplomingeniør i Electronics", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 215, "Bachelor", "Erhvervsøkonomi-erhvervssprog (negot)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 216, "Kandidat", "Cand.merc. Global Marketing and Consumer Culture", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 217, "Kandidat", "Asienstudier", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 218, "Kandidat", "Økonomi (cand.oecon.)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 219, "Bachelor", "HA i europæisk business", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 220, "Kandidat", "Biomedicin", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 221, "Kandidat", "Nærorientalsk arkæologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 222, "Kandidat", "Antropologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 223, "Kandidat", "Erhvervsøkonomi - People and Business Development", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 224, "Kandidat", "Civilingeniør i Robotteknologi (Avanceret robotteknologi/Droner og autonome systemer)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 225, "Kandidat", "Journalistik (cand.public.)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 226, "Kandidat", "Molekylær biomedicin", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 227, "Bachelor", "Idræt og fysisk aktivitet", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 228, "Bachelor", "Journalistik", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 229, "Bachelor", "Amerikanske studier", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 230, "Bachelor", "Jura", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 231, "Kandidat", "Organisational Innovation and Entrepreneurship (cand.soc.)", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 232, "Bachelor", "Diplomingeniør i elektronik", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 234, "Bachelor", "Civilingeniør i kemi og bioteknologi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 235, "Bachelor", "Økonomi (oecon.)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 236, "Kandidat", "Civilingeniør i Operations Management", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 237, "Bachelor", "International virksomhedskommunikation - 2 fremmedsprog", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 238, "Kandidat", "Økonomi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 239, "Kandidat", "Ergoterapi (kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 240, "Kandidat", "Matematik", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 241, "Kandidat", "Kemi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 242, "Kandidat", "Cand.merc.aud. (Revisor)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 243, "Kandidat", "Portugisiske og brasilianske studier", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 244, "Kandidat", "Sundhedsfaglig kandidatuddannelse", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 245, "Bachelor", "International Business in Asia - Chinese", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 246, "Bachelor", "Sociologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 247, "Kandidat", "Global sundhed", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 248, "Kandidat", "Cand.merc.int., Sønderborg", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 249, "Kandidat", "Filosofi (Kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 250, "Kandidat", "Interreligiøse islamstudier", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 251, "Kandidat", "Forsikringsmatematik", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 252, "Bachelor", "Medievidenskab", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 253, "Kandidat", "Biomedicinsk informatik", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 254, "Bachelor", "Biomedicin", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 255, "Kandidat", "Farmaci", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 256, "Bachelor", "Antropologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 257, "Kandidat", "Human Resource Management", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 258, "Bachelor", "International virksomhedskommunikation - Tysk", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 259, "Kandidat", "Cand.merc. Business Controlling", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 260, "Bachelor", "Tandplejeruddannelsen", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 261, "Kandidat", "Business Administration and Innovation in Health Care", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 262, "Bachelor", "Molekylær biomedicin", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 263, "Kandidat", "Cand.merc. Brand Management and Marketing Communication", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 264, "Kandidat", "Medicinalkemi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 265, "Bachelor", "Geografi og geoinformatik", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 266, "Bachelor", "Civilingeniør i Innovation and Business", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 267, "Kandidat", "Statskundskab", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 268, "Bachelor", "Farmaci", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 269, "Bachelor", "Odontologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 270, "Bachelor", "Biokemi og molekylær biologi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 271, "Bachelor", "Sundhed og informatik", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 272, "Bachelor", "Engelsk", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 273, "Bachelor", "Business Administration & Digital Management", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 274, "Bachelor", "Datalogi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 275, "Bachelor", "Diplomingeniør i kemi- og bioteknologi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 276, "Kandidat", "Cand.merc. Human Resource Management", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 277, "Kandidat", "Religionsvidenskab", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 278, "Bachelor", "Mellemøstens sprog og samfund", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 279, "Bachelor", "Business Administration & Sociology", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 280, "Bachelor", "Asienstudier (kinastudier)", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 281, "Bachelor", "Forsikringsmatematik", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 282, "Kandidat", "Samfundsfag", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 283, "Kandidat", "Bioinformatik", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 284, "Kandidat", "Klinisk sygepleje (kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 285, "Bachelor", "Psykologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 286, "Bachelor", "Medicin", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 287, "Kandidat", "Europæisk etnologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 288, "Kandidat", "Grønlandske og arktiske studier", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 289, "Kandidat", "Klassisk arkæologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 290, "Kandidat", "Østeuropastudier", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 291, "Kandidat", "Forhistorisk arkæologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 292, "Kandidat", "Designledelse", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 293, "Bachelor", "Filosofi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 294, "Bachelor", "Lingvistik", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 295, "Bachelor", "Dansk", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 296, "Kandidat", "Afrikastudier", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 297, "Bachelor", "Statskundskab", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 298, "Kandidat", "Sikkerheds- og risikoledelse", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 299, "Kandidat", "Moderne kultur", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 300, "Kandidat", "Historie (Kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 301, "Bachelor", "HA almen", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 302, "Bachelor", "International Shipping & Trade", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 303, "Bachelor", "Klassisk græsk", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 304, "Kandidat", "Cand. it. - Product Design", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 305, "Kandidat", "Erhvervsøkonomi - Supply Chain Management", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 306, "Bachelor", "Teologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 307, "Kandidat", "Retorik", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 308, "Kandidat", "Ægyptologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 309, "Bachelor", "Biologi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 310, "Kandidat", "Fysik", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 311, "Kandidat", "Naturressourcer og udvikling", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 312, "Kandidat", "Lægemiddelvidenskab", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 313, "Bachelor", "Skov- og landskabsingeniørvirksomhed", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 314, "Bachelor", "Samfundsfag", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 315, "Kandidat", "Klimaforandringer", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 316, "Kandidat", "Audiologopædi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 317, "Bachelor", "Grønlandske og arktiske studier", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 318, "Bachelor", "Klassisk arkæologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 319, "Bachelor", "Forhistorisk arkæologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 320, "Bachelor", "Designkultur og økonomi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 321, "Bachelor", "Audiologi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 322, "Kandidat", "Matematik-økonomi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 323, "Bachelor", "Matematik og Anvendt matematik", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 324, "Bachelor", "Italiensk sprog og kultur", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 325, "Kandidat", "Agronomi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 326, "Bachelor", "Kommunikation og it", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 327, "Bachelor", "European Studies", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 328, "Kandidat", "Audiologi (Kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 329, "Bachelor", "Husdyrvidenskab", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 330, "Kandidat", "Datalogi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 331, "Kandidat", "Dansk (Kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 332, "Bachelor", "Civilingeniør i Software Engineering", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 333, "Kandidat", "Erhvervsøkonomi og Virksomhedskommunikation", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 334, "Kandidat", "Erhvervsøkonomi - Økonomisk Markedsføring", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 335, "Kandidat", "Jordbrugsøkonomi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 336, "Kandidat", "Folkesundhedsvidenskab (kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 337, "Bachelor", "Civilingeniør i robotteknologi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 338, "Bachelor", "HA(psyk.)", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 340, "Kandidat", "Miljøvidenskab", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 341, "Kandidat", "Biologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 342, "Kandidat", "Management of Creative Business Processes (cand.soc.)", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 343, "Bachelor", "Litteraturvidenskab", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 344, "Kandidat", "Musikvidenskab", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 345, "Kandidat", "Teater- og performancestudier", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 347, "Kandidat", "Pædagogik (Kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 348, "Bachelor", "Mellemøstens sprog og samfund (nærorientalsk ark.)", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 349, "Kandidat", "Sundhed og informatik", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 350, "Bachelor", "Sociologi og kulturanalyse", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 351, "Kandidat", "Europas religiøse rødder", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 352, "Kandidat", "It og kognition", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 353, "Kandidat", "Kunsthistorie", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 354, "Bachelor", "Audiologopædi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 355, "Kandidat", "Fysioterapi (kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 357, "Kandidat", "Klassiske studier: Oldtidskundskab (Kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 358, "Kandidat", "Erhvervsøkonomi-erhvervssprog (negot) - engelsk eller tysk (Kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 359, "Kandidat", "Informationsvidenskab og kulturformidling", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 360, "Kandidat", "Fødevarevidenskab/mejeriingeniør", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 361, "Bachelor", "Diplomingeniør i bygningsteknik", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 362, "Bachelor", "Mellemøstens sprog og samfund (assyriologi)", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 363, "Bachelor", "International virksomhedskommunikation - Engelsk", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 364, "Kandidat", "Stem-undervisning", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 365, "Kandidat", "Civilingeniør i Electronics", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 366, "Bachelor", "Kemi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 367, "Bachelor", "Datalogi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 368, "Bachelor", "Fysik", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 369, "Bachelor", "Økonomi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 370, "Kandidat", "Cand.merc. Forretnings- & Markedsudvikling", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 371, "Bachelor", "Diplomingeniør i softwareteknologi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 372, "Bachelor", "Pædagogik", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 373, "Kandidat", "Cand.soc. i jura", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 374, "Kandidat", "Cand.merc. Strategy and Organization", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 375, "Kandidat", "Film- og medievidenskab", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 376, "Bachelor", "Civilingeniør i Maskinteknik", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 377, "Kandidat", "Neuroscience", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 378, "Kandidat", "Erhvervsøkonomi - International Marketing and Management", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 379, "Kandidat", "Bioteknologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 380, "Kandidat", "Cand.merc. International Business and Marketing", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 381, "Bachelor", "Civilingeniør i spiludvikling og læringsteknologi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 382, "Kandidat", "Jura", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 383, "Kandidat", "Fransk sprog og kultur", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 384, "Bachelor", "Filosofi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 385, "Bachelor", "Matematik", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 386, "Bachelor", "Diplomingeniør i Mechatronics", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 387, "Kandidat", "Klinisk ernæring", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 388, "Bachelor", "Dansk", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 389, "Kandidat", "Integrerede fødevarestudier", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 390, "Bachelor", "International erhvervsøkonomi med fremmedsprog (BA int.)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 391, "Kandidat", "Civilingeniør i Konstruktionsteknik", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 392, "Kandidat", "Tysk (Kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 393, "Bachelor", "International Business in Asia - Japanese", "CBS" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 394, "Kandidat", "Civilingeniør i Kemi og bioteknologi (kandidat)", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 395, "Bachelor", "Datalogi-økonomi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 396, "Bachelor", "Civilingeniør i Sundheds- og velfærdsteknologi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 397, "Kandidat", "Audiologopædi", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 398, "Bachelor", "Bioteknologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 399, "Kandidat", "Kognition og kommunikation", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 400, "Bachelor", "Europæisk etnologi", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 401, "Kandidat", "Tysk sprog og kultur", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 402, "Bachelor", "Østeuropastudier", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 403, "Bachelor", "Jura", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 404, "Kandidat", "Cand.merc. Accounting and Finance", "SDU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 405, "Bachelor", "Moderne indien og sydasienstudier", "KU" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Grade", "Name", "UniversityID" },
                values: new object[] { 406, "Kandidat", "Spansk sprog og kultur", "KU" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: "CBS");

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: "KU");

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: "SDU");

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: "Uni abbrv");

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "UniversityID" },
                values: new object[] { "Software Udvikling", "ITU" });

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: "ITU",
                column: "Name",
                value: "IT University");
        }
    }
}
