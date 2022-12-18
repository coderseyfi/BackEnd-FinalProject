using Microsoft.EntityFrameworkCore.Migrations;

namespace Cv.Domain.Migrations
{
    public partial class ResumeSkills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResumeSkill_ResumeCategories_ResumeCategoryId",
                table: "ResumeSkill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResumeSkill",
                table: "ResumeSkill");

            migrationBuilder.RenameTable(
                name: "ResumeSkill",
                newName: "ResumeSkills");

            migrationBuilder.RenameIndex(
                name: "IX_ResumeSkill_ResumeCategoryId",
                table: "ResumeSkills",
                newName: "IX_ResumeSkills_ResumeCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResumeSkills",
                table: "ResumeSkills",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeSkills_ResumeCategories_ResumeCategoryId",
                table: "ResumeSkills",
                column: "ResumeCategoryId",
                principalTable: "ResumeCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResumeSkills_ResumeCategories_ResumeCategoryId",
                table: "ResumeSkills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResumeSkills",
                table: "ResumeSkills");

            migrationBuilder.RenameTable(
                name: "ResumeSkills",
                newName: "ResumeSkill");

            migrationBuilder.RenameIndex(
                name: "IX_ResumeSkills_ResumeCategoryId",
                table: "ResumeSkill",
                newName: "IX_ResumeSkill_ResumeCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResumeSkill",
                table: "ResumeSkill",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeSkill_ResumeCategories_ResumeCategoryId",
                table: "ResumeSkill",
                column: "ResumeCategoryId",
                principalTable: "ResumeCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
