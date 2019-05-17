using System.Threading.Tasks;

using HornedFrog.Core;
using HornedFrog.Extensions;
using HornedFrog.Models;

using Microsoft.AspNetCore.Mvc;

namespace HornedFrog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FrogController : ControllerBase
    {
        private readonly IFrogOperations _frogOperations;

        /// <summary>
        /// Initializes a new instance of <see cref="FrogController"/> class
        /// </summary>
        /// <param name="frogOperations">
        /// The frog Operations.
        /// </param>
        public FrogController(IFrogOperations frogOperations)
        {
            _frogOperations = frogOperations;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FrogModel>> GetFrog(int id)
        {
            var frog = await _frogOperations.GetFrog(id);

            return await Task.FromResult<FrogModel>(frog.ToModel());
        }
    }
}