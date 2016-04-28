using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace tiqe_web_csharp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_User",
                columns: table => new
                {
                    TiqeUserId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:Serial", true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    FirstLogin = table.Column<bool>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    Language = table.Column<string>(nullable: true),
                    LastLogin = table.Column<DateTime>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    Pass = table.Column<string>(nullable: false),
                    Picture = table.Column<string>(nullable: true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    SendLogError = table.Column<bool>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    UseTerms = table.Column<bool>(nullable: false),
                    UserTiqeUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.TiqeUserId);
                    table.ForeignKey(
                        name: "FK_User_User_UserTiqeUserId",
                        column: x => x.UserTiqeUserId,
                        principalTable: "TB_User",
                        principalColumn: "TiqeUserId",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "TB_UserNewsletter",
                columns: table => new
                {
                    UserNewsletterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:Serial", true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    Receiver = table.Column<bool>(nullable: false),
                    ReceiverRegisterDate = table.Column<DateTime>(nullable: false),
                    TiqeUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNewsletter", x => x.UserNewsletterId);
                    table.ForeignKey(
                        name: "FK_UserNewsletter_User_TiqeUserId",
                        column: x => x.TiqeUserId,
                        principalTable: "TB_User",
                        principalColumn: "TiqeUserId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("TB_UserNewsletter");
            migrationBuilder.DropTable("TB_User");
        }
    }
}
