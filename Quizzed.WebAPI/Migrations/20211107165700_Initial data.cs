using Microsoft.EntityFrameworkCore.Migrations;

namespace Quizzed.WebAPI.Migrations
{
    public partial class Initialdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Quizzes_QuizId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_QuizId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "QuizId",
                table: "Subjects");

            migrationBuilder.RenameColumn(
                name: "QuestionAnswerId",
                table: "Answers",
                newName: "AnswerGroupId");

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "Quizzes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_SubjectId",
                table: "Quizzes",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quizzes_Subjects_SubjectId",
                table: "Quizzes",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quizzes_Subjects_SubjectId",
                table: "Quizzes");

            migrationBuilder.DropIndex(
                name: "IX_Quizzes_SubjectId",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Quizzes");

            migrationBuilder.RenameColumn(
                name: "AnswerGroupId",
                table: "Answers",
                newName: "QuestionAnswerId");

            migrationBuilder.AddColumn<int>(
                name: "QuizId",
                table: "Subjects",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_QuizId",
                table: "Subjects",
                column: "QuizId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Quizzes_QuizId",
                table: "Subjects",
                column: "QuizId",
                principalTable: "Quizzes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
