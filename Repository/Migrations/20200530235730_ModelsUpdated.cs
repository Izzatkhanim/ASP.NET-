using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class ModelsUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "AboutUsItems");

            migrationBuilder.AddColumn<string>(
                name: "ActionText",
                table: "AboutUsItems",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AboutUsItems",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Subtext",
                table: "AboutUsItems",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionText",
                table: "AboutUsItems");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AboutUsItems");

            migrationBuilder.DropColumn(
                name: "Subtext",
                table: "AboutUsItems");

            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "AboutUsItems",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }
    }
}
