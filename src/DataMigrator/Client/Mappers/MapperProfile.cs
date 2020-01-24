using AutoMapper;
using StandaloneDatabase.Models;

namespace Client.Mappers
{
    public class MapperProfile: Profile
    {

        public static void Configure(IMapperConfigurationExpression obj)
        {

            obj.CreateMap<AspNetRoles, SaaSDatabase.Models.AppRoles>();
            obj.CreateMap<AspNetUsers, SaaSDatabase.Models.AspNetUsers>();
            obj.CreateMap<AspNetUserRoles, SaaSDatabase.Models.AspNetUserRoles>();
            obj.CreateMap<AspNetUserClaims, SaaSDatabase.Models.AspNetUserClaims>();
            obj.CreateMap<AspNetUserLogins, SaaSDatabase.Models.AspNetUserLogins>();
            obj.CreateMap<AspNetUserLogins, SaaSDatabase.Models.AspNetUserLogins>();
            obj.CreateMap<AspNetResource, SaaSDatabase.Models.AppResources>();
            obj.CreateMap<AspNetPermission, SaaSDatabase.Models.AppPermissions>();

            obj.CreateMap<Company, SaaSDatabase.Models.Company>();
            //obj.CreateMap<Company, SaaSDatabase.Models.CompanySetting>();
            //obj.CreateMap<Company, SaaSDatabase.Models.FiscalYear>();
            obj.CreateMap<Branch, SaaSDatabase.Models.Branch>();
            obj.CreateMap<Partner, SaaSDatabase.Models.Partner>();


            obj.CreateMap<Employee, SaaSDatabase.Models.Employee>();

        }

    }
}
