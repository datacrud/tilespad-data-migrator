using System.Reflection;
using AutoMapper;
using StandaloneDatabase.Models;

namespace Client.Mappers
{
    public class MapperProfiler: Profile
    {

        public static void Configure(IMapperConfigurationExpression obj)
        {

            obj.CreateMap<AspNetRoles, SaaSDatabase.Models.AppRoles>().ReverseMap();
            obj.CreateMap<AspNetUsers, SaaSDatabase.Models.AspNetUsers>().ReverseMap();
            obj.CreateMap<AspNetUserRoles, SaaSDatabase.Models.AspNetUserRoles>().ReverseMap();
            obj.CreateMap<AspNetUserClaims, SaaSDatabase.Models.AspNetUserClaims>().ReverseMap();
            obj.CreateMap<AspNetUserLogins, SaaSDatabase.Models.AspNetUserLogins>().ReverseMap();
            obj.CreateMap<AspNetUserLogins, SaaSDatabase.Models.AspNetUserLogins>().ReverseMap();
            obj.CreateMap<AspNetResource, SaaSDatabase.Models.AppResources>().ReverseMap();
            obj.CreateMap<AspNetPermission, SaaSDatabase.Models.AppPermissions>().ReverseMap();


            obj.CreateMap<Asset, SaaSDatabase.Models.Asset>().ReverseMap();
            obj.CreateMap<Bank, SaaSDatabase.Models.Bank>()
                .ForMember(dest => dest.BranchName, opt => opt.MapFrom(src => src.Branch))
                .ReverseMap();
            obj.CreateMap<BankCheck, SaaSDatabase.Models.BankCheck>().ReverseMap();
            obj.CreateMap<Branch, SaaSDatabase.Models.Branch>().ReverseMap();
            obj.CreateMap<Category, SaaSDatabase.Models.Category>().ReverseMap();
            obj.CreateMap<Company, SaaSDatabase.Models.Company>().ReverseMap();
            //obj.CreateMap<Company, SaaSDatabase.Models.CompanySetting>();
            //obj.CreateMap<Company, SaaSDatabase.Models.FiscalYear>();
            obj.CreateMap<ComissionSetup, SaaSDatabase.Models.PurchaseCommissionSetup>().ReverseMap();
            obj.CreateMap<Customer, SaaSDatabase.Models.Customer>().ReverseMap();
            obj.CreateMap<CustomerAddress, SaaSDatabase.Models.CustomerAddress>().ReverseMap();
            obj.CreateMap<DailyBankTransectionalBalance, SaaSDatabase.Models.DailyBankAccountBalance>().ReverseMap();
            obj.CreateMap<DailyCashTransectionalBalance, SaaSDatabase.Models.DailyCashAccountBalance>().ReverseMap();
            obj.CreateMap<DailyCustomerTransectionalBalance, SaaSDatabase.Models.DailyCustomerAccountBalance>().ReverseMap();
            obj.CreateMap<DailySupplierTransectionalBalance, SaaSDatabase.Models.DailySupplierAccountBalance>().ReverseMap();
            obj.CreateMap<DailyTransectionalBalance, SaaSDatabase.Models.DailyAccountBalance>().ReverseMap();
            obj.CreateMap<DailyTransectionalProductStock, SaaSDatabase.Models.DailyProductStockBalance>().ReverseMap();
            obj.CreateMap<DailyTransectionalStock, SaaSDatabase.Models.DailyStockBalance>().ReverseMap();
            obj.CreateMap<Delivery, SaaSDatabase.Models.Delivery>().ReverseMap();
            obj.CreateMap<DeliveryProduct, SaaSDatabase.Models.DeliveryProduct>().ReverseMap();
            obj.CreateMap<Deposit, SaaSDatabase.Models.Deposit>().ReverseMap();
            obj.CreateMap<DepositDetail, SaaSDatabase.Models.DepositDetail>().ReverseMap();
            obj.CreateMap<DepositHead, SaaSDatabase.Models.DepositHead>().ReverseMap();
            obj.CreateMap<Employee, SaaSDatabase.Models.Employee>();
            obj.CreateMap<Equity, SaaSDatabase.Models.Equity>().ReverseMap();
            obj.CreateMap<Expense, SaaSDatabase.Models.Expense>().ReverseMap();
            obj.CreateMap<ExpenseDetail, SaaSDatabase.Models.ExpenseDetail>().ReverseMap();
            obj.CreateMap<ExpenseHead, SaaSDatabase.Models.ExpenseHead>().ReverseMap();
            obj.CreateMap<LoginAttempt, SaaSDatabase.Models.LoginAttempt>().ReverseMap();
            obj.CreateMap<OpeningStock, SaaSDatabase.Models.OpeningStock>().ReverseMap();
            obj.CreateMap<Partner, SaaSDatabase.Models.Partner>().ReverseMap();
            obj.CreateMap<Product, SaaSDatabase.Models.Product>().ReverseMap();
            obj.CreateMap<PurchaseOrder, SaaSDatabase.Models.PurchaseOrder>().ReverseMap();
            obj.CreateMap<PurchaseOrderPayment, SaaSDatabase.Models.PurchaseOrderPayment>().ReverseMap();
            obj.CreateMap<PurchaseOrderProduct, SaaSDatabase.Models.PurchaseOrderProduct>().ReverseMap();
            obj.CreateMap<PurchaseReceive, SaaSDatabase.Models.PurchaseReceive>().ReverseMap();
            obj.CreateMap<PurchaseReceiveProduct, SaaSDatabase.Models.PurchaseReceiveProduct>().ReverseMap();
            obj.CreateMap<PurchaseReturn, SaaSDatabase.Models.PurchaseReceive>().ReverseMap();
            obj.CreateMap<PurchaseReturnProduct, SaaSDatabase.Models.PurchaseReceiveProduct>().ReverseMap();
            obj.CreateMap<Sale, SaaSDatabase.Models.Sale>().ReverseMap();
            obj.CreateMap<SalePayment, SaaSDatabase.Models.SalePayment>().ReverseMap();
            obj.CreateMap<SaleProduct, SaaSDatabase.Models.SaleProduct>().ReverseMap();
            obj.CreateMap<SaleReturn, SaaSDatabase.Models.SaleReturn>().ReverseMap();
            obj.CreateMap<SaleReturnProduct, SaaSDatabase.Models.SaleReturnProduct>().ReverseMap();
            obj.CreateMap<Scheduler, SaaSDatabase.Models.Scheduler>().ReverseMap();
            obj.CreateMap<Stock, SaaSDatabase.Models.Stock>().ReverseMap();
            obj.CreateMap<StockTransfer, SaaSDatabase.Models.StockTransfer>().ReverseMap();
            obj.CreateMap<Subcategory, SaaSDatabase.Models.Subcategory>().ReverseMap();
            obj.CreateMap<Supplier, SaaSDatabase.Models.Supplier>().ReverseMap();
            obj.CreateMap<SupplierCategory, SaaSDatabase.Models.SupplierCategory>().ReverseMap();
            obj.CreateMap<TransectionLog, SaaSDatabase.Models.AuditLog>().ReverseMap();
            obj.CreateMap<Warehouse, SaaSDatabase.Models.Warehouse>().ReverseMap();
            obj.CreateMap<WestageStock, SaaSDatabase.Models.WastageStock>().ReverseMap();

        }


    }
}
