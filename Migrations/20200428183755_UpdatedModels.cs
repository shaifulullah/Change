using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Chnage.Migrations
{
    public partial class UpdatedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AproverNote",
                table: "UserRoleECRs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AproverNote",
                table: "UserRoleECOs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AproverNote",
                table: "UserRoleECNs",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeviationDate",
                table: "ECRs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeviationQuantity",
                table: "ECRs",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DeviationSelected",
                table: "ECRs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeviationDate",
                table: "ECOs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeviationQuantity",
                table: "ECOs",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DeviationSelected",
                table: "ECOs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeviationDate",
                table: "ECNs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeviationQuantity",
                table: "ECNs",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DeviationSelected",
                table: "ECNs",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AproverNote",
                table: "UserRoleECRs");

            migrationBuilder.DropColumn(
                name: "AproverNote",
                table: "UserRoleECOs");

            migrationBuilder.DropColumn(
                name: "AproverNote",
                table: "UserRoleECNs");

            migrationBuilder.DropColumn(
                name: "DeviationDate",
                table: "ECRs");

            migrationBuilder.DropColumn(
                name: "DeviationQuantity",
                table: "ECRs");

            migrationBuilder.DropColumn(
                name: "DeviationSelected",
                table: "ECRs");

            migrationBuilder.DropColumn(
                name: "DeviationDate",
                table: "ECOs");

            migrationBuilder.DropColumn(
                name: "DeviationQuantity",
                table: "ECOs");

            migrationBuilder.DropColumn(
                name: "DeviationSelected",
                table: "ECOs");

            migrationBuilder.DropColumn(
                name: "DeviationDate",
                table: "ECNs");

            migrationBuilder.DropColumn(
                name: "DeviationQuantity",
                table: "ECNs");

            migrationBuilder.DropColumn(
                name: "DeviationSelected",
                table: "ECNs");
        }
    }
}
