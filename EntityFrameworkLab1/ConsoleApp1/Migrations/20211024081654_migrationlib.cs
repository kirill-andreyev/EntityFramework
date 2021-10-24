using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp1.Migrations
{
    public partial class migrationlib : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autors",
                columns: table => new
                {
                    autorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    autorName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    originalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    death = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autors", x => x.autorId);
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
                name: "AutorPseudonyms",
                columns: table => new
                {
                    PseudonymId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutorId = table.Column<int>(type: "int", nullable: false),
                    PseudonymId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorPseudonyms", x => x.PseudonymId);
                    table.ForeignKey(
                        name: "FK_AutorPseudonyms_Autors_AutorId",
                        column: x => x.AutorId,
                        principalTable: "Autors",
                        principalColumn: "autorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutorPseudonyms_Pseudonyms_PseudonymId1",
                        column: x => x.PseudonymId1,
                        principalTable: "Pseudonyms",
                        principalColumn: "PseudonymId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutorWorks",
                columns: table => new
                {
                    AutorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkId = table.Column<int>(type: "int", nullable: false),
                    autorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorWorks", x => x.AutorId);
                    table.ForeignKey(
                        name: "FK_AutorWorks_Autors_autorId",
                        column: x => x.autorId,
                        principalTable: "Autors",
                        principalColumn: "autorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutorWorks_Works_WorkId",
                        column: x => x.WorkId,
                        principalTable: "Works",
                        principalColumn: "WorkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookstories",
                columns: table => new
                {
                    BoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkId = table.Column<int>(type: "int", nullable: false),
                    PubDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pages = table.Column<int>(type: "int", nullable: false),
                    Quality = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookstories", x => x.BoodId);
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
                        principalColumn: "WorkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutorPseudonyms_AutorId",
                table: "AutorPseudonyms",
                column: "AutorId");

            migrationBuilder.CreateIndex(
                name: "IX_AutorPseudonyms_PseudonymId1",
                table: "AutorPseudonyms",
                column: "PseudonymId1");

            migrationBuilder.CreateIndex(
                name: "a_name_idx",
                table: "Autors",
                column: "autorName");

            migrationBuilder.CreateIndex(
                name: "IX_AutorWorks_autorId",
                table: "AutorWorks",
                column: "autorId");

            migrationBuilder.CreateIndex(
                name: "IX_AutorWorks_WorkId",
                table: "AutorWorks",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutorPseudonyms");

            migrationBuilder.DropTable(
                name: "AutorWorks");

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
                name: "Autors");

            migrationBuilder.DropTable(
                name: "Works");
        }
    }
}
