using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPNETMVCCRUD.Migrations
{
    /// <inheritdoc />
    public partial class StudentRequiredField_AddPicture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Students");
        }
    }
}
