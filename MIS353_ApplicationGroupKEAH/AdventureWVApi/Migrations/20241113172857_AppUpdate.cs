using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdventureWVApi.Migrations
{
    /// <inheritdoc />
    public partial class AppUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LANDMARKS",
                columns: table => new
                {
                    LID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LANDMARK__C65557218EC6787B", x => x.LID);
                });

            migrationBuilder.CreateTable(
                name: "USERDATA",
                columns: table => new
                {
                    UID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UFName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ULName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UEmail = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UPhone = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__USERDATA__C5B19602591CB00C", x => x.UID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ACTIVITIES",
                columns: table => new
                {
                    AID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ACTIVITI__C69007C8F1F72C4B", x => x.AID);
                    table.ForeignKey(
                        name: "FK__ACTIVITIES__LID__3A81B327",
                        column: x => x.LID,
                        principalTable: "LANDMARKS",
                        principalColumn: "LID");
                });

            migrationBuilder.CreateTable(
                name: "HOSPITALITY",
                columns: table => new
                {
                    HID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HRating = table.Column<int>(type: "int", nullable: true),
                    LID = table.Column<int>(type: "int", nullable: false),
                    LandmarkLid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HOSPITAL__C7551527520749D6", x => x.HID);
                    table.ForeignKey(
                        name: "FK_HOSPITALITY_LANDMARKS_LandmarkLid",
                        column: x => x.LandmarkLid,
                        principalTable: "LANDMARKS",
                        principalColumn: "LID");
                });

            migrationBuilder.CreateTable(
                name: "TRAVELPLAN",
                columns: table => new
                {
                    PID = table.Column<int>(type: "int", nullable: false),
                    HID = table.Column<int>(type: "int", nullable: false),
                    AID = table.Column<int>(type: "int", nullable: false),
                    AidNavigationAid = table.Column<int>(type: "int", nullable: false),
                    HidNavigationHid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TRAVELPL__C5775520409AE4D2", x => x.PID);
                    table.ForeignKey(
                        name: "FK_TRAVELPLAN_ACTIVITIES_AidNavigationAid",
                        column: x => x.AidNavigationAid,
                        principalTable: "ACTIVITIES",
                        principalColumn: "AID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TRAVELPLAN_HOSPITALITY_HidNavigationHid",
                        column: x => x.HidNavigationHid,
                        principalTable: "HOSPITALITY",
                        principalColumn: "HID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTravel",
                columns: table => new
                {
                    UTID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PID = table.Column<int>(type: "int", nullable: false),
                    UID = table.Column<int>(type: "int", nullable: false),
                    UTDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserTrav__5A6477EEBC9C83D4", x => x.UTID);
                    table.ForeignKey(
                        name: "FK__UserTravel__PID__4AB81AF0",
                        column: x => x.PID,
                        principalTable: "TRAVELPLAN",
                        principalColumn: "PID");
                    table.ForeignKey(
                        name: "FK__UserTravel__UID__4BAC3F29",
                        column: x => x.UID,
                        principalTable: "USERDATA",
                        principalColumn: "UID");
                });

            migrationBuilder.CreateIndex(
                name: "ADSD",
                table: "ACTIVITIES",
                columns: new[] { "AName", "LID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ACTIVITIES_LID",
                table: "ACTIVITIES",
                column: "LID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "([NormalizedName] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "([NormalizedUserName] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_HOSPITALITY_LandmarkLid",
                table: "HOSPITALITY",
                column: "LandmarkLid");

            migrationBuilder.CreateIndex(
                name: "UQ__HOSPITAL__B3244A5CBADF0096",
                table: "HOSPITALITY",
                column: "HName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__LANDMARK__02911AAE4AE50D45",
                table: "LANDMARKS",
                column: "LName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TRAVELPLAN_AidNavigationAid",
                table: "TRAVELPLAN",
                column: "AidNavigationAid");

            migrationBuilder.CreateIndex(
                name: "IX_TRAVELPLAN_HidNavigationHid",
                table: "TRAVELPLAN",
                column: "HidNavigationHid");

            migrationBuilder.CreateIndex(
                name: "UQ__TRAVELPL__C69007C96192873F",
                table: "TRAVELPLAN",
                column: "AID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__TRAVELPL__C755152638E75731",
                table: "TRAVELPLAN",
                column: "HID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__USERDATA__75B1691EEB5A55C1",
                table: "USERDATA",
                column: "UEmail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserTravel_PID",
                table: "UserTravel",
                column: "PID");

            migrationBuilder.CreateIndex(
                name: "IX_UserTravel_UID",
                table: "UserTravel",
                column: "UID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "UserTravel");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "TRAVELPLAN");

            migrationBuilder.DropTable(
                name: "USERDATA");

            migrationBuilder.DropTable(
                name: "ACTIVITIES");

            migrationBuilder.DropTable(
                name: "HOSPITALITY");

            
        }
    }
}
