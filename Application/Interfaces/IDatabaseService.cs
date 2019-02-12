using Domain.Recipes;

namespace Application.Interfaces
{
    public interface IDatabaseService
    {
        void CreateRecipe(Recipe recipe);
        Recipe GetRecipe(int Id);        
        void UpdateRecipe(Recipe recipes);
        void DeleteRecipe(int Id);
        void Save();
    }
}
