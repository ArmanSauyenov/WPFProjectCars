namespace WPFProjectCars.LIB.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Achievements> Achievements { get; set; }
        public virtual DbSet<Cafe> Cafe { get; set; }
        public virtual DbSet<CafeOrder> CafeOrder { get; set; }
        public virtual DbSet<CafeStock> CafeStock { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<newEquipment> newEquipment { get; set; }
        public virtual DbSet<Players> Players { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductsMinAmount> ProductsMinAmount { get; set; }
        public virtual DbSet<Recipe> Recipe { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<StoreStock> StoreStock { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<TablesManufacturer> TablesManufacturer { get; set; }
        public virtual DbSet<TablesModel> TablesModel { get; set; }
        public virtual DbSet<TablesSNPrefix> TablesSNPrefix { get; set; }
        public virtual DbSet<Tournaments> Tournaments { get; set; }
        public virtual DbSet<TrackMeter> TrackMeter { get; set; }
        public virtual DbSet<MSreplication_options> MSreplication_options { get; set; }
        public virtual DbSet<spt_fallback_db> spt_fallback_db { get; set; }
        public virtual DbSet<spt_fallback_dev> spt_fallback_dev { get; set; }
        public virtual DbSet<spt_fallback_usg> spt_fallback_usg { get; set; }
        public virtual DbSet<spt_monitor> spt_monitor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Achievements>()
                .Property(e => e.Place)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cafe>()
                .Property(e => e.CafeName)
                .IsUnicode(false);

            modelBuilder.Entity<Cafe>()
                .Property(e => e.CafeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Cafe>()
                .Property(e => e.CafePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Cafe>()
                .Property(e => e.CafeEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Cafe>()
                .HasMany(e => e.CafeOrder)
                .WithRequired(e => e.Cafe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cafe>()
                .HasMany(e => e.CafeStock)
                .WithRequired(e => e.Cafe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cafe>()
                .HasMany(e => e.Sales)
                .WithRequired(e => e.Cafe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Countries>()
                .Property(e => e.Country_name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.FoodName)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .HasMany(e => e.Recipe)
                .WithRequired(e => e.Menu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Menu>()
                .HasMany(e => e.Sales)
                .WithRequired(e => e.Menu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<newEquipment>()
                .HasMany(e => e.TrackMeter)
                .WithRequired(e => e.newEquipment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Players>()
                .Property(e => e.Surname)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Players>()
                .Property(e => e.Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.ProductOrigin)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.CafeOrder)
                .WithRequired(e => e.Products)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.CafeStock)
                .WithRequired(e => e.Products)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.ProductsMinAmount)
                .WithRequired(e => e.Products)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.Recipe)
                .WithRequired(e => e.Products)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.StoreStock)
                .WithRequired(e => e.Products)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.StoreName)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.StoreAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.StorePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.StoreEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.CafeOrder)
                .WithRequired(e => e.Store)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.StoreStock)
                .WithRequired(e => e.Store)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.SupplierName)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.SupplierAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.SupplierPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.SupplierEmail)
                .IsUnicode(false);

            modelBuilder.Entity<TablesManufacturer>()
                .HasMany(e => e.newEquipment)
                .WithRequired(e => e.TablesManufacturer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TablesModel>()
                .HasMany(e => e.newEquipment)
                .WithRequired(e => e.TablesModel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TablesSNPrefix>()
                .HasMany(e => e.newEquipment)
                .WithRequired(e => e.TablesSNPrefix)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tournaments>()
                .Property(e => e.Tournaments1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_db>()
                .Property(e => e.xserver_name)
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_db>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_dev>()
                .Property(e => e.xserver_name)
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_dev>()
                .Property(e => e.xfallback_drive)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_dev>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_dev>()
                .Property(e => e.phyname)
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_usg>()
                .Property(e => e.xserver_name)
                .IsUnicode(false);
        }
    }
}
