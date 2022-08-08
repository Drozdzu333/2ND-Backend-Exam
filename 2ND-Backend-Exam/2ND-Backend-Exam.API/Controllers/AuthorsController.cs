namespace _2ND_Backend_Exam.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorsController(IAuthorService authorService)
            => _authorService = authorService;


        /// <summary>
        /// Get Authors data list
        /// </summary>
        /// <returns>List of Authors</returns>
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ActionResult<IEnumerable<AuthorDTO>>))]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<AuthorDTO>>> Get()
            => Ok(await _authorService.GetAllAsync());

        /// <summary>
        /// Get one Author data
        /// </summary>
        /// <param name="id">Identification number of Author</param>
        /// <returns>Data about Author</returns>
        [HttpGet]
        [Route("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ActionResult<AuthorDTO>))]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<AuthorDTO>> Get(int id)
            => Ok(await _authorService.GetByIdAsync(id));

        /// <summary>
        /// Add new Author
        /// </summary>
        /// <param name="value">JSON-new author data</param>
        /// <returns>Id of new Author with 201.Created; 400.BadRequest; 409.Conflict</returns>
        [HttpPost]
        [SwaggerResponse(StatusCodes.Status201Created, type: typeof(AuthorDTO))]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status409Conflict)]
        public async Task<ActionResult> Post(AuthorPutDTO value)
        {
            var id = await _authorService.CreateNewAsync(value);
            return Created($"{HttpContext.Request.Path}/{id}", $"new Actor with id= [{id}] added");
        }

        /// <summary>
        /// Change direct data
        /// </summary>
        /// <param name="id">Identification number of Author to change data</param>
        /// <param name="value">Value to change. Write only row(key/value) of what do you what to change</param>
        /// <returns>New Author data: 200.Ok; 400.BadRequest; 409.Conflict</returns>
        [HttpPatch]
        [Route("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(AuthorDTO))]
        [SwaggerResponse(StatusCodes.Status409Conflict)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Patch(int id, AuthorPatchDTO value)
            => Ok(await _authorService.UpdatePatch(id, value));
        /// <summary>
        /// Change direct data
        /// </summary>
        /// <param name="id">Identification number of Author to change data</param>
        /// <param name="value">Value to change. Write only row(key/value) of what do you what to change</param>
        /// <returns>New Author data: 200.Ok; 400.BadRequest; 409.Conflict</returns>
        [HttpPut]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(AuthorDTO))]
        [SwaggerResponse(StatusCodes.Status409Conflict)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Put(AuthorPutDTO value)
            => Ok(await _authorService.UpdatePut(value));

        /// <summary>
        /// Remove Author
        /// </summary>
        /// <param name="id">Identification number of Author to remove</param>
        /// <returns>Id of removed Author: 200.Ok; 404.NotFound</returns>
        [HttpDelete]
        [Route("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(int))]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Delete(int id)
            => Ok(await _authorService.Remove(id));
    }
}
