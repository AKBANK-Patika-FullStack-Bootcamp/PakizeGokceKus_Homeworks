using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Week5_DemoBank_DataAccess.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ABankAccounts",
                columns: table => new
                {
                    BankAccountCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankAccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankAccountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankAccountLimit = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Balance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABankAccounts", x => x.BankAccountCode);
                });

            migrationBuilder.CreateTable(
                name: "AUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankAccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AUsers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ABankAccounts");

            migrationBuilder.DropTable(
                name: "AUsers");
        }
    }
}
