﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIPSoftSharif.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SharifEntities : DbContext
    {
        public SharifEntities()
            : base("name=SharifEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<UserRules> UserRules { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserAccessInfo> UserAccessInfo { get; set; }
        public virtual DbSet<UserGroupsInfo> UserGroupsInfo { get; set; }
        public virtual DbSet<UserLogsInfo> UserLogsInfo { get; set; }
        public virtual DbSet<UserMenusInfo> UserMenusInfo { get; set; }
        public virtual DbSet<UsersInfo> UsersInfo { get; set; }
    }
}
