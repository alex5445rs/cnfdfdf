﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Лопушок
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_4Entities : DbContext
    {
        public DB_4Entities()
            : base("name=DB_4Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Материалы> Материалы { get; set; }
        public virtual DbSet<Материалы_продуктов> Материалы_продуктов { get; set; }
        public virtual DbSet<Продукты> Продукты { get; set; }
        public virtual DbSet<Тип_продукции> Тип_продукции { get; set; }
    }
}
