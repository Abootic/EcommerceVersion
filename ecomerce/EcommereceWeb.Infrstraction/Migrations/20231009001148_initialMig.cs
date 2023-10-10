using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommereceWeb.Infrstraction.Migrations
{
    public partial class initialMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                schema: "dbo",
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
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Others = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
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
                name: "Attribute",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EnName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_Attributes", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EnName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CompanyInfo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_Brands", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "Configuration",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ArValue = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EnValue = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(MAX)", maxLength: 255, nullable: true),
                    Description1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_Configuration", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderEmail = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(MAX)", maxLength: 1024, nullable: false),
                    SenderName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_Contacts", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "Coupon",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rate = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ApplyTo = table.Column<int>(type: "int", maxLength: 255, nullable: true),
                    QtRequire = table.Column<int>(type: "int", nullable: true),
                    PriceRequire = table.Column<decimal>(type: "decimal", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ArDetails = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EnDetails = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_Coupon", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EnName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Simbol = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsMain = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_Currency", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "MainClassification",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArMainClassificationName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EnMainClassificationName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_MainClassification", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "MasterData",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeValue = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_MasterData", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "Slider",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ArName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EnDetails = table.Column<string>(type: "nvarchar(MAX)", maxLength: 255, nullable: true),
                    ArDetails = table.Column<string>(type: "nvarchar(MAX)", maxLength: 255, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_Slider", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "TaxConfiguration",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_TaxConfiguration", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
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
                        principalSchema: "dbo",
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
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                schema: "dbo",
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
                        principalSchema: "dbo",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttributeItem",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EnName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Details = table.Column<string>(type: "nvarchar(MAX)", maxLength: 255, nullable: true),
                    ColorCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AttributeId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_AttributeItem", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_AttributeId_AttributeItem",
                        column: x => x.AttributeId,
                        principalSchema: "dbo",
                        principalTable: "Attribute",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BasicClassification",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArBasicClassificationName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EnBasicClassificationName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MainClassificationId = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_BasicClassification", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_MainClassification_BasicClassification",
                        column: x => x.MainClassificationId,
                        principalSchema: "dbo",
                        principalTable: "MainClassification",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DetailsData",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EnName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    MasterDataId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_DetailsData", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_MasterDatan_DetailsDatas",
                        column: x => x.MasterDataId,
                        principalSchema: "dbo",
                        principalTable: "MasterData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubClassificationBase",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArSubClassificationName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EnSubClassificationName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BasicClassificationId = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_SubClassificationBase", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_BasicClassificationId_SubClassificationBases",
                        column: x => x.BasicClassificationId,
                        principalSchema: "dbo",
                        principalTable: "BasicClassification",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubSubclassification",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArSubSubClassificationName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EnSubSubClassificationName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SubClassificationBaseId = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_SubSubclassification", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_SubClassificationBaseId_SubSubclassifications",
                        column: x => x.SubClassificationBaseId,
                        principalSchema: "dbo",
                        principalTable: "SubClassificationBase",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EnName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EnDetails = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    ArDetails = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    MinOrderQuantity = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    MaxOrderQuantity = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Discount = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    VideoProvider = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VideoUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TaxType = table.Column<int>(type: "int", nullable: false),
                    ArKeyWords = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    EnKeyWords = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: true),
                    MainClassificationId = table.Column<int>(type: "int", nullable: true),
                    BasicClassificationId = table.Column<int>(type: "int", nullable: true),
                    SubClassificationBaseId = table.Column<int>(type: "int", nullable: true),
                    SubSubclassificationId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_Product", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_BasicClassification_Products",
                        column: x => x.BasicClassificationId,
                        principalSchema: "dbo",
                        principalTable: "BasicClassification",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Brand_Products",
                        column: x => x.BrandId,
                        principalSchema: "dbo",
                        principalTable: "Brands",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MainClassification_Products",
                        column: x => x.MainClassificationId,
                        principalSchema: "dbo",
                        principalTable: "MainClassification",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubClassificationBase_Products",
                        column: x => x.SubClassificationBaseId,
                        principalSchema: "dbo",
                        principalTable: "SubClassificationBase",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubSubClassification_Products",
                        column: x => x.SubSubclassificationId,
                        principalSchema: "dbo",
                        principalTable: "SubSubclassification",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AddProductToFavorite",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_AddProductToFavorite", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_AddProductToFavorites_Products",
                        column: x => x.ProductId,
                        principalSchema: "dbo",
                        principalTable: "Product",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AddProductToFavorites_User",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CouponItem",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CouponId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_CouponItem", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_CouponItems_Coupon",
                        column: x => x.CouponId,
                        principalSchema: "dbo",
                        principalTable: "Coupon",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CouponItems_Product",
                        column: x => x.ProductId,
                        principalSchema: "dbo",
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductAdditionalDetails",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EnTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ArValue = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EnValue = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_ProductAdditionalDetails", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_Product_ProductAdditionalDetails",
                        column: x => x.ProductId,
                        principalSchema: "dbo",
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductAttribute",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    AttributeId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AttributeItemId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_ProductAttribute", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_AttributeId_ProductAttribute",
                        column: x => x.AttributeId,
                        principalSchema: "dbo",
                        principalTable: "Attribute",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AttributeItemId_ProductAttribute",
                        column: x => x.AttributeItemId,
                        principalSchema: "dbo",
                        principalTable: "AttributeItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductId_ProductAttribute",
                        column: x => x.ProductId,
                        principalSchema: "dbo",
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductColors",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    ImgUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ArColorName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EnColorName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_ProductColors", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_ProductColors_Products",
                        column: x => x.ProductId,
                        principalSchema: "dbo",
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductEvaluaton",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<decimal>(type: "decimal(38,17)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_ProductEvaluaton", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_ProductEvaluaton_Products",
                        column: x => x.ProductId,
                        principalSchema: "dbo",
                        principalTable: "Product",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductEvaluaton_User",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductImage",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_ProductImage", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products",
                        column: x => x.ProductId,
                        principalSchema: "dbo",
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductSize",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal", nullable: true),
                    ArSizeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EnSizeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_ProductSize", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_ProductSize_Products",
                        column: x => x.ProductId,
                        principalSchema: "dbo",
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductUnitSize",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Weight = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Height = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Width = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ProductType = table.Column<bool>(type: "bit", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_ProductUnitSize", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_ProductUnitSizes_Products",
                        column: x => x.ProductId,
                        principalSchema: "dbo",
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductVariation",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    ArName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EnName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AttItemId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Quntatiy = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModfiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_ProductVariation", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_ProductId_ProductVariation",
                        column: x => x.ProductId,
                        principalSchema: "dbo",
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8c1f7d67-0b9e-44ef-83d4-6e4ef72d3b6f", "ca3b3647-fb97-40a0-ad64-8a3d645cdc03", "Manager", "OWNER" },
                    { "ca34737e-e863-40aa-a82f-adbd3207988a", "b9fce677-ff9b-4d55-93b0-dcb97d12b11c", "Admin", "ADMIN" },
                    { "cb512048-1ad1-437b-8930-1b70a31e4d5c", "de8c59e2-0bf9-451e-8c0f-672e0335fbf2", "ServiceProvider", "SERVICEPROVIDER" },
                    { "eedae456-fa3a-47a0-9764-c634214bbe42", "a8333576-d0ec-4caa-925c-cf7113f8df7d", "User", "USER" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Email", "EmailConfirmed", "FullName", "Image", "IsDeleted", "LastModfiedAt", "LastModfiedBy", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Others", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "4a2e1650-21bd-4e67-832e-2e99c267a2e4", 0, "e00d084b-2169-46e6-a219-545e1597b64e", new DateTime(2023, 10, 9, 3, 11, 47, 301, DateTimeKind.Local).AddTicks(6112), null, null, null, "Admin@Gmail.com", false, "Admin", "unkown", false, null, null, false, null, "ADMIN@GMAIL.COM", "ADMIN", null, "AQAAAAEAACcQAAAAEICu+7CG2mMJb/Brnx2DByjlf3tZ03/+zQzoAeZLzTyiU/JXE7ifMQgPGOwDXNKrEw==", "123456789", false, "afdc9cd9-2f7f-40f0-817e-00a558a9b7d4", null, false, "Admin", null });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ca34737e-e863-40aa-a82f-adbd3207988a", "4a2e1650-21bd-4e67-832e-2e99c267a2e4" });

            migrationBuilder.CreateIndex(
                name: "IX_AddProductToFavorite_ProductId",
                schema: "dbo",
                table: "AddProductToFavorite",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_AddProductToFavorite_UserId",
                schema: "dbo",
                table: "AddProductToFavorite",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "dbo",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                schema: "dbo",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "dbo",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "dbo",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeItem_AttributeId",
                schema: "dbo",
                table: "AttributeItem",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_BasicClassification_MainClassificationId",
                schema: "dbo",
                table: "BasicClassification",
                column: "MainClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_CouponItem_CouponId",
                schema: "dbo",
                table: "CouponItem",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_CouponItem_ProductId",
                schema: "dbo",
                table: "CouponItem",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailsData_MasterDataId",
                schema: "dbo",
                table: "DetailsData",
                column: "MasterDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_BasicClassificationId",
                schema: "dbo",
                table: "Product",
                column: "BasicClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_BrandId",
                schema: "dbo",
                table: "Product",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_MainClassificationId",
                schema: "dbo",
                table: "Product",
                column: "MainClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SubClassificationBaseId",
                schema: "dbo",
                table: "Product",
                column: "SubClassificationBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SubSubclassificationId",
                schema: "dbo",
                table: "Product",
                column: "SubSubclassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAdditionalDetails_ProductId",
                schema: "dbo",
                table: "ProductAdditionalDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttribute_AttributeId",
                schema: "dbo",
                table: "ProductAttribute",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttribute_AttributeItemId",
                schema: "dbo",
                table: "ProductAttribute",
                column: "AttributeItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttribute_ProductId",
                schema: "dbo",
                table: "ProductAttribute",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductColors_ProductId",
                schema: "dbo",
                table: "ProductColors",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductEvaluaton_ProductId",
                schema: "dbo",
                table: "ProductEvaluaton",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductEvaluaton_UserId",
                schema: "dbo",
                table: "ProductEvaluaton",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_ProductId",
                schema: "dbo",
                table: "ProductImage",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSize_ProductId",
                schema: "dbo",
                table: "ProductSize",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductUnitSize_ProductId",
                schema: "dbo",
                table: "ProductUnitSize",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariation_ProductId",
                schema: "dbo",
                table: "ProductVariation",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SubClassificationBase_BasicClassificationId",
                schema: "dbo",
                table: "SubClassificationBase",
                column: "BasicClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_SubSubclassification_SubClassificationBaseId",
                schema: "dbo",
                table: "SubSubclassification",
                column: "SubClassificationBaseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddProductToFavorite",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Configuration",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Contacts",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CouponItem",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Currency",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "DetailsData",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ProductAdditionalDetails",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ProductAttribute",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ProductColors",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ProductEvaluaton",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ProductImage",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ProductSize",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ProductUnitSize",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ProductVariation",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Slider",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TaxConfiguration",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Coupon",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MasterData",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AttributeItem",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Attribute",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Brands",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SubSubclassification",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SubClassificationBase",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "BasicClassification",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MainClassification",
                schema: "dbo");
        }
    }
}
