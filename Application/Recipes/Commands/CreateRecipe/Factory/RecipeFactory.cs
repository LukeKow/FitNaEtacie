using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Recipes;

namespace Application.Recipes.Commands.CreateRecipe.Factory
{
    public class RecipeFactory : IRecipeFactory
    {
        public Recipe Create(string Name)
        {
            Recipe recipe = new Recipe();
            recipe.Name = Name;

            return recipe;
        }
    }
}
