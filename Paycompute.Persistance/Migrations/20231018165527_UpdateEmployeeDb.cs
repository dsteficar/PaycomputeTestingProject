using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Paycompute.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmployeeDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NationalInsuranceNuo",
                table: "Employees",
                newName: "NationalInsuranceNo");

            migrationBuilder.RenameColumn(
                name: "DateJoin",
                table: "Employees",
                newName: "DateJoined");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "NationalInsuranceNo",
                table: "Employees",
                newName: "NationalInsuranceNuo");

            migrationBuilder.RenameColumn(
                name: "DateJoined",
                table: "Employees",
                newName: "DateJoin");
        }
    }
}
