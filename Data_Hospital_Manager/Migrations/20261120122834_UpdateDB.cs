using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Hospital_Manager.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Hospitals_HospitalId",
                table: "Doctors");

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2026, 11, 20, 14, 28, 34, 492, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Hospitals_HospitalId",
                table: "Doctors",
                column: "HospitalId",
                principalTable: "Hospitals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Hospitals_HospitalId",
                table: "Doctors");

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2026, 11, 19, 20, 51, 37, 615, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Hospitals_HospitalId",
                table: "Doctors",
                column: "HospitalId",
                principalTable: "Hospitals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
