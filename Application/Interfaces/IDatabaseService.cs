using Domain.Recipes;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IDatabaseService
    {
        List<Recipe> Recipes { get; set; }
        void Save();
    }
}
