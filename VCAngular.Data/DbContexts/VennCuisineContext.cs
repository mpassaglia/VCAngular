using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions;

namespace VCAngular.Data
{
    public class VennCuisineContext : DbContext
    {
        public VennCuisineContext(DbContextOptions<VennCuisineContext> options) 
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Cuisine>().HasKey(c => new { c.CuisineId });
            builder.Entity<CuisineIngredient>().HasKey(a => new { a.CuisineId, a.IngredientId });
            builder.Entity<Ingredient>().HasKey(i => new { i.IngredientId });
            builder.Entity<NamedCuisineIngredient>().HasKey(a => new { a.CuisineId, a.IngredientId });
        }

        public DbSet<Cuisine> Cuisines { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<CuisineIngredient> CuisineIngredients { get; set; }
        public DbSet<NamedCuisineIngredient> NamedCuisineIngredients { get; set; }

    }
}
