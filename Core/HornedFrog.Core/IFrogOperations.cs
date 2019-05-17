using System.Threading.Tasks;

using HornedFrog.Domain;

namespace HornedFrog.Core
{
    /// <summary>
    /// SUMMARY
    /// </summary>
    public interface IFrogOperations
    {
        Task<Frog> GetFrog(int id);
    }
}