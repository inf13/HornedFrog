using System.Threading.Tasks;

using HornedFrog.Domain;

namespace HornedFrog.DataContract
{
    /// <summary>
    /// SUMMARY
    /// </summary>
    public interface IFrogRepository
    {
        Task<Frog> GetFrog(int id);
    }
}