using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlobalSolutionNET.Migrations
{
    /// <inheritdoc />
    public partial class RemoveActiveFromDrone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Drones");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Drones",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
