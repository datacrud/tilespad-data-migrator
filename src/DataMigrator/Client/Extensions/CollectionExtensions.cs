using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StandaloneDatabase.Models;

namespace Client.Extensions
{
    public static class CollectionExtensions
    {
        public static DateTime DateTime2Start = new DateTime(1753, 1, 1);

        public static void Swap<T>(this List<T> list, int index1, int index2)
        {
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }

        public static void SetNull<T>(this List<T> collections, List<string> userIds, params string[] propertyNames)
        {

            foreach (var collection in collections)
            {
                var type = collection.GetType();
                foreach (var propertyName in propertyNames)
                {
                    var propertyInfo = type.GetProperty(propertyName);
                    if (propertyInfo != null)
                    {
                        var value = propertyInfo.GetValue(collection);
                        try
                        {
                            Guid.Parse(value.ToString());

                            if (!userIds.Contains(value.ToString())) propertyInfo.SetValue(collection, null);
                        }
                        catch (Exception)
                        {
                            propertyInfo.SetValue(collection, null);
                        }
                    }
                }

                var created = type.GetProperty($"{nameof(SaaSDatabase.Models.AspNetUsers.Created)}");
                if (created != null)
                {
                    var value = created.GetValue(collection);
                    var creationTime = value is DateTime time ? time : default;
                    if (creationTime < DateTime2Start)
                    {
                        created.SetValue(collection, null, null);
                    }
                }
                var modified = type.GetProperty($"{nameof(SaaSDatabase.Models.AspNetUsers.Modified)}");
                if (modified != null)
                {
                    var value = modified.GetValue(collection);
                    var modificationTime = value is DateTime time ? time : default;
                    if (modificationTime < DateTime2Start)
                    {
                        modified.SetValue(collection, null, null);
                    }
                }
                var deleted = type.GetProperty($"{nameof(SaaSDatabase.Models.AspNetUsers.Deleted)}");
                if (deleted != null)
                {
                    var value = deleted.GetValue(collection);
                    var deletionTime = value is DateTime time ? time : default;
                    if (deletionTime < DateTime2Start)
                    {
                        deleted.SetValue(collection, null, null);
                    }
                }
            }
        }


        public static void CheckTime<T>(this List<T> collections)
        {

            foreach (var collection in collections)
            {
                var type = collection.GetType();
                
                var created = type.GetProperty($"{nameof(SaaSDatabase.Models.AspNetUsers.Created)}");
                if (created != null)
                {
                    var value = created.GetValue(collection);
                    var creationTime = value is DateTime time ? time : default;
                    if (creationTime < DateTime2Start)
                    {
                        created.SetValue(collection, DateTime.Now.Date);
                    }
                }
                var modified = type.GetProperty($"{nameof(SaaSDatabase.Models.AspNetUsers.Modified)}");
                if (modified != null)
                {
                    var value = modified.GetValue(collection);
                    var modificationTime = value is DateTime time ? time : default;
                    if (modificationTime < DateTime2Start)
                    {
                        modified.SetValue(collection, null, null);
                    }
                }
                var deleted = type.GetProperty($"{nameof(SaaSDatabase.Models.AspNetUsers.Deleted)}");
                if (deleted != null)
                {
                    var value = deleted.GetValue(collection);
                    var deletionTime = value is DateTime time ? time : default;
                    if (deletionTime < DateTime2Start)
                    {
                        deleted.SetValue(collection, null, null);
                    }
                }
            }
        }


        public static void SetTenantId<T>(this List<T> collections, string tenantId)
        {
            foreach (var collection in collections)
            {
                var type = collection.GetType();

                var propertyInfo = type.GetProperty($"{nameof(SaaSDatabase.Models.Company.TenantId)}");
                if (propertyInfo != null) propertyInfo.SetValue(collection, tenantId);
            }
        }

        public static void SetCompanyId<T>(this List<T> collections, string companyId)
        {
            foreach (var collection in collections)
            {
                var type = collection.GetType();

                var propertyInfo = type.GetProperty($"{nameof(SaaSDatabase.Models.Employee.CompanyId)}");
                if (propertyInfo != null) propertyInfo.SetValue(collection, companyId);
            }
        }

        public static void EnsureTenantId<T>(this List<T> collections, string tenantId)
        {
            foreach (var collection in collections)
            {
                var type = collection.GetType();

                var propertyInfo = type.GetProperty($"{nameof(SaaSDatabase.Models.Employee.TenantId)}");
                if (propertyInfo != null)
                {
                    var value = propertyInfo.GetValue(collection);

                    var s = value as string;

                    if(string.IsNullOrWhiteSpace(s)) throw new Exception($"An item found has no tenant id is set");
                    if(s != tenantId) throw new Exception($"An item found of different tenant");
                }
            }
        }


        public static void Prepare<T>(this List<T> map, string tenantId, string companyId, List<string> userIds, params string[] nullHandlerPropertyNames)
        {
            Console.WriteLine($"...... preparing tenant data start at {DateTime.Now} ......");
            map.SetNull(userIds, nullHandlerPropertyNames);
            map.CheckTime();
            map.SetTenantId(tenantId);
            map.SetCompanyId(companyId);
            map.EnsureTenantId(tenantId);
            Console.WriteLine($"...... preparing tenant data end at {DateTime.Now} ......");
        }

    }
}
