using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class ModelsUpdatedAgainnn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ActionText",
                table: "BestPlans",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BulletPoint",
                table: "BestPlans",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Subtext",
                table: "AboutUsItems",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionText",
                table: "BestPlans");

            migrationBuilder.DropColumn(
                name: "BulletPoint",
                table: "BestPlans");

            migrationBuilder.AlterColumn<string>(
                name: "Subtext",
                table: "AboutUsItems",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000,
                oldNullable: true);
        }
    }
}
