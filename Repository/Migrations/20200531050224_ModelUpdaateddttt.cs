using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class ModelUpdaateddttt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailId",
                table: "AboutUs");

            migrationBuilder.DropColumn(
                name: "EndpointId",
                table: "AboutUs");

            migrationBuilder.DropColumn(
                name: "PhoneId",
                table: "AboutUs");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "AboutUs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Endpoint",
                table: "AboutUs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "AboutUs",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "AboutUs");

            migrationBuilder.DropColumn(
                name: "Endpoint",
                table: "AboutUs");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "AboutUs");

            migrationBuilder.AddColumn<int>(
                name: "EmailId",
                table: "AboutUs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EndpointId",
                table: "AboutUs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PhoneId",
                table: "AboutUs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
