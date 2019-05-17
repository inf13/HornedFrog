using HornedFrog.Domain;
using HornedFrog.Models;

namespace HornedFrog.Extensions
{
    /// <summary>
    /// Converts domain object to model
    /// </summary>
    public static class DomainToModelExtensions
    {
        public static FrogModel ToModel(this Frog frog)
        {
            return new FrogModel()
            {
                Id = frog.Id,
                Name = frog.Name
            };
        }
    }
}