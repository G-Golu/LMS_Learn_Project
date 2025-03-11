using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS_Learn_Project.Migrations
{
    /// <inheritdoc />
    public partial class f1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Studentregistertbl",
                columns: table => new
                {
                    STUDENT_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    STUDENT_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STUDENT_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STUDENT_phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STUDENT_age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STUDENT_branch = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studentregistertbl", x => x.STUDENT_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Studentregistertbl");
        }
    }
}
