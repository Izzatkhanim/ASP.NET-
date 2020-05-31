using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class ModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlanDescription",
                table: "BestPlans");

            migrationBuilder.AddColumn<string>(
                name: "PlanDescription1",
                table: "BestPlans",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PlanDescription2",
                table: "BestPlans",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlanDescription3",
                table: "BestPlans",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlanDescription4",
                table: "BestPlans",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlanDescription1",
                table: "BestPlans");

            migrationBuilder.DropColumn(
                name: "PlanDescription2",
                table: "BestPlans");

            migrationBuilder.DropColumn(
                name: "PlanDescription3",
                table: "BestPlans");

            migrationBuilder.DropColumn(
                name: "PlanDescription4",
                table: "BestPlans");

            migrationBuilder.AddColumn<string>(
                name: "PlanDescription",
                table: "BestPlans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
