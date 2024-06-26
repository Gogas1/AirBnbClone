﻿using Mandry.Models.DB;
using Microsoft.EntityFrameworkCore;

namespace Mandry.Data.DbContexts
{
    public class MandryDbContext : DbContext
    {
        public MandryDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<AccessbilityFeature> AccessbilityFeatures { get; set; }
        public DbSet<AccessbilityFeatureHousing> AccessbilityFeaturesHousings { get; set; }
        public DbSet<Availability> Availabilities { get; set; }
        public DbSet<Bed> Beds { get; set; }
        public DbSet<Bedroom> Bedrooms { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryDescriptionProperty> CategoriesDescriptionProperties { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FeatureHousing> FeatureHousings { get; set; }
        public DbSet<Housing> Housings { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Parameter> Parameters { get; set; }
        public DbSet<ParameterFeatureHousing> ParameterFeatureHousings { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Translation> Translations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            {
                property.SetPrecision(18);
                property.SetScale(2);
            }
        }
    }
}
