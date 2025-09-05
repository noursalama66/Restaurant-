using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project_cls.Migrations
{
    /// <inheritdoc />
    public partial class Addsalary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "salary",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "password",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "salary",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "username",
                table: "Employees");
        }
    }
}
