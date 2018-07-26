using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BadgerData.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountType",
                columns: table => new
                {
                    AccountTypeID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AccountTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountType", x => x.AccountTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Claim",
                columns: table => new
                {
                    ClaimID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PurchaseOrderID = table.Column<int>(nullable: true),
                    SupplierOrder = table.Column<string>(nullable: true),
                    ClaimDate = table.Column<DateTime>(nullable: true),
                    EmployeeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claim", x => x.ClaimID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    DocumentID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    DocumentPath = table.Column<string>(nullable: true),
                    DocumentView = table.Column<string>(nullable: true),
                    PartID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.DocumentID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Firstname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    Middlename = table.Column<string>(nullable: true),
                    IsPurchaser = table.Column<bool>(nullable: true),
                    EmployeeEmail = table.Column<string>(nullable: true),
                    Show = table.Column<bool>(nullable: true),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Role = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "Finish",
                columns: table => new
                {
                    FinishID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FinishName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finish", x => x.FinishID);
                });

            migrationBuilder.CreateTable(
                name: "Globals",
                columns: table => new
                {
                    GiD = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ElementName = table.Column<string>(nullable: true),
                    Data = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Globals", x => x.GiD);
                });

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    job_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    jobname = table.Column<string>(nullable: true),
                    jobnumber = table.Column<int>(nullable: true),
                    jobdesc = table.Column<string>(nullable: true),
                    Retired = table.Column<bool>(nullable: true),
                    Visible = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.job_id);
                });

            migrationBuilder.CreateTable(
                name: "Manu",
                columns: table => new
                {
                    ManuID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Manufacturer = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    WebAddress = table.Column<string>(nullable: true),
                    ManuCategoryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manu", x => x.ManuID);
                });

            migrationBuilder.CreateTable(
                name: "OrderReceipt",
                columns: table => new
                {
                    OrderReceiptID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmployeeID = table.Column<int>(nullable: true),
                    JobID = table.Column<int>(nullable: true),
                    PurchaseOrderID = table.Column<int>(nullable: true),
                    ReceiptDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderReceipt", x => x.OrderReceiptID);
                });

            migrationBuilder.CreateTable(
                name: "PartClass",
                columns: table => new
                {
                    PartClassID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartClass", x => x.PartClassID);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ProjectID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    JobID = table.Column<int>(nullable: true),
                    ProjectName = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    IsContracted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ProjectID);
                });

            migrationBuilder.CreateTable(
                name: "Requisition",
                columns: table => new
                {
                    RequisitionID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    JobID = table.Column<int>(nullable: true),
                    EmployeeID = table.Column<int>(nullable: true),
                    RequisitionDate = table.Column<DateTime>(nullable: true),
                    RequisitionTotal = table.Column<decimal>(nullable: true),
                    Submitted = table.Column<bool>(nullable: true),
                    RequisitionSubmittedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requisition", x => x.RequisitionID);
                });

            migrationBuilder.CreateTable(
                name: "ShipBy",
                columns: table => new
                {
                    ShipID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ShipByName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipBy", x => x.ShipID);
                });

            migrationBuilder.CreateTable(
                name: "SubAssembly",
                columns: table => new
                {
                    SubAssemblyID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductID = table.Column<int>(nullable: false),
                    SubAssemblyName = table.Column<string>(nullable: true),
                    MakeFile = table.Column<string>(nullable: true),
                    W = table.Column<decimal>(nullable: false),
                    H = table.Column<decimal>(nullable: false),
                    D = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubAssembly", x => x.SubAssemblyID);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    SupplierID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SupplierName = table.Column<string>(nullable: true),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    Category = table.Column<int>(nullable: true),
                    AccountType = table.Column<int>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    TaskID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TaskName = table.Column<string>(nullable: true),
                    TaskDescription = table.Column<string>(nullable: true),
                    TaskType = table.Column<int>(nullable: true),
                    Rate = table.Column<decimal>(nullable: true),
                    MarkUp = table.Column<decimal>(nullable: true),
                    WorkCenter = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.TaskID);
                });

            migrationBuilder.CreateTable(
                name: "TransActionType",
                columns: table => new
                {
                    TransactionsTypeID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TransactionTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransActionType", x => x.TransactionsTypeID);
                });

            migrationBuilder.CreateTable(
                name: "UnitOfMeasure",
                columns: table => new
                {
                    UnitOfMeasureID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UnitOfMeasureName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitOfMeasure", x => x.UnitOfMeasureID);
                });

            migrationBuilder.CreateTable(
                name: "WorkCenter",
                columns: table => new
                {
                    WorkCenterID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WorkCenterName = table.Column<string>(nullable: true),
                    CostRate = table.Column<decimal>(nullable: true),
                    Availability = table.Column<decimal>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkCenter", x => x.WorkCenterID);
                });

            migrationBuilder.CreateTable(
                name: "WorkOrder",
                columns: table => new
                {
                    WorkOrderID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProjectID = table.Column<int>(nullable: true),
                    ProductID = table.Column<int>(nullable: true),
                    WorkOrderDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrder", x => x.WorkOrderID);
                });

            migrationBuilder.CreateTable(
                name: "WorkOrderRouting",
                columns: table => new
                {
                    WorkOrderID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    OperationSequence = table.Column<int>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: true),
                    TaskID = table.Column<int>(nullable: true),
                    LocationID = table.Column<int>(nullable: true),
                    ScheduledStartDate = table.Column<DateTime>(nullable: true),
                    ScheduledEndDate = table.Column<DateTime>(nullable: true),
                    ActualStartDate = table.Column<DateTime>(nullable: true),
                    ActualEndDate = table.Column<DateTime>(nullable: true),
                    PlannedCost = table.Column<decimal>(nullable: true),
                    ActualCost = table.Column<decimal>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrderRouting", x => new { x.WorkOrderID, x.ProductID, x.OperationSequence });
                });

            migrationBuilder.CreateTable(
                name: "ClaimItem",
                columns: table => new
                {
                    ClaimItemID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClaimID = table.Column<int>(nullable: false),
                    LineID = table.Column<int>(nullable: true),
                    PartID = table.Column<int>(nullable: true),
                    Bcode = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TransActionTypeID = table.Column<int>(nullable: true),
                    ProductID = table.Column<int>(nullable: true),
                    DefectDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaimItem", x => x.ClaimItemID);
                    table.ForeignKey(
                        name: "FK_ClaimItem_Claim_ClaimID",
                        column: x => x.ClaimID,
                        principalTable: "Claim",
                        principalColumn: "ClaimID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    StockTransactionID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LineID = table.Column<int>(nullable: true),
                    PartID = table.Column<int>(nullable: true),
                    JobID = table.Column<int>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    ProductID = table.Column<int>(nullable: true),
                    DateStamp = table.Column<DateTime>(nullable: true),
                    Qnty = table.Column<decimal>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UnitOfMeasure = table.Column<int>(nullable: true),
                    TransActionType = table.Column<int>(nullable: true),
                    TransActionReference = table.Column<int>(nullable: true),
                    OrderReceiptID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.StockTransactionID);
                    table.ForeignKey(
                        name: "FK_Inventory_OrderReceipt_OrderReceiptID",
                        column: x => x.OrderReceiptID,
                        principalTable: "OrderReceipt",
                        principalColumn: "OrderReceiptID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true),
                    PartClassID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                    table.ForeignKey(
                        name: "FK_Categories_PartClass_PartClassID",
                        column: x => x.PartClassID,
                        principalTable: "PartClass",
                        principalColumn: "PartClassID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductName = table.Column<string>(nullable: true),
                    ProductionDate = table.Column<DateTime>(nullable: true),
                    ProjectID = table.Column<int>(nullable: true),
                    Width = table.Column<decimal>(nullable: true),
                    Height = table.Column<decimal>(nullable: true),
                    Depth = table.Column<decimal>(nullable: true),
                    ArchRef = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Omit = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Product_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RequisitionItem",
                columns: table => new
                {
                    RequisitionItemID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RequisitionlD = table.Column<int>(nullable: true),
                    PartID = table.Column<int>(nullable: true),
                    LineItemSourceID = table.Column<int>(nullable: true),
                    Qnty = table.Column<decimal>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    RequisitionID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequisitionItem", x => x.RequisitionItemID);
                    table.ForeignKey(
                        name: "FK_RequisitionItem_Requisition_RequisitionID",
                        column: x => x.RequisitionID,
                        principalTable: "Requisition",
                        principalColumn: "RequisitionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrder",
                columns: table => new
                {
                    PurchaseOrderID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderDate = table.Column<DateTime>(nullable: true),
                    Expected_Date = table.Column<DateTime>(nullable: true),
                    SupplierID = table.Column<int>(nullable: true),
                    EmployeeID = table.Column<int>(nullable: true),
                    SalesRep = table.Column<string>(nullable: true),
                    Job_id = table.Column<int>(nullable: true),
                    Taxable = table.Column<bool>(nullable: true),
                    ShipID = table.Column<int>(nullable: true),
                    OrderTotal = table.Column<decimal>(nullable: true),
                    Received = table.Column<bool>(nullable: true),
                    Shipping = table.Column<decimal>(nullable: true),
                    Tax = table.Column<decimal>(nullable: true),
                    ReceivedDate = table.Column<DateTime>(nullable: true),
                    SubTotal = table.Column<decimal>(nullable: true),
                    Memo = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    OrderFormat = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrder", x => x.PurchaseOrderID);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Job_Job_id",
                        column: x => x.Job_id,
                        principalTable: "Job",
                        principalColumn: "job_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Supplier_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Supplier",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClaimDocument",
                columns: table => new
                {
                    ClaimDocumentID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClaimItemID = table.Column<int>(nullable: false),
                    DocumentDescription = table.Column<string>(nullable: true),
                    DocumentExtension = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaimDocument", x => x.ClaimDocumentID);
                    table.ForeignKey(
                        name: "FK_ClaimDocument_ClaimItem_ClaimItemID",
                        column: x => x.ClaimItemID,
                        principalTable: "ClaimItem",
                        principalColumn: "ClaimItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartType",
                columns: table => new
                {
                    PartTypeID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Categoryid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartType", x => x.PartTypeID);
                    table.ForeignKey(
                        name: "FK_PartType_Categories_Categoryid",
                        column: x => x.Categoryid,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Attachments",
                columns: table => new
                {
                    AttachmentID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AttachmentDescription = table.Column<string>(nullable: true),
                    PurchaseOrderID = table.Column<int>(nullable: false),
                    Ext = table.Column<string>(nullable: true),
                    src = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachments", x => x.AttachmentID);
                    table.ForeignKey(
                        name: "FK_Attachments_PurchaseOrder_PurchaseOrderID",
                        column: x => x.PurchaseOrderID,
                        principalTable: "PurchaseOrder",
                        principalColumn: "PurchaseOrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseLineItem",
                columns: table => new
                {
                    LineID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PurchaseOrderID = table.Column<int>(nullable: false),
                    JobID = table.Column<int>(nullable: true),
                    PartID = table.Column<int>(nullable: true),
                    UnitCost = table.Column<decimal>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Qnty = table.Column<decimal>(nullable: true),
                    Extended = table.Column<decimal>(nullable: true),
                    Received = table.Column<bool>(nullable: true),
                    UnitOfMeasureID = table.Column<int>(nullable: true),
                    RequisitionID = table.Column<int>(nullable: true),
                    Width = table.Column<decimal>(nullable: true),
                    Length = table.Column<decimal>(nullable: true),
                    Thick = table.Column<decimal>(nullable: true),
                    Weight = table.Column<decimal>(nullable: true),
                    SupplierPartName = table.Column<string>(nullable: true),
                    BCode = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseLineItem", x => x.LineID);
                    table.ForeignKey(
                        name: "FK_PurchaseLineItem_PurchaseOrder_PurchaseOrderID",
                        column: x => x.PurchaseOrderID,
                        principalTable: "PurchaseOrder",
                        principalColumn: "PurchaseOrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Part",
                columns: table => new
                {
                    PartID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ItemName = table.Column<string>(nullable: true),
                    ItemDescription = table.Column<string>(nullable: true),
                    PartNum = table.Column<string>(nullable: true),
                    ManuID = table.Column<int>(nullable: true),
                    Obsolute = table.Column<bool>(nullable: true),
                    PartTypeID = table.Column<int>(nullable: true),
                    Cost = table.Column<decimal>(nullable: true),
                    UnitOfMeasureID = table.Column<int>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: true),
                    Waste = table.Column<decimal>(nullable: true),
                    MarkUp = table.Column<decimal>(nullable: true),
                    SupplierID = table.Column<int>(nullable: true),
                    SupplierDescription = table.Column<string>(nullable: true),
                    AddedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    UseSupplierNameFlag = table.Column<bool>(nullable: true),
                    ManuPartNum = table.Column<string>(nullable: true),
                    SKU = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Part", x => x.PartID);
                    table.ForeignKey(
                        name: "FK_Part_PartType_PartTypeID",
                        column: x => x.PartTypeID,
                        principalTable: "PartType",
                        principalColumn: "PartTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Part_Supplier_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Supplier",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Part_UnitOfMeasure_UnitOfMeasureID",
                        column: x => x.UnitOfMeasureID,
                        principalTable: "UnitOfMeasure",
                        principalColumn: "UnitOfMeasureID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DocumentParts",
                columns: table => new
                {
                    PartID = table.Column<int>(nullable: false),
                    DocumentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentParts", x => new { x.DocumentID, x.PartID });
                    table.ForeignKey(
                        name: "FK_DocumentParts_Document_DocumentID",
                        column: x => x.DocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentParts_Part_PartID",
                        column: x => x.PartID,
                        principalTable: "Part",
                        principalColumn: "PartID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_PurchaseOrderID",
                table: "Attachments",
                column: "PurchaseOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_PartClassID",
                table: "Categories",
                column: "PartClassID");

            migrationBuilder.CreateIndex(
                name: "IX_ClaimDocument_ClaimItemID",
                table: "ClaimDocument",
                column: "ClaimItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ClaimItem_ClaimID",
                table: "ClaimItem",
                column: "ClaimID");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentParts_PartID",
                table: "DocumentParts",
                column: "PartID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_OrderReceiptID",
                table: "Inventory",
                column: "OrderReceiptID");

            migrationBuilder.CreateIndex(
                name: "IX_Part_PartTypeID",
                table: "Part",
                column: "PartTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Part_SupplierID",
                table: "Part",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Part_UnitOfMeasureID",
                table: "Part",
                column: "UnitOfMeasureID");

            migrationBuilder.CreateIndex(
                name: "IX_PartType_Categoryid",
                table: "PartType",
                column: "Categoryid");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProjectID",
                table: "Product",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseLineItem_PurchaseOrderID",
                table: "PurchaseLineItem",
                column: "PurchaseOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_EmployeeID",
                table: "PurchaseOrder",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_Job_id",
                table: "PurchaseOrder",
                column: "Job_id");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_SupplierID",
                table: "PurchaseOrder",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_RequisitionItem_RequisitionID",
                table: "RequisitionItem",
                column: "RequisitionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountType");

            migrationBuilder.DropTable(
                name: "Attachments");

            migrationBuilder.DropTable(
                name: "ClaimDocument");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "DocumentParts");

            migrationBuilder.DropTable(
                name: "Finish");

            migrationBuilder.DropTable(
                name: "Globals");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "Manu");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "PurchaseLineItem");

            migrationBuilder.DropTable(
                name: "RequisitionItem");

            migrationBuilder.DropTable(
                name: "ShipBy");

            migrationBuilder.DropTable(
                name: "SubAssembly");

            migrationBuilder.DropTable(
                name: "Task");

            migrationBuilder.DropTable(
                name: "TransActionType");

            migrationBuilder.DropTable(
                name: "WorkCenter");

            migrationBuilder.DropTable(
                name: "WorkOrder");

            migrationBuilder.DropTable(
                name: "WorkOrderRouting");

            migrationBuilder.DropTable(
                name: "ClaimItem");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "Part");

            migrationBuilder.DropTable(
                name: "OrderReceipt");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "PurchaseOrder");

            migrationBuilder.DropTable(
                name: "Requisition");

            migrationBuilder.DropTable(
                name: "Claim");

            migrationBuilder.DropTable(
                name: "PartType");

            migrationBuilder.DropTable(
                name: "UnitOfMeasure");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "PartClass");
        }
    }
}
