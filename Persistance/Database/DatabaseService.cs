using Application.Interfaces;
using System;
using Domain.Recipes;
using System.Linq;
using System.Data.Entity;
using Persistance.Recipes;

namespace Persistance.Database
{
    internal class DatabaseService: DbContext, IDatabaseService
    {
        public IDbSet<Recipe> Recipes { get; set; }

        public DatabaseService() : base() { }

        public void CreateRecipe(Recipe recipe)
            => Recipes.Add(recipe);

        public void DeleteRecipe(int Id)
        {
            Recipe recipeToRemove = GetRecipe(Id);
            Recipes.Remove(recipeToRemove);
        }

        public Recipe GetRecipe(int Id)
            => Recipes.Single(rec => rec.Id == Id);        

        public void UpdateRecipe(Recipe recipe)
        {
            Recipe recipeToUpdate = GetRecipe(recipe.Id);
            Entry(recipeToUpdate).CurrentValues.SetValues(recipe);
        }

        public void Save()
            => SaveChanges();

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new RecipeConfiguration());
        }
    }
}
