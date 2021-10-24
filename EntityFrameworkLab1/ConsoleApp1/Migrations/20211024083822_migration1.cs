using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp1.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutorWorks_Autors_autorId",
                table: "AutorWorks");

            migrationBuilder.DropForeignKey(
                name: "FK_AutorWorks_Works_WorkId",
                table: "AutorWorks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AutorWorks",
                table: "AutorWorks");

            migrationBuilder.RenameColumn(
                name: "AutorId",
                table: "AutorWorks",
                newName: "WorkWId");

            migrationBuilder.AlterColumn<int>(
                name: "autorId",
                table: "AutorWorks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "WorkId",
                table: "AutorWorks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "WorkWId",
                table: "AutorWorks",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AutorAId",
                table: "AutorWorks",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AutorWorks",
                table: "AutorWorks",
                column: "AutorAId");

            migrationBuilder.AddForeignKey(
                name: "FK_AutorWorks_Autors_autorId",
                table: "AutorWorks",
                column: "autorId",
                principalTable: "Autors",
                principalColumn: "autorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AutorWorks_Works_WorkId",
                table: "AutorWorks",
                column: "WorkId",
                principalTable: "Works",
                principalColumn: "WorkId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutorWorks_Autors_autorId",
                table: "AutorWorks");

            migrationBuilder.DropForeignKey(
                name: "FK_AutorWorks_Works_WorkId",
                table: "AutorWorks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AutorWorks",
                table: "AutorWorks");

            migrationBuilder.DropColumn(
                name: "AutorAId",
                table: "AutorWorks");

            migrationBuilder.RenameColumn(
                name: "WorkWId",
                table: "AutorWorks",
                newName: "AutorId");

            migrationBuilder.AlterColumn<int>(
                name: "autorId",
                table: "AutorWorks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WorkId",
                table: "AutorWorks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AutorId",
                table: "AutorWorks",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AutorWorks",
                table: "AutorWorks",
                column: "AutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_AutorWorks_Autors_autorId",
                table: "AutorWorks",
                column: "autorId",
                principalTable: "Autors",
                principalColumn: "autorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutorWorks_Works_WorkId",
                table: "AutorWorks",
                column: "WorkId",
                principalTable: "Works",
                principalColumn: "WorkId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
