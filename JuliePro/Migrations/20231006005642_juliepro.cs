using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuliePro.Migrations
{
    public partial class juliepro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartWeight = table.Column<double>(type: "float", nullable: false),
                    TrainerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Objective",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    LostWeightKg = table.Column<double>(type: "float", nullable: false),
                    DistanceKm = table.Column<double>(type: "float", nullable: false),
                    AchievedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objective", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Objective_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    SpecialityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainers_Specialities_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "Specialities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "LastName", "StartWeight", "TrainerId" },
                values: new object[,]
                {
                    { 1, new DateTime(2009, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Felixun.trudeau@juliePro.ca", "FélixUn", "TrudeauUn", 100.0, 1 },
                    { 2, new DateTime(2008, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Felixdeux.trudeau@juliePro.ca", "FélixDeux", "TrudeauDeux", 200.0, 1 },
                    { 3, new DateTime(2007, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Felixtrois.trudeau@juliePro.ca", "FélixTrois", "TrudeauTrois", 300.0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Specialities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Perte de poids" },
                    { 2, "Course" },
                    { 3, "Halthérophilie" },
                    { 4, "Réhabilitation" }
                });

            migrationBuilder.InsertData(
                table: "Objective",
                columns: new[] { "Id", "AchievedDate", "CustomerId", "DistanceKm", "LostWeightKg", "Name" },
                values: new object[,]
                {
                    { 1, null, 1, 2.0, 2.0, "Objective1" },
                    { 2, new DateTime(2020, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3.0, 3.0, "Objective2" },
                    { 3, null, 2, 4.0, 4.0, "Objective3" },
                    { 4, null, 2, 5.0, 5.0, "Objective4" },
                    { 5, new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 6.0, 6.0, "Objective5" },
                    { 6, new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 7.0, 7.0, "Objective6" }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Photo", "SpecialityId" },
                values: new object[,]
                {
                    { 1, "Chrystal.lapierre@juliepro.ca", "Chrystal", "Lapierre", "Chrystal.png", 1 },
                    { 2, "Felix.trudeau@juliePro.ca", "Félix", "Trudeau", "Felix.png", 2 },
                    { 3, "Frank.StJohn@juliepro.ca", "François", "Saint-John", "Francois.png", 1 },
                    { 4, "JC.Bastien@juliepro.ca", "Jean-Claude", "Bastien", "JeanClaude.png", 4 },
                    { 5, "JinLee.godette@juliepro.ca", "Jin Lee", "Godette", "Jin Lee.png", 3 },
                    { 6, "Karine.Lachance@juliepro.ca", "Karine", "Lachance", "Karine.png", 2 },
                    { 7, "Ramone.Esteban@juliepro.ca", "Ramone", "Esteban", "Ramone.png", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Objective_CustomerId",
                table: "Objective",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainers_SpecialityId",
                table: "Trainers",
                column: "SpecialityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Objective");

            migrationBuilder.DropTable(
                name: "Trainers");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Specialities");
        }
    }
}
