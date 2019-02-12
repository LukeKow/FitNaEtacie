namespace Application.Recipes.Commands.CreateRecipe
{
    public interface ICreateRecipeCommand
    {
        void Execute(CreateRecipeModel model);
    }
}
