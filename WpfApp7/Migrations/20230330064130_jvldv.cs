﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfApp7.Migrations
{
    /// <inheritdoc />
    public partial class jvldv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acoounts",
                columns: table => new
                {
                    IdAccount = table.Column<Guid>(type: "uuid", nullable: false),
                    Login = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acoounts", x => x.IdAccount);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    IdBill = table.Column<Guid>(type: "uuid", nullable: false),
                    AccountIdAccount = table.Column<Guid>(type: "uuid", nullable: true),
                    Balance = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.IdBill);
                    table.ForeignKey(
                        name: "FK_Bills_Acoounts_AccountIdAccount",
                        column: x => x.AccountIdAccount,
                        principalTable: "Acoounts",
                        principalColumn: "IdAccount");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_AccountIdAccount",
                table: "Bills",
                column: "AccountIdAccount");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Acoounts");
        }
    }
}
