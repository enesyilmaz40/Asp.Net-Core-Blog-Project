using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BlogComment",
                columns: table => new
                {
                    BlogsBlogID = table.Column<int>(type: "int", nullable: false),
                    CommentsCommentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogComment", x => new { x.BlogsBlogID, x.CommentsCommentID });
                    table.ForeignKey(
                        name: "FK_BlogComment_Blogs_BlogsBlogID",
                        column: x => x.BlogsBlogID,
                        principalTable: "Blogs",
                        principalColumn: "BlogID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogComment_Comments_CommentsCommentID",
                        column: x => x.CommentsCommentID,
                        principalTable: "Comments",
                        principalColumn: "CommentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogComment_CommentsCommentID",
                table: "BlogComment",
                column: "CommentsCommentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogComment");

            migrationBuilder.DropColumn(
                name: "BlogID",
                table: "Comments");
        }
    }
}
