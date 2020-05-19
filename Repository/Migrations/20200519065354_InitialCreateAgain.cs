using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class InitialCreateAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Logo = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    AboutUsItemId = table.Column<int>(nullable: true),
                    AboutUsItem_Title = table.Column<string>(nullable: true),
                    Subtitle = table.Column<string>(maxLength: 100, nullable: true),
                    AboutUsItem_Text = table.Column<string>(maxLength: 200, nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Agent_Image = table.Column<string>(nullable: true),
                    Area_Title = table.Column<string>(nullable: true),
                    Area_Subtitle = table.Column<string>(maxLength: 100, nullable: true),
                    Area_Phone = table.Column<string>(nullable: true),
                    Area_Image = table.Column<string>(nullable: true),
                    ImageText = table.Column<string>(nullable: true),
                    Video = table.Column<string>(nullable: true),
                    BestPlan_Title = table.Column<string>(nullable: true),
                    BestPlan_Subtitle = table.Column<string>(maxLength: 50, nullable: true),
                    PlanName = table.Column<string>(maxLength: 50, nullable: true),
                    PlanLogo = table.Column<string>(nullable: true),
                    PlanDescription = table.Column<string>(nullable: true),
                    BestPlan_Text = table.Column<string>(nullable: true),
                    SubDescription = table.Column<string>(nullable: true),
                    BestPlan_Image = table.Column<string>(nullable: true),
                    BestPlan_ImageText = table.Column<string>(nullable: true),
                    Blog_Title = table.Column<string>(nullable: true),
                    Blog_Image = table.Column<string>(nullable: true),
                    Blog_Text = table.Column<string>(nullable: true),
                    CaseStudy_Image = table.Column<string>(nullable: true),
                    CaseStudy_Title = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true),
                    OrderBy = table.Column<int>(nullable: true),
                    CaseStudyId = table.Column<int>(nullable: true),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    Category_Name = table.Column<string>(nullable: true),
                    Comment_Name = table.Column<string>(maxLength: 50, nullable: true),
                    Website = table.Column<string>(nullable: true),
                    Comment_Text = table.Column<string>(maxLength: 500, nullable: true),
                    Comment_Email = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    Contact_Name = table.Column<string>(nullable: true),
                    Contact_Email = table.Column<string>(nullable: true),
                    Contact_Phone = table.Column<string>(nullable: true),
                    ContactSubject = table.Column<string>(nullable: true),
                    Contact_Text = table.Column<string>(maxLength: 1000, nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Email1 = table.Column<string>(nullable: true),
                    Email2 = table.Column<string>(nullable: true),
                    Phone1 = table.Column<string>(nullable: true),
                    Phone2 = table.Column<string>(nullable: true),
                    OpeningHours = table.Column<string>(nullable: true),
                    Question = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true),
                    Post_Image = table.Column<string>(nullable: true),
                    Post_Text = table.Column<string>(nullable: true),
                    Post_Date = table.Column<DateTime>(nullable: true),
                    Service_Title = table.Column<string>(nullable: true),
                    Service_Subtitle = table.Column<string>(maxLength: 50, nullable: true),
                    Service_Logo = table.Column<string>(nullable: true),
                    Service_Name = table.Column<string>(nullable: true),
                    ServiceSpec_OrderBy = table.Column<int>(nullable: true),
                    ServiceId = table.Column<int>(nullable: true),
                    ServiceSpec_Key = table.Column<string>(maxLength: 50, nullable: true),
                    ServiceSpec_Value = table.Column<string>(maxLength: 50, nullable: true),
                    Setting_Logo = table.Column<string>(nullable: true),
                    Setting_Location = table.Column<string>(nullable: true),
                    Setting_Phone = table.Column<string>(nullable: true),
                    Setting_Email = table.Column<string>(nullable: true),
                    OfficeTime = table.Column<string>(nullable: true),
                    NeedAnAgentNumber = table.Column<string>(nullable: true),
                    SocialMediaId = table.Column<int>(nullable: true),
                    SliderItem_OrderBy = table.Column<int>(nullable: true),
                    SliderItem_Title = table.Column<string>(nullable: true),
                    Slogan = table.Column<string>(nullable: true),
                    SliderItem_Image = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    Tag_Name = table.Column<string>(nullable: true),
                    Testimonial_Title = table.Column<string>(nullable: true),
                    Testimonial_Subtitle = table.Column<string>(nullable: true),
                    Review = table.Column<string>(nullable: true),
                    Testimonial_Name = table.Column<string>(nullable: true),
                    Testimonial_Position = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_AboutUsItemId",
                        column: x => x.AboutUsItemId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_SocialMediaId",
                        column: x => x.SocialMediaId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_AboutUsItemId",
                table: "BaseEntities",
                column: "AboutUsItemId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_CategoryId",
                table: "BaseEntities",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_ServiceId",
                table: "BaseEntities",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_SocialMediaId",
                table: "BaseEntities",
                column: "SocialMediaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseEntities");
        }
    }
}
