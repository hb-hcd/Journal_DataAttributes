using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Journal_DataAttributes.Migrations
{
    public partial class changeJournalFk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Journal_User_JournalNumber",
                table: "Journal");

            migrationBuilder.AlterColumn<int>(
                name: "JournalNumber",
                table: "Journal",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

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

            migrationBuilder.DropIndex(
                name: "IX_Journal_UserNumber",
                table: "Journal");

            migrationBuilder.AlterColumn<int>(
                name: "JournalNumber",
                table: "Journal",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_Journal_User_JournalNumber",
                table: "Journal",
                column: "JournalNumber",
                principalTable: "User",
                principalColumn: "UserNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
