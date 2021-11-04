using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkLab.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OriginalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Death = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    WorkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.WorkId);
                    table.ForeignKey(
                        name: "FK_Works_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkId = table.Column<int>(type: "int", nullable: false),
                    PubDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pages = table.Column<int>(type: "int", nullable: false),
                    Quality = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Works_WorkId",
                        column: x => x.WorkId,
                        principalTable: "Works",
                        principalColumn: "WorkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Collection",
                columns: table => new
                {
                    WorkId = table.Column<int>(type: "int", nullable: false),
                    Work1Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collection", x => new { x.Work1Id, x.WorkId });
                    table.ForeignKey(
                        name: "FK_Collection_Works_WorkId",
                        column: x => x.WorkId,
                        principalTable: "Works",
                        principalColumn: "WorkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JournalPublications",
                columns: table => new
                {
                    JournalPublicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkId = table.Column<int>(type: "int", nullable: false),
                    JournalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Release = table.Column<int>(type: "int", nullable: false),
                    PubDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pages = table.Column<int>(type: "int", nullable: false),
                    Quality = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalPublications", x => x.JournalPublicationId);
                    table.ForeignKey(
                        name: "FK_JournalPublications_Works_WorkId",
                        column: x => x.WorkId,
                        principalTable: "Works",
                        principalColumn: "WorkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Translations",
                columns: table => new
                {
                    TranslationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkId = table.Column<int>(type: "int", nullable: false),
                    OriginalAutor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PubDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OriginalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pages = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translations", x => x.TranslationId);
                    table.ForeignKey(
                        name: "FK_Translations_Works_WorkId",
                        column: x => x.WorkId,
                        principalTable: "Works",
                        principalColumn: "WorkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "a_name_idx",
                table: "Authors",
                column: "AuthorName");

            migrationBuilder.CreateIndex(
                name: "IX_Books_WorkId",
                table: "Books",
                column: "WorkId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Collection_WorkId",
                table: "Collection",
                column: "WorkId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalPublications_WorkId",
                table: "JournalPublications",
                column: "WorkId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Translations_WorkId",
                table: "Translations",
                column: "WorkId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Works_AuthorId",
                table: "Works",
                column: "AuthorId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Collection");

            migrationBuilder.DropTable(
                name: "JournalPublications");

            migrationBuilder.DropTable(
                name: "Translations");

            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
