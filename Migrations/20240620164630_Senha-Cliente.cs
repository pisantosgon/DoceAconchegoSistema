using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Doceaconchego.Migrations
{
    /// <inheritdoc />
    public partial class SenhaCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SenhaCliente",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SenhaCliente",
                table: "Cliente");
        }
    }
}
