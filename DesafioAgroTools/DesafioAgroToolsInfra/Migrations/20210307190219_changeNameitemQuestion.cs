using Microsoft.EntityFrameworkCore.Migrations;

namespace DesafioAgroToolsInfra.Migrations
{
    public partial class changeNameitemQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Question_Questionary_QuestionId",
                table: "Question");

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                table: "Question",
                newName: "QuestionaryId");

            migrationBuilder.RenameIndex(
                name: "IX_Question_QuestionId",
                table: "Question",
                newName: "IX_Question_QuestionaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Questionary_QuestionaryId",
                table: "Question",
                column: "QuestionaryId",
                principalTable: "Questionary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Question_Questionary_QuestionaryId",
                table: "Question");

            migrationBuilder.RenameColumn(
                name: "QuestionaryId",
                table: "Question",
                newName: "QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Question_QuestionaryId",
                table: "Question",
                newName: "IX_Question_QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Questionary_QuestionId",
                table: "Question",
                column: "QuestionId",
                principalTable: "Questionary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
