namespace _2ND_Backend_Exam.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        [SwaggerResponse(StatusCodes.Status201Created, type: typeof(AuthorDTO))]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status409Conflict)]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Post(UserPostDTO value)
            => Ok(await _service.CreateNewAsync(value));
    }
}
