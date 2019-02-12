using Domain.Recipes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Recipes.Commands.CreateRecipe.Factory
{
    [TestFixture]
    public class RecipeFactoryTests
    {
        private RecipeFactory recipeFactory;

        private const string name = "Zapiekanka";

        [SetUp]
        public void SetUp()
        {
            recipeFactory = new RecipeFactory();
        }

        [Test]
        public void TestCreateShouldCreateRecipe()
        {
            Recipe result = recipeFactory.Create(name);

            Assert.That(result.Name, Is.EqualTo(name));
        }
    }
}
