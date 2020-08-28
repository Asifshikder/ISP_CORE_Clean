using ISPCore.Domain;
using ISPCore.Domain.Entities;
using ISPCore.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Persistence
{
    public class DBContext : DbContext//,IDbContext
    {
        private readonly ILoggedInUserIdentity _loggedInUser;
        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DBContext(DbContextOptions<DBContext> options, ILoggedInUserIdentity loggedInUser)
            : base(options)
        {
            _loggedInUser = loggedInUser;
        }

        public DbSet<Year> Year { get; set; }

        public DbSet<AssetType> AssetType { get; set; }

        public DbSet<Asset> Asset { get; set; }
        public DbSet<Day> Day { get; set; }
        public DbSet<Month> Month { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<MeasurementUnit> MeasurementUnit { get; set; }
        public DbSet<PaymentFrom> PaymentFrom { get; set; }
        public DbSet<PaymentType> PaymentType { get; set; }
        public DbSet<PaymentBy> PaymentBy { get; set; }
        public DbSet<AttendanceType> AttendanceType { get; set; }
        public DbSet<LeaveSalaryType> LeaveSalaryType { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<DutyShift> DutyShift { get; set; }
        public DbSet<CableType> CableType { get; set; }
        public DbSet<Section> Section { get; set; }
        public DbSet<UserRightPermission> UserRightPermission { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<IPPool> IPPool { get; set; }
        public DbSet<Package> Package { get; set; }
        public DbSet<Mikrotik> Mikrotik { get; set; }
        public DbSet<CompanyVsPayer> CompanyVsPayer { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<AccountOwner> AccountOwner { get; set; }
        public DbSet<ControllerName> ControllerName { get; set; }
        public DbSet<Form> Form { get; set; }
        public DbSet<ActionNameAuthentication> ActionNameAuthentication { get; set; }
        public DbSet<VendorType> VendorType { get; set; }
        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<LineStatus> LineStatus { get; set; }
        public DbSet<OptionSettings> OptionSetting { get; set; }
        public DbSet<TimePeriodForSignal> TimePeriodForSignal { get; set; }
        public DbSet<ConnectionType> ConnectionType { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<AccountList> AccountList { get; set; }
        public DbSet<StockDetails> StockDetails { get; set; }
        public DbSet<ProductStatus> ProductStatus { get; set; }
        public DbSet<BandwithResellerGivenItem> BandwithResellerGivenItem { get; set; }
        public DbSet<AccountingHistory> AccountingHistory { get; set; }
        public DbSet<ActionList> ActionList { get; set; }
        public DbSet<FormNameForAuth> FormNameForAuth { get; set; }
        public DbSet<Zone> Zone { get; set; }
        public DbSet<Reseller> Reseller { get; set; }
        public DbSet<CableUnit> CableUnit { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Head> Head { get; set; }
        public DbSet<AccountListVsAmmountTransfer> AccountListVsAmmountTransfer { get; set; }
        public DbSet<EmployeeLeaveHistory> EmployeeLeaveHistory { get; set; }
        public DbSet<ClientDetails> ClientDetails { get; set; }
        public DbSet<Deposit> Deposit { get; set; }
        public DbSet<Expense> Expense { get; set; }
        public DbSet<ISPAccessList> ISPAccessList { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<SecurityQuestion> SecurityQuestion { get; set; }
        public DbSet<Box> Box { get; set; }
        public DbSet<ComplainType> ComplainType { get; set; }
        public DbSet<Complain> Complain { get; set; }
        public DbSet<Pop> Pop { get; set; }
        public DbSet<ClientCableAssign> ClientCableAssign { get; set; }
        public DbSet<CableDistribution> CableDistribution { get; set; }
        public DbSet<ClientStockAssign> ClientStockAssign { get; set; }
        public DbSet<ClientCableDistribution> ClientCableDistribution { get; set; }
        public DbSet<DistributionReason> DistributionReason { get; set; }
        public DbSet<GivenPaymentType> GivenPaymentType { get; set; }
        public DbSet<SMS> SMS { get; set; }
        public DbSet<CableStock> CableStock { get; set; }
        public DbSet<PurchaseDetails> PurchaseDetails { get; set; }
        public DbSet<ProfilePercentageFields> ProfilePercentageFields { get; set; }
        public DbSet<Distribution> Distribution { get; set; }
        public DbSet<ClientDueBills> ClientDueBills { get; set; }
        public DbSet<AdvancePayment> AdvancePayment { get; set; }
        public DbSet<ClientLineStatus> ClientLineStatus { get; set; }
        public DbSet<PayementHistory> PayementHistory { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<AuthorViewModel> AuthorViewModel { get; set; }
        public DbSet<LoginViewModel> LoginViewModel { get; set; }
        public DbSet<SMSSenderIDPass> SMSSenderIDPass { get; set; }
        public DbSet<ResellerBillingCycle> ResellerBillingCycle { get; set; }
        public DbSet<EmployeeVsWorkSchedule> EmployeeVsWorkSchedules { get; set; }
        public DbSet<Distribution_Transaction> Distribution_Transaction { get; set; }
        public DbSet<BillGenerateHistory> BillGenerateHistory { get; set; }
        public DbSet<EmployeeTransactionLockUnlock> EmployeeTransactionLockUnlock { get; set; }
        public DbSet<Recovery> Recovery { get; set; }
        public DbSet<Client_Stock_StockDetails> Client_Stock_StockDetails { get; set; }
        public DbSet<DirectProductSectionChangeFromWorkingToOthers> DirectProductSectionChangeFromWorkingToOthers { get; set; }
        public DbSet<MacResellerVSUserPaymentDeductionDetails> MacResellerVSUserPaymentDeductionDetails { get; set; }
        public DbSet<ResellerVsPackageHistory> ResellerVsPackageHistory { get; set; }
        public DbSet<Client_Stock_StockDetails_ForDistribution> Client_Stock_StockDetails_ForDistribution { get; set; }
        public DbSet<PurchasePaymentHistory> PurchasePaymentHistory { get; set; }
        public DbSet<ResellerPaymentDetailsHistory> ResellerPaymentDetailsHistory { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<IAuditable>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreateBy = _loggedInUser.UserId;
                        entry.Entity.CreateDate = DateTime.Now;
                        entry.Entity.UpdateBy = _loggedInUser.UserId;
                        entry.Entity.UpdateDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.UpdateBy = _loggedInUser.UserId;
                        entry.Entity.UpdateDate = DateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<IAuditable>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreateBy = _loggedInUser.UserId;
                        entry.Entity.CreateDate = DateTime.Now;
                        entry.Entity.UpdateBy = _loggedInUser.UserId;
                        entry.Entity.UpdateDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.UpdateBy = _loggedInUser.UserId;
                        entry.Entity.UpdateDate = DateTime.Now;
                        break;
                }
            }

            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DBContext).Assembly);
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["ISPDatabase"].ConnectionString);
        //}
    }
}
