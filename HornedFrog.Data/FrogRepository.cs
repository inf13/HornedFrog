using System.Threading.Tasks;

using HornedFrog.DataContract;
using HornedFrog.Domain;

namespace HornedFrog.Data
{
    /// <summary>
    /// SUMMARY
    /// </summary>
    public class FrogRepository : IFrogRepository
    {
        public async Task<Frog> GetFrog(int id)
        {
            return await Task.FromResult(new Frog() { Name = "Bull Frog" });
        }
    }
}