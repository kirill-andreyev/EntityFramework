using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkLab.Migrations
{
    public partial class migration : Migration
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
                name: "Pseudonyms",
                columns: table => new
                {
                    PseudonymId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PseudonymName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pseudonyms", x => x.PseudonymId);
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    WorkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.WorkId);
                });

            migrationBuilder.CreateTable(
                name: "AuthorPseudonyms",
                columns: table => new
                {
                    PseudonymId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PseudonymId1 = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorPseudonyms", x => x.PseudonymId);
                    table.ForeignKey(
                        name: "FK_AuthorPseudonyms_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorPseudonyms_Pseudonyms_PseudonymId1",
                        column: x => x.PseudonymId1,
                        principalTable: "Pseudonyms",
                        principalColumn: "PseudonymId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuthorWorks",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId1 = table.Column<int>(type: "int", nullable: false),
                    WorkId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorWorks", x => x.AuthorId);
                    table.ForeignKey(
                        name: "FK_AuthorWorks_Authors_AuthorId1",
                        column: x => x.AuthorId1,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorWorks_Works_WorkId",
                        column: x => x.WorkId,
                        principalTable: "Works",
                        principalColumn: "WorkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookstories",
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
                    table.PrimaryKey("PK_Bookstories", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Bookstories_Works_WorkId",
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

            migrationBuilder.CreateTable(
                name: "WorkWorks",
                columns: table => new
                {
                    WorkId = table.Column<int>(type: "int", nullable: false),
                    WorkId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkWorks", x => new { x.WorkId, x.WorkId1 });
                    table.ForeignKey(
                        name: "FK_WorkWorks_Works_WorkId",
                        column: x => x.WorkId,
                        principalTable: "Works",
                        principalColumn: "WorkId");
                    table.ForeignKey(
                        name: "FK_WorkWorks_Works_WorkId1",
                        column: x => x.WorkId1,
                        principalTable: "Works",
                        principalColumn: "WorkId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorPseudonyms_AuthorId",
                table: "AuthorPseudonyms",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorPseudonyms_PseudonymId1",
                table: "AuthorPseudonyms",
                column: "PseudonymId1");

            migrationBuilder.CreateIndex(
                name: "a_name_idx",
                table: "Authors",
                column: "AuthorName");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorWorks_AuthorId1",
                table: "AuthorWorks",
                column: "AuthorId1");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorWorks_WorkId",
                table: "AuthorWorks",
                column: "WorkId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookstories_WorkId",
                table: "Bookstories",
                column: "WorkId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalPublications_WorkId",
                table: "JournalPublications",
                column: "WorkId");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_WorkId",
                table: "Translations",
                column: "WorkId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkWorks_WorkId1",
                table: "WorkWorks",
                column: "WorkId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorPseudonyms");

            migrationBuilder.DropTable(
                name: "AuthorWorks");

            migrationBuilder.DropTable(
                name: "Bookstories");

            migrationBuilder.DropTable(
                name: "JournalPublications");

            migrationBuilder.DropTable(
                name: "Translations");

            migrationBuilder.DropTable(
                name: "WorkWorks");

            migrationBuilder.DropTable(
                name: "Pseudonyms");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Works");
        }
    }
}
