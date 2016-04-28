using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace tiqe_web_csharp.Migrations
{
    public partial class Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_UserNewsletter_User_TiqeUserId", table: "TB_UserNewsletter");
            migrationBuilder.AddForeignKey(
                name: "FK_UserNewsletter_User_TiqeUserId",
                table: "TB_UserNewsletter",
                column: "TiqeUserId",
                principalTable: "TB_User",
                principalColumn: "TiqeUserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_UserNewsletter_User_TiqeUserId", table: "TB_UserNewsletter");
            migrationBuilder.AddForeignKey(
                name: "FK_UserNewsletter_User_TiqeUserId",
                table: "TB_UserNewsletter",
                column: "TiqeUserId",
                principalTable: "TB_User",
                principalColumn: "TiqeUserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
