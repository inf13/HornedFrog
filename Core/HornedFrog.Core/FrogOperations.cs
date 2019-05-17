using System.Threading.Tasks;

using HornedFrog.DataContract;
using HornedFrog.Domain;

namespace HornedFrog.Core
{
    /// <summary>
    /// SUMMARY
    /// </summary>
    public class FrogOperations : IFrogOperations
    {
        private readonly IFrogRepository _frogRepository;

        /// <summary>
        /// Initializes a new instance of <see cref="FrogOperations"/> class
        /// </summary>
        /// <param name="frogRepository">
        /// The frog Repository.
        /// </param>
        public FrogOperations(IFrogRepository frogRepository)
        {
            _frogRepository = frogRepository;
        }

        public async Task<Frog> GetFrog(int id)
        {
            return await _frogRepository.GetFrog(id);
        }
    }
}