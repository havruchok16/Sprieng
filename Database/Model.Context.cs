﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SpriengEntities : DbContext
    {
        public SpriengEntities()
            : base("name=SpriengEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dictionary> Dictionary { get; set; }
        public virtual DbSet<Info> Info { get; set; }
        public virtual DbSet<Progress> Progress { get; set; }
        public virtual DbSet<Rule> Rule { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Text> Text { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Word> Word { get; set; }
    }
}
