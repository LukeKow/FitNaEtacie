using Application.Interfaces;
using Application.Recipes.Commands.CreateRecipe.Factory;
using Domain.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Recipes.Commands.CreateRecipe
{
    public class CreateRecipeCommand : ICreateRecipeCommand
    {
        private IDatabaseService databaseService;
        private IRecipeFactory recipeFactory;
        public CreateRecipeCommand(
            IDatabaseService databaseService,
            IRecipeFactory recipeFactory)
        {
            this.databaseService = databaseService;
            this.recipeFactory = recipeFactory;
        }

        public void Execute(CreateRecipeModel model)
        {
            string name = model.Name;

            Recipe recipe = recipeFactory.Create(name);

            databaseService.CreateRecipe(recipe);

            databaseService.Save();
        }
    }
}
