using System.Reflection;
using AutoMapper;
using Client.Extensions;
using StandaloneDatabase.Models;
namespace Client.Mappers
{
    public class MapperProfiler: Profile
    {

        public static void Configure(IMapperConfigurationExpression obj)
        {
            obj.CreateMap<AspNetRoles, SaaSDatabase.Models.AppRoles>().ReverseMap();
            obj.CreateMap<AspNetUsers, SaaSDatabase.Models.AspNetUsers>().ReverseMap();
            obj.CreateMap<SaaSDatabase.Models.AspNetUsers, SaaSDatabase.Models.AspNetUsers>().ReverseMap();
            obj.CreateMap<AspNetUserRoles, SaaSDatabase.Models.AspNetUserRoles>().ReverseMap();
            obj.CreateMap<AspNetUserClaims, SaaSDatabase.Models.AspNetUserClaims>().ReverseMap();
            obj.CreateMap<AspNetUserLogins, SaaSDatabase.Models.AspNetUserLogins>().ReverseMap();
            obj.CreateMap<AspNetUserLogins, SaaSDatabase.Models.AspNetUserLogins>().ReverseMap();
            obj.CreateMap<AspNetResource, SaaSDatabase.Models.AppResources>().ReverseMap();
            obj.CreateMap<AspNetPermission, SaaSDatabase.Models.AppPermissions>().ReverseMap();


            obj.CreateMap<Asset, SaaSDatabase.Models.Asset>().ReverseMap();
            obj.CreateMap<Bank, SaaSDatabase.Models.Bank>()
                .ForMember(dest => dest.BranchName, opt => opt.MapFrom(src => src.Branch))
                .ForMember(dest => dest.Branch, opt => opt.Ignore())
                .ReverseMap();
            obj.CreateMap<BankCheck, SaaSDatabase.Models.BankCheck>().ReverseMap();
            obj.CreateMap<Branch, SaaSDatabase.Models.Branch>().ReverseMap();
            obj.CreateMap<Category, SaaSDatabase.Models.Category>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<Company, SaaSDatabase.Models.Company>().IgnoreAllVirtualProperties().ReverseMap();
            //obj.CreateMap<Company, SaaSDatabase.Models.CompanySetting>();
            //obj.CreateMap<Company, SaaSDatabase.Models.FiscalYear>();
            obj.CreateMap<ComissionSetup, SaaSDatabase.Models.PurchaseCommissionSetup>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<Customer, SaaSDatabase.Models.Customer>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<CustomerAddress, SaaSDatabase.Models.CustomerAddress>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<DailyBankTransectionalBalance, SaaSDatabase.Models.DailyBankAccountBalance>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<DailyCashTransectionalBalance, SaaSDatabase.Models.DailyCashAccountBalance>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<DailyCustomerTransectionalBalance, SaaSDatabase.Models.DailyCustomerAccountBalance>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<DailySupplierTransectionalBalance, SaaSDatabase.Models.DailySupplierAccountBalance>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<DailyTransectionalBalance, SaaSDatabase.Models.DailyAccountBalance>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<DailyTransectionalProductStock, SaaSDatabase.Models.DailyProductStockBalance>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<DailyTransectionalStock, SaaSDatabase.Models.DailyStockBalance>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<Delivery, SaaSDatabase.Models.Delivery>()
                .ForMember(dest => dest.InvoiceNumber, opt => opt.MapFrom(src => src.DeliveryNumber))
                .IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<DeliveryProduct, SaaSDatabase.Models.DeliveryProduct>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<Deposit, SaaSDatabase.Models.Deposit>()
                .ForMember(dest => dest.TotalAmount, opt => opt.MapFrom(src => src.TotalDepositAmount))
                .ForMember(dest => dest.TotalDiscountAmount, opt => opt.MapFrom(src => src.TotalDiscountAmount))
                .ForMember(dest => dest.TotalDueAmount, opt => opt.MapFrom(src => src.TotalRemainingAmount))
                .IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<DepositDetail, SaaSDatabase.Models.DepositDetail>()
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.TotalAmount))
                .ForMember(dest => dest.DiscountAmount, opt => opt.MapFrom(src => src.DiscountAmount))
                .ForMember(dest => dest.DueAmount, opt => opt.MapFrom(src => src.RemainingAmount))
                .IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<DepositHead, SaaSDatabase.Models.DepositHead>()
                .ForMember(dest => dest.DisplayName, opt => opt.MapFrom(src => src.Name))
                .IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<Employee, SaaSDatabase.Models.Employee>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<Equity, SaaSDatabase.Models.Equity>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<Expense, SaaSDatabase.Models.Expense>()
                .ForMember(dest => dest.TotalAmount, opt => opt.MapFrom(src => src.TotalExpenseAmount))
                .ForMember(dest => dest.TotalDiscountAmount, opt => opt.MapFrom(src => src.TotalDiscountAmount))
                .ForMember(dest => dest.TotalDueAmount, opt => opt.MapFrom(src => src.TotalDueAmount))
                .IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<ExpenseDetail, SaaSDatabase.Models.ExpenseDetail>()
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.TotalAmount))
                .ForMember(dest => dest.DiscountAmount, opt => opt.MapFrom(src => src.DiscountAmount))
                .ForMember(dest => dest.DueAmount, opt => opt.MapFrom(src => src.RemainingAmount))
                .ForMember(dest => dest.PaymentMethod, opt => opt.MapFrom(src => src.ExpenseType))
                .IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<ExpenseHead, SaaSDatabase.Models.ExpenseHead>()
                .ForMember(dest => dest.DisplayName, opt => opt.MapFrom(src => src.Name))
                .IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<LoginAttempt, SaaSDatabase.Models.LoginAttempt>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<OpeningStock, SaaSDatabase.Models.OpeningStock>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<Partner, SaaSDatabase.Models.Partner>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<Product, SaaSDatabase.Models.Product>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<PurchaseOrder, SaaSDatabase.Models.PurchaseOrder>()
                .ForMember(dest => dest.InvoiceNumber, opt => opt.MapFrom(src => src.OrderNumber))
                .IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<PurchaseOrderPayment, SaaSDatabase.Models.PurchaseOrderPayment>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<PurchaseOrderProduct, SaaSDatabase.Models.PurchaseOrderProduct>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<PurchaseReceive, SaaSDatabase.Models.PurchaseReceive>()
                .ForMember(dest => dest.InvoiceNumber, opt => opt.MapFrom(src => src.ReceiveNumber))
                .IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<PurchaseReceiveProduct, SaaSDatabase.Models.PurchaseReceiveProduct>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<PurchaseReturn, SaaSDatabase.Models.PurchaseReturn>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<PurchaseReturnProduct, SaaSDatabase.Models.PurchaseReturnProduct>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<Sale, SaaSDatabase.Models.Sale>()
                .ForMember(dest => dest.InvoiceNumber, opt => opt.MapFrom(src => src.OrderNumber))
                .IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<SalePayment, SaaSDatabase.Models.SalePayment>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<SaleProduct, SaaSDatabase.Models.SaleProduct>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<SaleReturn, SaaSDatabase.Models.SaleReturn>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<SaleReturnProduct, SaaSDatabase.Models.SaleReturnProduct>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<Scheduler, SaaSDatabase.Models.Scheduler>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<Stock, SaaSDatabase.Models.Stock>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<StockTransfer, SaaSDatabase.Models.StockTransfer>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<Subcategory, SaaSDatabase.Models.Subcategory>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<Supplier, SaaSDatabase.Models.Supplier>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<SupplierCategory, SaaSDatabase.Models.SupplierCategory>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<TransectionLog, SaaSDatabase.Models.AuditLog>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<Warehouse, SaaSDatabase.Models.Warehouse>().IgnoreAllVirtualProperties().ReverseMap();
            obj.CreateMap<WestageStock, SaaSDatabase.Models.WastageStock>().IgnoreAllVirtualProperties().ReverseMap();

        }


    }
}
