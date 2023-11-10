using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstWebMVC.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_Employee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Persons_fname",
                table: "Employee");

            migrationBuilder.AddColumn<string>(
                name: "ID",
                table: "Employee",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ID",
                table: "Employee");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Persons_fname",
                table: "Employee",
                column: "fname",
                principalTable: "Persons",
                principalColumn: "fname",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
