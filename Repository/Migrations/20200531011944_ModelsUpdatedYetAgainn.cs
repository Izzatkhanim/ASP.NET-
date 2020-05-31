using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class ModelsUpdatedYetAgainn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BulletPoint",
                table: "BestPlans");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "BestPlans");

            migrationBuilder.DropColumn(
                name: "ImageText",
                table: "BestPlans");

            migrationBuilder.DropColumn(
                name: "PlanLogo",
                table: "BestPlans");

            migrationBuilder.DropColumn(
                name: "SubDescription",
                table: "BestPlans");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "BestPlans");

            migrationBuilder.AddColumn<string>(
                name: "Endpoint",
                table: "AboutUsItems",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Endpoint",
                table: "AboutUsItems");

            migrationBuilder.AddColumn<string>(
                name: "BulletPoint",
                table: "BestPlans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "BestPlans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageText",
                table: "BestPlans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PlanLogo",
                table: "BestPlans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubDescription",
                table: "BestPlans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "BestPlans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
