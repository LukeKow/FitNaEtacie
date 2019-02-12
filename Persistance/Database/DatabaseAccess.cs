using Domain.Recipes;
using Persistance.Recipes;
using System.Data.Entity;

namespace Persistance.Database
{
    internal class DatabaseAccess: DbContext
    {
        public IDbSet<Recipe> Recipes { get; set; }

        public DatabaseAccess() : base() { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new RecipeConfiguration());
        }
    }
}
