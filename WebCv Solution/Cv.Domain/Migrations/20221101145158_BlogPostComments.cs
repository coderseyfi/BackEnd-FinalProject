using Microsoft.EntityFrameworkCore.Migrations;

namespace Cv.Domain.Migrations
{
    public partial class BlogPostComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostComment_BlogPostComment_ParentId",
                table: "BlogPostComment");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostComment_BlogPosts_BlogPostId",
                table: "BlogPostComment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPostComment",
                table: "BlogPostComment");

            migrationBuilder.RenameTable(
                name: "BlogPostComment",
                newName: "BlogPostComments");

            migrationBuilder.RenameIndex(
                name: "IX_BlogPostComment_ParentId",
                table: "BlogPostComments",
                newName: "IX_BlogPostComments_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogPostComment_BlogPostId",
                table: "BlogPostComments",
                newName: "IX_BlogPostComments_BlogPostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogPostComments",
                table: "BlogPostComments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostComments_BlogPostComments_ParentId",
                table: "BlogPostComments",
                column: "ParentId",
                principalTable: "BlogPostComments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostComments_BlogPosts_BlogPostId",
                table: "BlogPostComments",
                column: "BlogPostId",
                principalTable: "BlogPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostComments_BlogPostComments_ParentId",
                table: "BlogPostComments");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostComments_BlogPosts_BlogPostId",
                table: "BlogPostComments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPostComments",
                table: "BlogPostComments");

            migrationBuilder.RenameTable(
                name: "BlogPostComments",
                newName: "BlogPostComment");

            migrationBuilder.RenameIndex(
                name: "IX_BlogPostComments_ParentId",
                table: "BlogPostComment",
                newName: "IX_BlogPostComment_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogPostComments_BlogPostId",
                table: "BlogPostComment",
                newName: "IX_BlogPostComment_BlogPostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogPostComment",
                table: "BlogPostComment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostComment_BlogPostComment_ParentId",
                table: "BlogPostComment",
                column: "ParentId",
                principalTable: "BlogPostComment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostComment_BlogPosts_BlogPostId",
                table: "BlogPostComment",
                column: "BlogPostId",
                principalTable: "BlogPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
