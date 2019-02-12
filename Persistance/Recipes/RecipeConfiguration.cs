using Domain.Recipes;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace Persistance.Recipes
{
    public class RecipeConfiguration : EntityTypeConfiguration<Recipe>
    {
        public RecipeConfiguration()
        {
            HasKey(r => r.Id);

            Property(r => r.Name)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName, 
                    new IndexAnnotation(
                        new IndexAttribute("Ix_RecipeName") { IsUnique = true }))
                .IsRequired();
        }
    }
}
