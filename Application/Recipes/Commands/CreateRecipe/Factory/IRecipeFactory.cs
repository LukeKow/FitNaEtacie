using Domain.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Recipes.Commands.CreateRecipe.Factory
{
    public interface IRecipeFactory
    {
        Recipe Create(string Name);
    }
}
