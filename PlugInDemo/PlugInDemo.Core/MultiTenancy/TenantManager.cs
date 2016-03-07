﻿using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using PlugInDemo.Authorization.Roles;
using PlugInDemo.Editions;
using PlugInDemo.Users;

namespace PlugInDemo.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager
            )
        {
        }
    }
}