using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlobalSolutionNET.Migrations
{
    /// <inheritdoc />
    public partial class ChangeToGUID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "OperatorId",
                table: "Operators",
                type: "RAW(16)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)")
                .OldAnnotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "MissionId",
                table: "Missions",
                type: "RAW(16)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)")
                .OldAnnotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "DroneId",
                table: "FlightLicenses",
                type: "RAW(16)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.AlterColumn<Guid>(
                name: "LicenseId",
                table: "FlightLicenses",
                type: "RAW(16)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)")
                .OldAnnotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "OperatorId",
                table: "Drones",
                type: "RAW(16)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.AlterColumn<Guid>(
                name: "LicenseID",
                table: "Drones",
                type: "RAW(16)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.AlterColumn<Guid>(
                name: "DroneId",
                table: "Drones",
                type: "RAW(16)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)")
                .OldAnnotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "MissionId",
                table: "DroneMissions",
                type: "RAW(16)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.AlterColumn<Guid>(
                name: "DroneId",
                table: "DroneMissions",
                type: "RAW(16)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OperatorId",
                table: "Operators",
                type: "NUMBER(10)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "RAW(16)")
                .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1");

            migrationBuilder.AlterColumn<int>(
                name: "MissionId",
                table: "Missions",
                type: "NUMBER(10)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "RAW(16)")
                .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1");

            migrationBuilder.AlterColumn<int>(
                name: "DroneId",
                table: "FlightLicenses",
                type: "NUMBER(10)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "RAW(16)");

            migrationBuilder.AlterColumn<int>(
                name: "LicenseId",
                table: "FlightLicenses",
                type: "NUMBER(10)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "RAW(16)")
                .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1");

            migrationBuilder.AlterColumn<int>(
                name: "OperatorId",
                table: "Drones",
                type: "NUMBER(10)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "RAW(16)");

            migrationBuilder.AlterColumn<int>(
                name: "LicenseID",
                table: "Drones",
                type: "NUMBER(10)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "RAW(16)");

            migrationBuilder.AlterColumn<int>(
                name: "DroneId",
                table: "Drones",
                type: "NUMBER(10)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "RAW(16)")
                .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1");

            migrationBuilder.AlterColumn<int>(
                name: "MissionId",
                table: "DroneMissions",
                type: "NUMBER(10)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "RAW(16)");

            migrationBuilder.AlterColumn<int>(
                name: "DroneId",
                table: "DroneMissions",
                type: "NUMBER(10)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "RAW(16)");
        }
    }
}
