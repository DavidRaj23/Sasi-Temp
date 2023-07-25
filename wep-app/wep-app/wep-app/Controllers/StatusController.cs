using Microsoft.AspNetCore.Mvc;
using wep_app.Dto.Response;

namespace KnowledgeManagementAPI.Controllers
{
    /// <summary>
    /// API status check controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        #region Methods

        /// <summary>
        /// Health check API endpoint
        /// </summary>
        /// <returns>Success string</returns>
        [HttpGet]
        public async Task<IActionResult> HelathCheck()
        {
            return StatusCode(StatusCodes.Status201Created,
                    new ValidResponse<string>(StatusCodes.Status201Created, "Success"));
        }

        #endregion
    }
}
