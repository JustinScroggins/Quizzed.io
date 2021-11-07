using Microsoft.EntityFrameworkCore.Migrations;

namespace Quizzed.WebAPI.Migrations
{
    public partial class UpdateAnswerEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WrongAnswers");

            migrationBuilder.RenameColumn(
                name: "WrongAnswerId",
                table: "Answers",
                newName: "QuestionAnswerId");

            migrationBuilder.AddColumn<bool>(
                name: "IsAnswer",
                table: "Answers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAnswer",
                table: "Answers");

            migrationBuilder.RenameColumn(
                name: "QuestionAnswerId",
                table: "Answers",
                newName: "WrongAnswerId");

            migrationBuilder.CreateTable(
                name: "WrongAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerId = table.Column<int>(type: "int", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WrongAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WrongAnswers_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WrongAnswers_AnswerId",
                table: "WrongAnswers",
                column: "AnswerId");
        }
    }
}
