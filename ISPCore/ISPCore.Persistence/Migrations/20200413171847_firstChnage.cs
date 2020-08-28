using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ISPCore.Persistence.Migrations
{
    public partial class firstChnage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountingHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    AccountListID = table.Column<int>(nullable: false),
                    PurchaseID = table.Column<int>(nullable: false),
                    SalesID = table.Column<int>(nullable: false),
                    DepositID = table.Column<int>(nullable: false),
                    ExpenseID = table.Column<int>(nullable: false),
                    ActionTypeID = table.Column<int>(nullable: false),
                    DRCRTypeID = table.Column<int>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Month = table.Column<int>(nullable: false),
                    Day = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountOwner",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    AccountOwnerName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountOwner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssetType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    AssetTypeName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttendanceType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    AttendanceTypeName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuthorViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsAuthor = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorViewModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BandwithResellerGivenItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    MeasureUnit = table.Column<string>(nullable: true),
                    PerUnitCommonPrice = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BandwithResellerGivenItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BillGenerateHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    Year = table.Column<string>(nullable: true),
                    Month = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillGenerateHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    BrandName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CableType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    CableTypeName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CableType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CableUnit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    CableUnitName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CableUnit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Client_Stock_StockDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    StockID = table.Column<int>(nullable: false),
                    StockDetailsID = table.Column<int>(nullable: false),
                    ItemID = table.Column<int>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    BrandID = table.Column<int>(nullable: false),
                    BrandName = table.Column<string>(nullable: true),
                    SupplierID = table.Column<int>(nullable: false),
                    SupplierName = table.Column<string>(nullable: true),
                    SupplierInvoice = table.Column<string>(nullable: true),
                    Serial = table.Column<string>(nullable: true),
                    WarrentyProduct = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_Stock_StockDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Client_Stock_StockDetails_ForDistribution",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    StockID = table.Column<int>(nullable: false),
                    StockDetailsID = table.Column<int>(nullable: false),
                    PopID = table.Column<int>(nullable: true),
                    Client_Stock_StockDetails_ForDistributionID = table.Column<int>(nullable: true),
                    CustomerID = table.Column<int>(nullable: true),
                    EmployeeID = table.Column<int>(nullable: false),
                    DistributionReasonID = table.Column<int>(nullable: false),
                    OldStockID = table.Column<int>(nullable: true),
                    OldStockDetailsID = table.Column<int>(nullable: true),
                    OldSectionID = table.Column<int>(nullable: true),
                    OldProductStatusID = table.Column<int>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_Stock_StockDetails_ForDistribution", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientCableAssign",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    CableQuantity = table.Column<int>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientCableAssign", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientCableDistribution",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    CableQuantity = table.Column<int>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: true),
                    ClientID = table.Column<int>(nullable: true),
                    AssignEmployee = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientCableDistribution", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientStockAssign",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    StockDetailsID = table.Column<int>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientStockAssign", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true),
                    CompanyEmail = table.Column<string>(nullable: true),
                    CompanyAddress = table.Column<string>(nullable: true),
                    ContactPerson = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    CompanyLogo = table.Column<byte[]>(nullable: true),
                    CompanyLogoPath = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComplainType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    ComplainTypeName = table.Column<string>(nullable: true),
                    ShowMessageBox = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplainType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConnectionType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    ConnectionTypeName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ControllerName",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    ControllerNames = table.Column<string>(nullable: true),
                    ControllerValue = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControllerName", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Day",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    DayName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Day", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    DepartmentName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Distribution_Transaction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    StockDetailsID = table.Column<int>(nullable: false),
                    SectionID = table.Column<int>(nullable: false),
                    ProductStatusID = table.Column<int>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    BrandName = table.Column<string>(nullable: true),
                    Serial = table.Column<string>(nullable: true),
                    ClientName = table.Column<string>(nullable: true),
                    EmployeeName = table.Column<string>(nullable: true),
                    SectionName = table.Column<string>(nullable: true),
                    ProductStatus = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribution_Transaction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DistributionReason",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    DistributionReasonName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributionReason", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DutyShift",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    StartHour = table.Column<int>(nullable: false),
                    StartMinute = table.Column<int>(nullable: false),
                    EndHour = table.Column<int>(nullable: false),
                    EndMinute = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DutyShift", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormNameForAuth",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    FormName = table.Column<string>(nullable: true),
                    IsGranted = table.Column<bool>(nullable: false),
                    FormID = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Checked = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormNameForAuth", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GivenPaymentType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    GivenPaymentTypeName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GivenPaymentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IPPool",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    IPPoolName = table.Column<string>(nullable: true),
                    StartRange = table.Column<string>(nullable: true),
                    EndRange = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPPool", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ISPAccessList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    AccessName = table.Column<string>(nullable: true),
                    AccessValue = table.Column<int>(nullable: false),
                    IsGranted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ISPAccessList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    ItemFor = table.Column<int>(nullable: true),
                    ItemCode = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveSalaryType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    LeaveSalaryTypeName = table.Column<string>(nullable: true),
                    Percentage = table.Column<decimal>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveSalaryType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LineStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    LineStatusName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoginViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    RememberMe = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginViewModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeasurementUnit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    MeasurementUnitName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasurementUnit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mikrotik",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    MikrotikName = table.Column<string>(nullable: true),
                    RealIP = table.Column<string>(nullable: true),
                    MikUserName = table.Column<string>(nullable: true),
                    MikPassword = table.Column<string>(nullable: true),
                    APIPort = table.Column<int>(nullable: false),
                    WebPort = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mikrotik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Month",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    MonthName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Month", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OptionSetting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    OptionSettingsName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentBy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    PaymentByName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentBy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentFrom",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    PaymentFromName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentFrom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    PaymentTypeName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pop",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    PopName = table.Column<string>(nullable: true),
                    PopLocation = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pop", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    ProductStatusName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProfilePercentageFields",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    FieldsName = table.Column<string>(nullable: true),
                    TableName = table.Column<string>(nullable: true),
                    MappingField = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfilePercentageFields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResellerBillingCycle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    Day = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResellerBillingCycle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    RoleName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    SectionName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecurityQuestion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    SecurityQuestionName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityQuestion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SMS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    SMSTitle = table.Column<string>(nullable: true),
                    SendMessageText = table.Column<string>(nullable: true),
                    SMSCode = table.Column<string>(nullable: true),
                    Sender = table.Column<string>(nullable: true),
                    SMSStatus = table.Column<int>(nullable: false),
                    SMSCounter = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SMSSenderIDPass",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    SenderID = table.Column<string>(nullable: true),
                    Pass = table.Column<string>(nullable: true),
                    Sender = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    HelpLine = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSSenderIDPass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    SupplierName = table.Column<string>(nullable: true),
                    SupplierAddress = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimePeriodForSignal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    UpToHours = table.Column<double>(nullable: false),
                    SignalSign = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimePeriodForSignal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRightPermission",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    UserRightPermissionName = table.Column<string>(nullable: true),
                    UserRightPermissionDescription = table.Column<string>(nullable: true),
                    UserRightPermissionDetails = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRightPermission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    VendorName = table.Column<string>(nullable: true),
                    VendorAddress = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    VendorLogoName = table.Column<string>(nullable: true),
                    VendorImageOriginal = table.Column<byte[]>(nullable: true),
                    VendorImagePath = table.Column<string>(nullable: true),
                    VendorContactPerson = table.Column<string>(nullable: true),
                    VendorEmail = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VendorType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    VendorTypeName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Year",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    YearName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Year", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    AccountTitle = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    InitialBalance = table.Column<decimal>(nullable: true),
                    AccountNumber = table.Column<int>(nullable: false),
                    ContactPerson = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    BankURL = table.Column<string>(nullable: true),
                    OwnerID = table.Column<int>(nullable: false),
                    AccountOwnerId = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountList_AccountOwner_AccountOwnerId",
                        column: x => x.AccountOwnerId,
                        principalTable: "AccountOwner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Asset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    AssetName = table.Column<string>(nullable: true),
                    AssetTypeID = table.Column<int>(nullable: false),
                    AssetValue = table.Column<double>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: true),
                    WarrentyStartDate = table.Column<DateTime>(nullable: true),
                    WarrentyEndDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asset_AssetType_AssetTypeID",
                        column: x => x.AssetTypeID,
                        principalTable: "AssetType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyVsPayer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    CompanyVsPayerName = table.Column<string>(nullable: true),
                    CompanyID = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyVsPayer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyVsPayer_Company_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Form",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    ControllerNameID = table.Column<int>(nullable: false),
                    FormName = table.Column<string>(nullable: true),
                    FormValue = table.Column<string>(nullable: true),
                    FormDescription = table.Column<string>(nullable: true),
                    FormLocation = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Form_ControllerName_ControllerNameID",
                        column: x => x.ControllerNameID,
                        principalTable: "ControllerName",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ActionNameAuthentication",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    ActionName = table.Column<string>(nullable: true),
                    IsGranted = table.Column<bool>(nullable: false),
                    ActionID = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Checked = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    FormNameForAuthId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionNameAuthentication", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActionNameAuthentication_FormNameForAuth_FormNameForAuthId",
                        column: x => x.FormNameForAuthId,
                        principalTable: "FormNameForAuth",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    ItemID = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stock_Item_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Package",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    PackageName = table.Column<string>(nullable: true),
                    IPPoolID = table.Column<int>(nullable: true),
                    MikrotikID = table.Column<int>(nullable: true),
                    LocalAddress = table.Column<string>(nullable: true),
                    OldPackageName = table.Column<string>(nullable: true),
                    PackagePrice = table.Column<float>(nullable: false),
                    BandWith = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Package_IPPool_IPPoolID",
                        column: x => x.IPPoolID,
                        principalTable: "IPPool",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Package_Mikrotik_MikrotikID",
                        column: x => x.MikrotikID,
                        principalTable: "Mikrotik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccountListVsAmmountTransfer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    FromAccountID = table.Column<int>(nullable: false),
                    ToAccountID = table.Column<int>(nullable: false),
                    TransferDate = table.Column<DateTime>(nullable: false),
                    CurrencyID = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Tags = table.Column<string>(nullable: true),
                    PaymentByID = table.Column<int>(nullable: false),
                    References = table.Column<string>(nullable: true),
                    BreakDownAccountListID = table.Column<int>(nullable: false),
                    TransferType = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountListVsAmmountTransfer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountListVsAmmountTransfer_PaymentBy_PaymentByID",
                        column: x => x.PaymentByID,
                        principalTable: "PaymentBy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reseller",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    ResellerName = table.Column<string>(nullable: true),
                    ResellerLoginName = table.Column<string>(nullable: true),
                    ResellerBusinessName = table.Column<string>(nullable: true),
                    ResellerPassword = table.Column<string>(nullable: true),
                    ResellerTypeListID = table.Column<string>(nullable: true),
                    ResellerAddress = table.Column<string>(nullable: true),
                    ResellerContact = table.Column<string>(nullable: true),
                    ResellerBillingCycleList = table.Column<string>(nullable: true),
                    ResellerLogo = table.Column<byte[]>(nullable: true),
                    ResellerLogoPath = table.Column<string>(nullable: true),
                    BandwithReselleItemGivenWithPrice = table.Column<string>(nullable: true),
                    MacReselleGivenPackageWithPrice = table.Column<string>(nullable: true),
                    ResellerBalance = table.Column<double>(nullable: false),
                    RoleID = table.Column<int>(nullable: true),
                    UserRightPermissionID = table.Column<int>(nullable: true),
                    MacResellerAssignMikrotik = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reseller", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reseller_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reseller_UserRightPermission_UserRightPermissionID",
                        column: x => x.UserRightPermissionID,
                        principalTable: "UserRightPermission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ActionList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    FormID = table.Column<int>(nullable: false),
                    ActionName = table.Column<string>(nullable: true),
                    ActionValue = table.Column<string>(nullable: true),
                    ActionDescription = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActionList_Form_FormID",
                        column: x => x.FormID,
                        principalTable: "Form",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    StockID = table.Column<int>(nullable: false),
                    BrandID = table.Column<int>(nullable: true),
                    SectionID = table.Column<int>(nullable: false),
                    SupplierID = table.Column<int>(nullable: true),
                    SupplierInvoice = table.Column<string>(nullable: true),
                    Serial = table.Column<string>(nullable: true),
                    BarCode = table.Column<string>(nullable: true),
                    ProductStatusID = table.Column<int>(nullable: false),
                    WarrentyProduct = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockDetails_Brand_BrandID",
                        column: x => x.BrandID,
                        principalTable: "Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockDetails_ProductStatus_ProductStatusID",
                        column: x => x.ProductStatusID,
                        principalTable: "ProductStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockDetails_Section_SectionID",
                        column: x => x.SectionID,
                        principalTable: "Section",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockDetails_Stock_StockID",
                        column: x => x.StockID,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockDetails_Supplier_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Box",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    BoxName = table.Column<string>(nullable: true),
                    ResellerID = table.Column<int>(nullable: true),
                    BoxLocation = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Box", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Box_Reseller_ResellerID",
                        column: x => x.ResellerID,
                        principalTable: "Reseller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    LoginName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DepartmentID = table.Column<int>(nullable: true),
                    RoleID = table.Column<int>(nullable: true),
                    UserRightPermissionID = table.Column<int>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    DeviceID = table.Column<int>(nullable: false),
                    DutyShiftID = table.Column<int>(nullable: false),
                    Salary = table.Column<int>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: true),
                    EmployeesId = table.Column<int>(nullable: true),
                    BreakHour = table.Column<int>(nullable: false),
                    BreakMinute = table.Column<int>(nullable: false),
                    DutyShiftCombined = table.Column<string>(nullable: true),
                    EmployeeOwnImageBytes = table.Column<byte[]>(nullable: true),
                    EmployeeOwnImageBytesPaths = table.Column<string>(nullable: true),
                    EmployeeNIDImageBytes = table.Column<byte[]>(nullable: true),
                    EmployeeNIDImageBytesPaths = table.Column<string>(nullable: true),
                    ResellerID = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_DutyShift_DutyShiftID",
                        column: x => x.DutyShiftID,
                        principalTable: "DutyShift",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Employee_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Reseller_ResellerID",
                        column: x => x.ResellerID,
                        principalTable: "Reseller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_UserRightPermission_UserRightPermissionID",
                        column: x => x.UserRightPermissionID,
                        principalTable: "UserRightPermission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Head",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    HeadName = table.Column<string>(nullable: true),
                    HeadTypeID = table.Column<int>(nullable: false),
                    ResellerID = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Head", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Head_Reseller_ResellerID",
                        column: x => x.ResellerID,
                        principalTable: "Reseller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Purchase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    SupplierID = table.Column<int>(nullable: false),
                    PublishStatus = table.Column<int>(nullable: false),
                    InvoicePrefix = table.Column<string>(nullable: true),
                    InvoiceID = table.Column<string>(nullable: true),
                    IssuedAt = table.Column<DateTime>(nullable: false),
                    SupplierNoted = table.Column<string>(nullable: true),
                    SubTotal = table.Column<double>(nullable: false),
                    DiscountType = table.Column<int>(nullable: false),
                    DiscountPercentOrFixedAmount = table.Column<double>(nullable: false),
                    DiscountAmount = table.Column<double>(nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    Tax = table.Column<double>(nullable: false),
                    Total = table.Column<double>(nullable: false),
                    PurchasePayment = table.Column<double>(nullable: false),
                    ResellerID = table.Column<int>(nullable: true),
                    PurchaseStatus = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Purchase_Reseller_ResellerID",
                        column: x => x.ResellerID,
                        principalTable: "Reseller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Purchase_Supplier_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResellerPaymentDetailsHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    ResellerPaymentID = table.Column<int>(nullable: false),
                    ResellerID = table.Column<int>(nullable: false),
                    ResellerPaymentGivenTypeID = table.Column<int>(nullable: false),
                    ActionTypeID = table.Column<int>(nullable: false),
                    LastAmount = table.Column<double>(nullable: false),
                    PaymentAmount = table.Column<double>(nullable: false),
                    DeleteTimeResellerAmount = table.Column<double>(nullable: false),
                    PaymentYear = table.Column<double>(nullable: false),
                    PaymentMonth = table.Column<double>(nullable: false),
                    PaymentStatus = table.Column<int>(nullable: false),
                    PaymentCheckOrAnySerial = table.Column<string>(nullable: true),
                    CollectBy = table.Column<int>(nullable: false),
                    ActiveBy = table.Column<int>(nullable: false),
                    PaymentByID = table.Column<int>(nullable: false),
                    PaymenReceivedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResellerPaymentDetailsHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResellerPaymentDetailsHistory_PaymentBy_PaymentByID",
                        column: x => x.PaymentByID,
                        principalTable: "PaymentBy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResellerPaymentDetailsHistory_Reseller_ResellerID",
                        column: x => x.ResellerID,
                        principalTable: "Reseller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResellerVsPackageHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    ResellerID = table.Column<int>(nullable: false),
                    ResellerName = table.Column<int>(nullable: false),
                    ResellerPackageID = table.Column<int>(nullable: false),
                    PackageName = table.Column<string>(nullable: true),
                    PackagePrice = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResellerVsPackageHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResellerVsPackageHistory_Reseller_ResellerID",
                        column: x => x.ResellerID,
                        principalTable: "Reseller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zone",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    ZoneName = table.Column<string>(nullable: true),
                    ResellerID = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zone_Reseller_ResellerID",
                        column: x => x.ResellerID,
                        principalTable: "Reseller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DirectProductSectionChangeFromWorkingToOthers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    ClientName = table.Column<string>(nullable: true),
                    TakenEmployee = table.Column<string>(nullable: true),
                    StockDetailsID = table.Column<int>(nullable: false),
                    FromSection = table.Column<int>(nullable: false),
                    ToSection = table.Column<int>(nullable: false),
                    WhoChanged = table.Column<string>(nullable: true),
                    ChangeDateTime = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectProductSectionChangeFromWorkingToOthers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DirectProductSectionChangeFromWorkingToOthers_StockDetails_StockDetailsID",
                        column: x => x.StockDetailsID,
                        principalTable: "StockDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CableStock",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    CableTypeID = table.Column<int>(nullable: false),
                    BrandID = table.Column<int>(nullable: true),
                    SupplierID = table.Column<int>(nullable: true),
                    SupplierInvoice = table.Column<string>(nullable: true),
                    FromReading = table.Column<int>(nullable: false),
                    ToReading = table.Column<int>(nullable: false),
                    CableUnitID = table.Column<int>(nullable: false),
                    CableBoxName = table.Column<string>(nullable: true),
                    CableQuantity = table.Column<int>(nullable: false),
                    UsedQuantityFromThisBox = table.Column<int>(nullable: false),
                    TotallyUsed = table.Column<int>(nullable: true),
                    EmployeeID = table.Column<int>(nullable: false),
                    IndicatorStatus = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CableStock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CableStock_Brand_BrandID",
                        column: x => x.BrandID,
                        principalTable: "Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CableStock_CableType_CableTypeID",
                        column: x => x.CableTypeID,
                        principalTable: "CableType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CableStock_CableUnit_CableUnitID",
                        column: x => x.CableUnitID,
                        principalTable: "CableUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CableStock_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CableStock_Supplier_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClientLineStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    CLSClientDetailsID = table.Column<int>(nullable: false),
                    PackageID = table.Column<int>(nullable: true),
                    LineStatusID = table.Column<int>(nullable: false),
                    LineStatusFromWhichMonth = table.Column<int>(nullable: true),
                    StatusChangeReason = table.Column<string>(nullable: true),
                    LineStatusChangeDate = table.Column<DateTime>(nullable: true),
                    EmployeeID = table.Column<int>(nullable: true),
                    ResellerID = table.Column<int>(nullable: true),
                    MikrotikID = table.Column<int>(nullable: true),
                    IsLineStatusApplied = table.Column<bool>(nullable: false),
                    LineStatusWillActiveInThisDate = table.Column<DateTime>(nullable: true),
                    StatusFromNow = table.Column<bool>(nullable: false),
                    StatusThisMonth = table.Column<int>(nullable: false),
                    StatusNextMonth = table.Column<int>(nullable: false),
                    PackageThisMonth = table.Column<int>(nullable: false),
                    PackageNextMonth = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientLineStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientLineStatus_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientLineStatus_LineStatus_LineStatusID",
                        column: x => x.LineStatusID,
                        principalTable: "LineStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientLineStatus_Mikrotik_MikrotikID",
                        column: x => x.MikrotikID,
                        principalTable: "Mikrotik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientLineStatus_Package_PackageID",
                        column: x => x.PackageID,
                        principalTable: "Package",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientLineStatus_Reseller_ResellerID",
                        column: x => x.ResellerID,
                        principalTable: "Reseller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLeaveHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: false),
                    Reason = table.Column<string>(nullable: true),
                    LeaveSalaryTypeID = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLeaveHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeLeaveHistory_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeLeaveHistory_LeaveSalaryType_LeaveSalaryTypeID",
                        column: x => x.LeaveSalaryTypeID,
                        principalTable: "LeaveSalaryType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeVsWorkSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    DayID = table.Column<int>(nullable: false),
                    StartHour = table.Column<int>(nullable: false),
                    StartMinute = table.Column<int>(nullable: false),
                    RunHour = table.Column<int>(nullable: false),
                    RunMinute = table.Column<int>(nullable: false),
                    BreakStartHour = table.Column<int>(nullable: false),
                    BreakStartMinute = table.Column<int>(nullable: false),
                    BreakEndHour = table.Column<int>(nullable: false),
                    BreakEndMinute = table.Column<int>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeVsWorkSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeVsWorkSchedules_Day_DayID",
                        column: x => x.DayID,
                        principalTable: "Day",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeVsWorkSchedules_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Deposit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    Descriptions = table.Column<string>(nullable: true),
                    DescriptionFileByte = table.Column<byte[]>(nullable: true),
                    DescriptionFilePath = table.Column<string>(nullable: true),
                    HeadID = table.Column<int>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    PaymentDate = table.Column<DateTime>(nullable: false),
                    CompanyID = table.Column<int>(nullable: false),
                    AccountListID = table.Column<int>(nullable: false),
                    PayerID = table.Column<int>(nullable: false),
                    CompanyVSPayerId = table.Column<int>(nullable: true),
                    PaymentByID = table.Column<int>(nullable: false),
                    DepositStatus = table.Column<int>(nullable: false),
                    References = table.Column<string>(nullable: true),
                    ResellerID = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deposit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deposit_AccountList_AccountListID",
                        column: x => x.AccountListID,
                        principalTable: "AccountList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deposit_Company_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deposit_CompanyVsPayer_CompanyVSPayerId",
                        column: x => x.CompanyVSPayerId,
                        principalTable: "CompanyVsPayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deposit_Head_HeadID",
                        column: x => x.HeadID,
                        principalTable: "Head",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deposit_PaymentBy_PaymentByID",
                        column: x => x.PaymentByID,
                        principalTable: "PaymentBy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deposit_Reseller_ResellerID",
                        column: x => x.ResellerID,
                        principalTable: "Reseller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Expense",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    Descriptions = table.Column<string>(nullable: true),
                    DescriptionFileByte = table.Column<byte[]>(nullable: true),
                    DescriptionFilePath = table.Column<string>(nullable: true),
                    HeadID = table.Column<int>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    PaymentDate = table.Column<DateTime>(nullable: false),
                    CompanyID = table.Column<int>(nullable: false),
                    AccountListID = table.Column<int>(nullable: false),
                    PayerID = table.Column<int>(nullable: false),
                    CompanyVSPayerId = table.Column<int>(nullable: true),
                    PaymentByID = table.Column<int>(nullable: false),
                    ExpenseStatus = table.Column<int>(nullable: false),
                    References = table.Column<string>(nullable: true),
                    ResellerID = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expense", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expense_AccountList_AccountListID",
                        column: x => x.AccountListID,
                        principalTable: "AccountList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Expense_Company_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Expense_CompanyVsPayer_CompanyVSPayerId",
                        column: x => x.CompanyVSPayerId,
                        principalTable: "CompanyVsPayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Expense_Head_HeadID",
                        column: x => x.HeadID,
                        principalTable: "Head",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Expense_PaymentBy_PaymentByID",
                        column: x => x.PaymentByID,
                        principalTable: "PaymentBy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Expense_Reseller_ResellerID",
                        column: x => x.ResellerID,
                        principalTable: "Reseller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    PurchaseID = table.Column<int>(nullable: false),
                    ItemID = table.Column<int>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Tax = table.Column<double>(nullable: false),
                    HasWarrenty = table.Column<bool>(nullable: false),
                    WarrentyStart = table.Column<DateTime>(nullable: true),
                    WarrentyEnd = table.Column<DateTime>(nullable: true),
                    Serial = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseDetails_Item_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseDetails_Purchase_PurchaseID",
                        column: x => x.PurchaseID,
                        principalTable: "Purchase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchasePaymentHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    PurchaseID = table.Column<int>(nullable: false),
                    AccountListID = table.Column<int>(nullable: false),
                    PaymentByID = table.Column<int>(nullable: false),
                    PurchasePaymentDate = table.Column<DateTime>(nullable: false),
                    CheckNo = table.Column<string>(nullable: true),
                    CheckName = table.Column<string>(nullable: true),
                    CheckPath = table.Column<string>(nullable: true),
                    CheckImageBytes = table.Column<byte[]>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PaymentAmount = table.Column<double>(nullable: false),
                    PaymentPaidBy = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasePaymentHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchasePaymentHistory_AccountList_AccountListID",
                        column: x => x.AccountListID,
                        principalTable: "AccountList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchasePaymentHistory_Purchase_PurchaseID",
                        column: x => x.PurchaseID,
                        principalTable: "Purchase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClientDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    LoginName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    SocialCommunicationURL = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    BoxNumber = table.Column<string>(nullable: true),
                    PopDetails = table.Column<string>(nullable: true),
                    RequireCable = table.Column<string>(nullable: true),
                    Reference = table.Column<string>(nullable: true),
                    NationalID = table.Column<string>(nullable: true),
                    ConnectionFeesProvidedDate = table.Column<DateTime>(nullable: true),
                    ClientSurvey = table.Column<string>(nullable: true),
                    ConnectionDate = table.Column<DateTime>(nullable: true),
                    ClientPriority = table.Column<int>(nullable: true),
                    MacAddress = table.Column<string>(nullable: true),
                    SMSCommunication = table.Column<string>(nullable: true),
                    IsNewClient = table.Column<int>(nullable: true),
                    NewClientRequestDate = table.Column<DateTime>(nullable: true),
                    NewClientApproximateConnectionStartDate = table.Column<DateTime>(nullable: true),
                    ZoneID = table.Column<int>(nullable: true),
                    ConnectionTypeID = table.Column<int>(nullable: true),
                    CableTypeID = table.Column<int>(nullable: true),
                    PackageID = table.Column<int>(nullable: true),
                    SecurityQuestionID = table.Column<int>(nullable: true),
                    SecurityQuestionAnswer = table.Column<string>(nullable: true),
                    EmployeeID = table.Column<int>(nullable: true),
                    RoleID = table.Column<int>(nullable: true),
                    UserRightPermissionID = table.Column<int>(nullable: true),
                    MikrotikID = table.Column<int>(nullable: true),
                    IP = table.Column<string>(nullable: true),
                    Mac = table.Column<string>(nullable: true),
                    ResellerID = table.Column<int>(nullable: true),
                    IsPriorityClient = table.Column<bool>(nullable: false),
                    ApproxPaymentDate = table.Column<int>(nullable: false),
                    ProfileUpdatePercentage = table.Column<double>(nullable: false),
                    StatusThisMonth = table.Column<int>(nullable: false),
                    StatusNextMonth = table.Column<int>(nullable: false),
                    LineStatusWillActiveInThisDate = table.Column<DateTime>(nullable: false),
                    ClientOwnImageBytes = table.Column<byte[]>(nullable: true),
                    ClientOwnImageBytesPaths = table.Column<string>(nullable: true),
                    ClientNIDImageBytes = table.Column<byte[]>(nullable: true),
                    ClientNIDImageBytesPaths = table.Column<string>(nullable: true),
                    PackageThisMonth = table.Column<int>(nullable: false),
                    PackageNextMonth = table.Column<int>(nullable: false),
                    NextApproxPaymentFullDate = table.Column<DateTime>(nullable: true),
                    RunningCycle = table.Column<string>(nullable: true),
                    ClientLineStatusID = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    PermanentDiscount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientDetails_CableType_CableTypeID",
                        column: x => x.CableTypeID,
                        principalTable: "CableType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientDetails_ClientLineStatus_ClientLineStatusID",
                        column: x => x.ClientLineStatusID,
                        principalTable: "ClientLineStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientDetails_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientDetails_Mikrotik_MikrotikID",
                        column: x => x.MikrotikID,
                        principalTable: "Mikrotik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientDetails_Package_PackageID",
                        column: x => x.PackageID,
                        principalTable: "Package",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientDetails_Reseller_ResellerID",
                        column: x => x.ResellerID,
                        principalTable: "Reseller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientDetails_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientDetails_SecurityQuestion_SecurityQuestionID",
                        column: x => x.SecurityQuestionID,
                        principalTable: "SecurityQuestion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientDetails_UserRightPermission_UserRightPermissionID",
                        column: x => x.UserRightPermissionID,
                        principalTable: "UserRightPermission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientDetails_Zone_ZoneID",
                        column: x => x.ZoneID,
                        principalTable: "Zone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdvancePayment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    ClientDetailsID = table.Column<int>(nullable: false),
                    AdvanceAmount = table.Column<double>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CollectBy = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancePayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvancePayment_ClientDetails_ClientDetailsID",
                        column: x => x.ClientDetailsID,
                        principalTable: "ClientDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CableDistribution",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    ClientDetailsID = table.Column<int>(nullable: true),
                    EmployeeID = table.Column<int>(nullable: true),
                    CableForEmployeeID = table.Column<int>(nullable: true),
                    CableStockID = table.Column<int>(nullable: false),
                    AmountOfCableUsed = table.Column<int>(nullable: false),
                    Purpose = table.Column<string>(nullable: true),
                    CableAssignFromWhere = table.Column<int>(nullable: false),
                    CableIndicatorStatus = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CableDistribution", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CableDistribution_CableStock_CableStockID",
                        column: x => x.CableStockID,
                        principalTable: "CableStock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CableDistribution_ClientDetails_ClientDetailsID",
                        column: x => x.ClientDetailsID,
                        principalTable: "ClientDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CableDistribution_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClientDueBills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    ClientDetailsID = table.Column<int>(nullable: false),
                    DueAmount = table.Column<double>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Month = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientDueBills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientDueBills_ClientDetails_ClientDetailsID",
                        column: x => x.ClientDetailsID,
                        principalTable: "ClientDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Complain",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    ClientDetailsID = table.Column<int>(nullable: false),
                    TokenNo = table.Column<int>(nullable: false),
                    MonthlySerialNo = table.Column<string>(nullable: true),
                    ComplainDetails = table.Column<string>(nullable: true),
                    EmployeeID = table.Column<int>(nullable: true),
                    ResellerID = table.Column<int>(nullable: true),
                    LineStatusID = table.Column<int>(nullable: false),
                    ComplainTypeID = table.Column<int>(nullable: false),
                    WhichOrWhere = table.Column<string>(nullable: true),
                    ComplainOpenBy = table.Column<int>(nullable: false),
                    ComplainTime = table.Column<DateTime>(nullable: false),
                    OnRequest = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Complain_ClientDetails_ClientDetailsID",
                        column: x => x.ClientDetailsID,
                        principalTable: "ClientDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Complain_ComplainType_ComplainTypeID",
                        column: x => x.ComplainTypeID,
                        principalTable: "ComplainType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Complain_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Complain_LineStatus_LineStatusID",
                        column: x => x.LineStatusID,
                        principalTable: "LineStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Complain_Reseller_ResellerID",
                        column: x => x.ResellerID,
                        principalTable: "Reseller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Distribution",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: false),
                    StockDetailsID = table.Column<int>(nullable: false),
                    PopID = table.Column<int>(nullable: true),
                    BoxID = table.Column<int>(nullable: true),
                    ClientDetailsID = table.Column<int>(nullable: true),
                    DistributionReasonID = table.Column<int>(nullable: true),
                    IndicatorStatus = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribution", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Distribution_Box_BoxID",
                        column: x => x.BoxID,
                        principalTable: "Box",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Distribution_ClientDetails_ClientDetailsID",
                        column: x => x.ClientDetailsID,
                        principalTable: "ClientDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Distribution_DistributionReason_DistributionReasonID",
                        column: x => x.DistributionReasonID,
                        principalTable: "DistributionReason",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Distribution_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Distribution_Pop_PopID",
                        column: x => x.PopID,
                        principalTable: "Pop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Distribution_StockDetails_StockDetailsID",
                        column: x => x.StockDetailsID,
                        principalTable: "StockDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MacResellerVSUserPaymentDeductionDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    ClientDetailsID = table.Column<int>(nullable: false),
                    ResellerID = table.Column<int>(nullable: false),
                    PaymentYear = table.Column<int>(nullable: false),
                    PaymentMonth = table.Column<int>(nullable: false),
                    PaymentAmount = table.Column<double>(nullable: false),
                    PaymentTime = table.Column<DateTime>(nullable: false),
                    PaymentTimeResellerBalance = table.Column<double>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MacResellerVSUserPaymentDeductionDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MacResellerVSUserPaymentDeductionDetails_ClientDetails_ClientDetailsID",
                        column: x => x.ClientDetailsID,
                        principalTable: "ClientDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MacResellerVSUserPaymentDeductionDetails_Reseller_ResellerID",
                        column: x => x.ResellerID,
                        principalTable: "Reseller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    ClientDetailsID = table.Column<int>(nullable: false),
                    PaymentTransaction = table.Column<int>(nullable: false),
                    PaymentMonth = table.Column<int>(nullable: false),
                    PackageID = table.Column<int>(nullable: true),
                    PaymentTypeID = table.Column<int>(nullable: false),
                    PaymentFrom = table.Column<int>(nullable: true),
                    PaymentAmount = table.Column<float>(nullable: true),
                    ResellerPaymentAmount = table.Column<float>(nullable: true),
                    PackagePriceForResellerByAdminDuringCreateOrUpdate = table.Column<float>(nullable: true),
                    PackagePriceForResellerUserByResellerDuringCreateOrUpdate = table.Column<float>(nullable: true),
                    PaidAmount = table.Column<float>(nullable: true),
                    DueAmount = table.Column<float>(nullable: true),
                    PaymentStatus = table.Column<int>(nullable: false),
                    Discount = table.Column<float>(nullable: true),
                    WhoGenerateTheBill = table.Column<int>(nullable: true),
                    EmployeeID = table.Column<int>(nullable: true),
                    BillCollectBy = table.Column<int>(nullable: true),
                    RemarksNo = table.Column<string>(nullable: true),
                    ResetNo = table.Column<string>(nullable: true),
                    PaymentDate = table.Column<DateTime>(nullable: true),
                    LineStatusID = table.Column<int>(nullable: true),
                    AmountCountDate = table.Column<DateTime>(nullable: true),
                    IsNewClient = table.Column<int>(nullable: false),
                    ChangePackageHowMuchTimes = table.Column<int>(nullable: false),
                    ForWhichSignUpBills = table.Column<int>(nullable: true),
                    PaymentFromWhichPage = table.Column<string>(nullable: true),
                    ResellerID = table.Column<int>(nullable: true),
                    PaymentGenerateUptoWhichDate = table.Column<DateTime>(nullable: true),
                    TransactionForWhichCycle = table.Column<string>(nullable: true),
                    PermanentDiscount = table.Column<double>(nullable: false),
                    AnotherMobileNo = table.Column<string>(nullable: true),
                    PaymentBy = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transaction_ClientDetails_ClientDetailsID",
                        column: x => x.ClientDetailsID,
                        principalTable: "ClientDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transaction_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transaction_LineStatus_LineStatusID",
                        column: x => x.LineStatusID,
                        principalTable: "LineStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transaction_Package_PackageID",
                        column: x => x.PackageID,
                        principalTable: "Package",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transaction_PaymentType_PaymentTypeID",
                        column: x => x.PaymentTypeID,
                        principalTable: "PaymentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transaction_Reseller_ResellerID",
                        column: x => x.ResellerID,
                        principalTable: "Reseller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recovery",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: false),
                    DistributionReasonID = table.Column<int>(nullable: false),
                    DistributionID = table.Column<int>(nullable: false),
                    StockDetailsID = table.Column<int>(nullable: false),
                    PopID = table.Column<int>(nullable: true),
                    BoxID = table.Column<int>(nullable: true),
                    ClientDetailsID = table.Column<int>(nullable: true),
                    RecoveryDate = table.Column<DateTime>(nullable: false),
                    IndicatorStatus = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recovery", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recovery_Box_BoxID",
                        column: x => x.BoxID,
                        principalTable: "Box",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recovery_ClientDetails_ClientDetailsID",
                        column: x => x.ClientDetailsID,
                        principalTable: "ClientDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recovery_Distribution_DistributionID",
                        column: x => x.DistributionID,
                        principalTable: "Distribution",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recovery_DistributionReason_DistributionReasonID",
                        column: x => x.DistributionReasonID,
                        principalTable: "DistributionReason",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recovery_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recovery_Pop_PopID",
                        column: x => x.PopID,
                        principalTable: "Pop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recovery_StockDetails_StockDetailsID",
                        column: x => x.StockDetailsID,
                        principalTable: "StockDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTransactionLockUnlock",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    TransactionID = table.Column<int>(nullable: false),
                    PackageID = table.Column<int>(nullable: true),
                    Amount = table.Column<double>(nullable: false),
                    AmountForReseller = table.Column<double>(nullable: false),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    LockOrUnlockDate = table.Column<DateTime>(nullable: true),
                    EmployeeID = table.Column<int>(nullable: true),
                    ResellerID = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTransactionLockUnlock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeTransactionLockUnlock_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeTransactionLockUnlock_Package_PackageID",
                        column: x => x.PackageID,
                        principalTable: "Package",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeTransactionLockUnlock_Reseller_ResellerID",
                        column: x => x.ResellerID,
                        principalTable: "Reseller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeTransactionLockUnlock_Transaction_TransactionID",
                        column: x => x.TransactionID,
                        principalTable: "Transaction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PayementHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    TransactionID = table.Column<int>(nullable: true),
                    ClientDetailsID = table.Column<int>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: true),
                    ResellerID = table.Column<int>(nullable: true),
                    CollectByID = table.Column<int>(nullable: false),
                    PaymentDate = table.Column<DateTime>(nullable: false),
                    PaidAmount = table.Column<float>(nullable: false),
                    ResetNo = table.Column<string>(nullable: true),
                    AdvancePaymentID = table.Column<int>(nullable: true),
                    PaymentByID = table.Column<int>(nullable: true),
                    NormalPayment = table.Column<int>(nullable: true),
                    DiscountPayment = table.Column<int>(nullable: true),
                    PaymentFromWhichPage = table.Column<string>(nullable: true),
                    BillAcceptBy = table.Column<int>(nullable: false),
                    AcceptStatus = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayementHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayementHistory_AdvancePayment_AdvancePaymentID",
                        column: x => x.AdvancePaymentID,
                        principalTable: "AdvancePayment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PayementHistory_ClientDetails_ClientDetailsID",
                        column: x => x.ClientDetailsID,
                        principalTable: "ClientDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PayementHistory_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PayementHistory_PaymentBy_PaymentByID",
                        column: x => x.PaymentByID,
                        principalTable: "PaymentBy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PayementHistory_Reseller_ResellerID",
                        column: x => x.ResellerID,
                        principalTable: "Reseller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PayementHistory_Transaction_TransactionID",
                        column: x => x.TransactionID,
                        principalTable: "Transaction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountList_AccountOwnerId",
                table: "AccountList",
                column: "AccountOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountListVsAmmountTransfer_PaymentByID",
                table: "AccountListVsAmmountTransfer",
                column: "PaymentByID");

            migrationBuilder.CreateIndex(
                name: "IX_ActionList_FormID",
                table: "ActionList",
                column: "FormID");

            migrationBuilder.CreateIndex(
                name: "IX_ActionNameAuthentication_FormNameForAuthId",
                table: "ActionNameAuthentication",
                column: "FormNameForAuthId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancePayment_ClientDetailsID",
                table: "AdvancePayment",
                column: "ClientDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_AssetTypeID",
                table: "Asset",
                column: "AssetTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Box_ResellerID",
                table: "Box",
                column: "ResellerID");

            migrationBuilder.CreateIndex(
                name: "IX_CableDistribution_CableStockID",
                table: "CableDistribution",
                column: "CableStockID");

            migrationBuilder.CreateIndex(
                name: "IX_CableDistribution_ClientDetailsID",
                table: "CableDistribution",
                column: "ClientDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_CableDistribution_EmployeeID",
                table: "CableDistribution",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_CableStock_BrandID",
                table: "CableStock",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_CableStock_CableTypeID",
                table: "CableStock",
                column: "CableTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CableStock_CableUnitID",
                table: "CableStock",
                column: "CableUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_CableStock_EmployeeID",
                table: "CableStock",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_CableStock_SupplierID",
                table: "CableStock",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDetails_CableTypeID",
                table: "ClientDetails",
                column: "CableTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDetails_ClientLineStatusID",
                table: "ClientDetails",
                column: "ClientLineStatusID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClientDetails_EmployeeID",
                table: "ClientDetails",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDetails_MikrotikID",
                table: "ClientDetails",
                column: "MikrotikID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDetails_PackageID",
                table: "ClientDetails",
                column: "PackageID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDetails_ResellerID",
                table: "ClientDetails",
                column: "ResellerID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDetails_RoleID",
                table: "ClientDetails",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDetails_SecurityQuestionID",
                table: "ClientDetails",
                column: "SecurityQuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDetails_UserRightPermissionID",
                table: "ClientDetails",
                column: "UserRightPermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDetails_ZoneID",
                table: "ClientDetails",
                column: "ZoneID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDueBills_ClientDetailsID",
                table: "ClientDueBills",
                column: "ClientDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientLineStatus_EmployeeID",
                table: "ClientLineStatus",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientLineStatus_LineStatusID",
                table: "ClientLineStatus",
                column: "LineStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientLineStatus_MikrotikID",
                table: "ClientLineStatus",
                column: "MikrotikID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientLineStatus_PackageID",
                table: "ClientLineStatus",
                column: "PackageID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientLineStatus_ResellerID",
                table: "ClientLineStatus",
                column: "ResellerID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyVsPayer_CompanyID",
                table: "CompanyVsPayer",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Complain_ClientDetailsID",
                table: "Complain",
                column: "ClientDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_Complain_ComplainTypeID",
                table: "Complain",
                column: "ComplainTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Complain_EmployeeID",
                table: "Complain",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Complain_LineStatusID",
                table: "Complain",
                column: "LineStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Complain_ResellerID",
                table: "Complain",
                column: "ResellerID");

            migrationBuilder.CreateIndex(
                name: "IX_Deposit_AccountListID",
                table: "Deposit",
                column: "AccountListID");

            migrationBuilder.CreateIndex(
                name: "IX_Deposit_CompanyID",
                table: "Deposit",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Deposit_CompanyVSPayerId",
                table: "Deposit",
                column: "CompanyVSPayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Deposit_HeadID",
                table: "Deposit",
                column: "HeadID");

            migrationBuilder.CreateIndex(
                name: "IX_Deposit_PaymentByID",
                table: "Deposit",
                column: "PaymentByID");

            migrationBuilder.CreateIndex(
                name: "IX_Deposit_ResellerID",
                table: "Deposit",
                column: "ResellerID");

            migrationBuilder.CreateIndex(
                name: "IX_DirectProductSectionChangeFromWorkingToOthers_StockDetailsID",
                table: "DirectProductSectionChangeFromWorkingToOthers",
                column: "StockDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_Distribution_BoxID",
                table: "Distribution",
                column: "BoxID");

            migrationBuilder.CreateIndex(
                name: "IX_Distribution_ClientDetailsID",
                table: "Distribution",
                column: "ClientDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_Distribution_DistributionReasonID",
                table: "Distribution",
                column: "DistributionReasonID");

            migrationBuilder.CreateIndex(
                name: "IX_Distribution_EmployeeID",
                table: "Distribution",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Distribution_PopID",
                table: "Distribution",
                column: "PopID");

            migrationBuilder.CreateIndex(
                name: "IX_Distribution_StockDetailsID",
                table: "Distribution",
                column: "StockDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentID",
                table: "Employee",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DutyShiftID",
                table: "Employee",
                column: "DutyShiftID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmployeesId",
                table: "Employee",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ResellerID",
                table: "Employee",
                column: "ResellerID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_RoleID",
                table: "Employee",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_UserRightPermissionID",
                table: "Employee",
                column: "UserRightPermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaveHistory_EmployeeID",
                table: "EmployeeLeaveHistory",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaveHistory_LeaveSalaryTypeID",
                table: "EmployeeLeaveHistory",
                column: "LeaveSalaryTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTransactionLockUnlock_EmployeeID",
                table: "EmployeeTransactionLockUnlock",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTransactionLockUnlock_PackageID",
                table: "EmployeeTransactionLockUnlock",
                column: "PackageID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTransactionLockUnlock_ResellerID",
                table: "EmployeeTransactionLockUnlock",
                column: "ResellerID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTransactionLockUnlock_TransactionID",
                table: "EmployeeTransactionLockUnlock",
                column: "TransactionID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeVsWorkSchedules_DayID",
                table: "EmployeeVsWorkSchedules",
                column: "DayID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeVsWorkSchedules_EmployeeID",
                table: "EmployeeVsWorkSchedules",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Expense_AccountListID",
                table: "Expense",
                column: "AccountListID");

            migrationBuilder.CreateIndex(
                name: "IX_Expense_CompanyID",
                table: "Expense",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Expense_CompanyVSPayerId",
                table: "Expense",
                column: "CompanyVSPayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Expense_HeadID",
                table: "Expense",
                column: "HeadID");

            migrationBuilder.CreateIndex(
                name: "IX_Expense_PaymentByID",
                table: "Expense",
                column: "PaymentByID");

            migrationBuilder.CreateIndex(
                name: "IX_Expense_ResellerID",
                table: "Expense",
                column: "ResellerID");

            migrationBuilder.CreateIndex(
                name: "IX_Form_ControllerNameID",
                table: "Form",
                column: "ControllerNameID");

            migrationBuilder.CreateIndex(
                name: "IX_Head_ResellerID",
                table: "Head",
                column: "ResellerID");

            migrationBuilder.CreateIndex(
                name: "IX_MacResellerVSUserPaymentDeductionDetails_ClientDetailsID",
                table: "MacResellerVSUserPaymentDeductionDetails",
                column: "ClientDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_MacResellerVSUserPaymentDeductionDetails_ResellerID",
                table: "MacResellerVSUserPaymentDeductionDetails",
                column: "ResellerID");

            migrationBuilder.CreateIndex(
                name: "IX_Package_IPPoolID",
                table: "Package",
                column: "IPPoolID");

            migrationBuilder.CreateIndex(
                name: "IX_Package_MikrotikID",
                table: "Package",
                column: "MikrotikID");

            migrationBuilder.CreateIndex(
                name: "IX_PayementHistory_AdvancePaymentID",
                table: "PayementHistory",
                column: "AdvancePaymentID");

            migrationBuilder.CreateIndex(
                name: "IX_PayementHistory_ClientDetailsID",
                table: "PayementHistory",
                column: "ClientDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_PayementHistory_EmployeeID",
                table: "PayementHistory",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_PayementHistory_PaymentByID",
                table: "PayementHistory",
                column: "PaymentByID");

            migrationBuilder.CreateIndex(
                name: "IX_PayementHistory_ResellerID",
                table: "PayementHistory",
                column: "ResellerID");

            migrationBuilder.CreateIndex(
                name: "IX_PayementHistory_TransactionID",
                table: "PayementHistory",
                column: "TransactionID");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_ResellerID",
                table: "Purchase",
                column: "ResellerID");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_SupplierID",
                table: "Purchase",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseDetails_ItemID",
                table: "PurchaseDetails",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseDetails_PurchaseID",
                table: "PurchaseDetails",
                column: "PurchaseID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasePaymentHistory_AccountListID",
                table: "PurchasePaymentHistory",
                column: "AccountListID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasePaymentHistory_PurchaseID",
                table: "PurchasePaymentHistory",
                column: "PurchaseID");

            migrationBuilder.CreateIndex(
                name: "IX_Recovery_BoxID",
                table: "Recovery",
                column: "BoxID");

            migrationBuilder.CreateIndex(
                name: "IX_Recovery_ClientDetailsID",
                table: "Recovery",
                column: "ClientDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_Recovery_DistributionID",
                table: "Recovery",
                column: "DistributionID");

            migrationBuilder.CreateIndex(
                name: "IX_Recovery_DistributionReasonID",
                table: "Recovery",
                column: "DistributionReasonID");

            migrationBuilder.CreateIndex(
                name: "IX_Recovery_EmployeeID",
                table: "Recovery",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Recovery_PopID",
                table: "Recovery",
                column: "PopID");

            migrationBuilder.CreateIndex(
                name: "IX_Recovery_StockDetailsID",
                table: "Recovery",
                column: "StockDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_Reseller_RoleID",
                table: "Reseller",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Reseller_UserRightPermissionID",
                table: "Reseller",
                column: "UserRightPermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_ResellerPaymentDetailsHistory_PaymentByID",
                table: "ResellerPaymentDetailsHistory",
                column: "PaymentByID");

            migrationBuilder.CreateIndex(
                name: "IX_ResellerPaymentDetailsHistory_ResellerID",
                table: "ResellerPaymentDetailsHistory",
                column: "ResellerID");

            migrationBuilder.CreateIndex(
                name: "IX_ResellerVsPackageHistory_ResellerID",
                table: "ResellerVsPackageHistory",
                column: "ResellerID");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_ItemID",
                table: "Stock",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_StockDetails_BrandID",
                table: "StockDetails",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_StockDetails_ProductStatusID",
                table: "StockDetails",
                column: "ProductStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_StockDetails_SectionID",
                table: "StockDetails",
                column: "SectionID");

            migrationBuilder.CreateIndex(
                name: "IX_StockDetails_StockID",
                table: "StockDetails",
                column: "StockID");

            migrationBuilder.CreateIndex(
                name: "IX_StockDetails_SupplierID",
                table: "StockDetails",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_ClientDetailsID",
                table: "Transaction",
                column: "ClientDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_EmployeeID",
                table: "Transaction",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_LineStatusID",
                table: "Transaction",
                column: "LineStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_PackageID",
                table: "Transaction",
                column: "PackageID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_PaymentTypeID",
                table: "Transaction",
                column: "PaymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_ResellerID",
                table: "Transaction",
                column: "ResellerID");

            migrationBuilder.CreateIndex(
                name: "IX_Zone_ResellerID",
                table: "Zone",
                column: "ResellerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountingHistory");

            migrationBuilder.DropTable(
                name: "AccountListVsAmmountTransfer");

            migrationBuilder.DropTable(
                name: "ActionList");

            migrationBuilder.DropTable(
                name: "ActionNameAuthentication");

            migrationBuilder.DropTable(
                name: "Asset");

            migrationBuilder.DropTable(
                name: "AttendanceType");

            migrationBuilder.DropTable(
                name: "AuthorViewModel");

            migrationBuilder.DropTable(
                name: "BandwithResellerGivenItem");

            migrationBuilder.DropTable(
                name: "BillGenerateHistory");

            migrationBuilder.DropTable(
                name: "CableDistribution");

            migrationBuilder.DropTable(
                name: "Client_Stock_StockDetails");

            migrationBuilder.DropTable(
                name: "Client_Stock_StockDetails_ForDistribution");

            migrationBuilder.DropTable(
                name: "ClientCableAssign");

            migrationBuilder.DropTable(
                name: "ClientCableDistribution");

            migrationBuilder.DropTable(
                name: "ClientDueBills");

            migrationBuilder.DropTable(
                name: "ClientStockAssign");

            migrationBuilder.DropTable(
                name: "Complain");

            migrationBuilder.DropTable(
                name: "ConnectionType");

            migrationBuilder.DropTable(
                name: "Deposit");

            migrationBuilder.DropTable(
                name: "DirectProductSectionChangeFromWorkingToOthers");

            migrationBuilder.DropTable(
                name: "Distribution_Transaction");

            migrationBuilder.DropTable(
                name: "EmployeeLeaveHistory");

            migrationBuilder.DropTable(
                name: "EmployeeTransactionLockUnlock");

            migrationBuilder.DropTable(
                name: "EmployeeVsWorkSchedules");

            migrationBuilder.DropTable(
                name: "Expense");

            migrationBuilder.DropTable(
                name: "GivenPaymentType");

            migrationBuilder.DropTable(
                name: "ISPAccessList");

            migrationBuilder.DropTable(
                name: "LoginViewModel");

            migrationBuilder.DropTable(
                name: "MacResellerVSUserPaymentDeductionDetails");

            migrationBuilder.DropTable(
                name: "MeasurementUnit");

            migrationBuilder.DropTable(
                name: "Month");

            migrationBuilder.DropTable(
                name: "OptionSetting");

            migrationBuilder.DropTable(
                name: "PayementHistory");

            migrationBuilder.DropTable(
                name: "PaymentFrom");

            migrationBuilder.DropTable(
                name: "ProfilePercentageFields");

            migrationBuilder.DropTable(
                name: "PurchaseDetails");

            migrationBuilder.DropTable(
                name: "PurchasePaymentHistory");

            migrationBuilder.DropTable(
                name: "Recovery");

            migrationBuilder.DropTable(
                name: "ResellerBillingCycle");

            migrationBuilder.DropTable(
                name: "ResellerPaymentDetailsHistory");

            migrationBuilder.DropTable(
                name: "ResellerVsPackageHistory");

            migrationBuilder.DropTable(
                name: "SMS");

            migrationBuilder.DropTable(
                name: "SMSSenderIDPass");

            migrationBuilder.DropTable(
                name: "TimePeriodForSignal");

            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.DropTable(
                name: "VendorType");

            migrationBuilder.DropTable(
                name: "Year");

            migrationBuilder.DropTable(
                name: "Form");

            migrationBuilder.DropTable(
                name: "FormNameForAuth");

            migrationBuilder.DropTable(
                name: "AssetType");

            migrationBuilder.DropTable(
                name: "CableStock");

            migrationBuilder.DropTable(
                name: "ComplainType");

            migrationBuilder.DropTable(
                name: "LeaveSalaryType");

            migrationBuilder.DropTable(
                name: "Day");

            migrationBuilder.DropTable(
                name: "CompanyVsPayer");

            migrationBuilder.DropTable(
                name: "Head");

            migrationBuilder.DropTable(
                name: "AdvancePayment");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "AccountList");

            migrationBuilder.DropTable(
                name: "Purchase");

            migrationBuilder.DropTable(
                name: "Distribution");

            migrationBuilder.DropTable(
                name: "PaymentBy");

            migrationBuilder.DropTable(
                name: "ControllerName");

            migrationBuilder.DropTable(
                name: "CableUnit");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "PaymentType");

            migrationBuilder.DropTable(
                name: "AccountOwner");

            migrationBuilder.DropTable(
                name: "Box");

            migrationBuilder.DropTable(
                name: "ClientDetails");

            migrationBuilder.DropTable(
                name: "DistributionReason");

            migrationBuilder.DropTable(
                name: "Pop");

            migrationBuilder.DropTable(
                name: "StockDetails");

            migrationBuilder.DropTable(
                name: "CableType");

            migrationBuilder.DropTable(
                name: "ClientLineStatus");

            migrationBuilder.DropTable(
                name: "SecurityQuestion");

            migrationBuilder.DropTable(
                name: "Zone");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "ProductStatus");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "LineStatus");

            migrationBuilder.DropTable(
                name: "Package");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "DutyShift");

            migrationBuilder.DropTable(
                name: "Reseller");

            migrationBuilder.DropTable(
                name: "IPPool");

            migrationBuilder.DropTable(
                name: "Mikrotik");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "UserRightPermission");
        }
    }
}
