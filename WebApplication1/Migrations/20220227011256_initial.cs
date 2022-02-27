using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "reviews",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    reviewId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reviewFullText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reviewText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numLikes = table.Column<int>(type: "int", nullable: false),
                    numComments = table.Column<int>(type: "int", nullable: false),
                    numShares = table.Column<int>(type: "int", nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false),
                    reviewCreatedOn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reviewCreatedOnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    reviewCreatedOnTime = table.Column<int>(type: "int", nullable: false),
                    reviewerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reviewerUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reviewerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reviewerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sourceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isVerified = table.Column<bool>(type: "bit", nullable: false),
                    source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sourceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sourceId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    href = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    logoHref = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reviews", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "reviews");
        }
    }
}
