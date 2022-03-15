using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Journal_DataAttributes.Migrations
{
    public partial class addForeignKeysAndClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CommentContent = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comment_User_CommentId",
                        column: x => x.CommentId,
                        principalTable: "User",
                        principalColumn: "UserNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Journal_UserNumber",
                table: "Journal",
                column: "UserNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Journal_User_UserNumber",
                table: "Journal",
                column: "UserNumber",
                principalTable: "User",
                principalColumn: "UserNumber",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Journal_User_UserNumber",
                table: "Journal");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Journal_UserNumber",
                table: "Journal");
        }
    }
}
