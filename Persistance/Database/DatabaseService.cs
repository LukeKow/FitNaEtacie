using Application.Interfaces;
using System;
using Domain.Recipes;
using System.Linq;

namespace Persistance.Database
{
    internal class DatabaseService: IDatabaseService
    {
        private DatabaseAccess dbContext;

        public DatabaseService(DatabaseAccess dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateRecipe(Recipe recipe)
            => dbContext.Recipes.Add(recipe);

        public void DeleteRecipe(int Id)
        {
            Recipe recipeToRemove = GetRecipe(Id);
            dbContext.Recipes.Remove(recipeToRemove);
        }

        public Recipe GetRecipe(int Id)
            => dbContext.Recipes.Single(rec => rec.Id == Id);        

        public void UpdateRecipe(Recipe recipe)
        {
            Recipe recipeToUpdate = GetRecipe(recipe.Id);
            dbContext.Entry(recipeToUpdate).CurrentValues.SetValues(recipe);
        }

        public void Save()
            => dbContext.SaveChanges();        
    }
}
