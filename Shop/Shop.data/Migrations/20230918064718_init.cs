﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop.data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Spaceship",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Passengers = table.Column<int>(type: "int", nullable: false),
                    EnginePower = table.Column<int>(type: "int", nullable: false),
                    Crew = table.Column<int>(type: "int", nullable: false),
                    Company = table.Column<int>(type: "int", nullable: false),
                    CargoWeight = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spaceship", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Spaceship");
        }
    }
}
