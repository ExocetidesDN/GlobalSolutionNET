using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlobalSolutionNET.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Missions",
                columns: table => new
                {
                    MissionId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Date = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Missions", x => x.MissionId);
                });

            migrationBuilder.CreateTable(
                name: "Operators",
                columns: table => new
                {
                    OperatorId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    Certificantion = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operators", x => x.OperatorId);
                });

            migrationBuilder.CreateTable(
                name: "Drones",
                columns: table => new
                {
                    DroneId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    Model = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Manufacturer = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Active = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    LicenseID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    OperatorId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drones", x => x.DroneId);
                    table.ForeignKey(
                        name: "FK_Drones_Operators_OperatorId",
                        column: x => x.OperatorId,
                        principalTable: "Operators",
                        principalColumn: "OperatorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DroneMissions",
                columns: table => new
                {
                    DroneId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    MissionId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DroneMissions", x => new { x.DroneId, x.MissionId });
                    table.ForeignKey(
                        name: "FK_DroneMissions_Drones_DroneId",
                        column: x => x.DroneId,
                        principalTable: "Drones",
                        principalColumn: "DroneId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DroneMissions_Missions_MissionId",
                        column: x => x.MissionId,
                        principalTable: "Missions",
                        principalColumn: "MissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlightLicenses",
                columns: table => new
                {
                    LicenseId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    IssuedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    DroneId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightLicenses", x => x.LicenseId);
                    table.ForeignKey(
                        name: "FK_FlightLicenses_Drones_DroneId",
                        column: x => x.DroneId,
                        principalTable: "Drones",
                        principalColumn: "DroneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DroneMissions_MissionId",
                table: "DroneMissions",
                column: "MissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Drones_OperatorId",
                table: "Drones",
                column: "OperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightLicenses_DroneId",
                table: "FlightLicenses",
                column: "DroneId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DroneMissions");

            migrationBuilder.DropTable(
                name: "FlightLicenses");

            migrationBuilder.DropTable(
                name: "Missions");

            migrationBuilder.DropTable(
                name: "Drones");

            migrationBuilder.DropTable(
                name: "Operators");
        }
    }
}
