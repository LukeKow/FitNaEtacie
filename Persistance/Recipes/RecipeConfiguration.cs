using Domain.Recipes;
using System.Data.Entity.ModelConfiguration;

namespace Persistance.Recipes
{
    public class RecipeConfiguration : EntityTypeConfiguration<Recipe>
    {
        public RecipeConfiguration()
        {
            HasKey(r => r.Id);
            Property(r => r.Name)
                .IsRequired();
        }
    }
}
