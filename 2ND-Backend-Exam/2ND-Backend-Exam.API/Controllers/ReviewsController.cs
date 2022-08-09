namespace _2ND_Backend_Exam.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        public ReviewsController(IReviewService reviewService)
            => _reviewService = reviewService;


        /// <summary>
        /// Get Reviews data list
        /// </summary>
        /// <returns>List of Review</returns>
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ActionResult<IEnumerable<ReviewDTO>>))]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [Authorize(Roles ="Admin,User")]
        public async Task<ActionResult<IEnumerable<ReviewDTO>>> Get()
            => Ok(await _reviewService.GetAllAsync());

        /// <summary>
        /// Get one Review data
        /// </summary>
        /// <param name="id">Identification number of Review</param>
        /// <returns>Data about Review</returns>
        [HttpGet]
        [Route("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ActionResult<ReviewDTO>))]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [Authorize(Roles ="Admin,User")]
        public async Task<ActionResult<ReviewDTO>> Get(int id)
            => Ok(await _reviewService.GetByIdAsync(id));

        /// <summary>
        /// Add new Review
        /// </summary>
        /// <param name="value">JSON-new review data</param>
        /// <returns>Id of new Review with 201.Created; 400.BadRequest; 409.Conflict</returns>
        [HttpPost]
        [SwaggerResponse(StatusCodes.Status201Created, type: typeof(ReviewDTO))]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status409Conflict)]
        [Authorize(Roles ="Admin,User")]
        public async Task<ActionResult> Post(ReviewPostDTO value)
        {
            var id = await _reviewService.CreateNewAsync(value);
            return Created($"{HttpContext.Request.Path}/{id}", $"new Review with id= [{id}] added");
        }

        /// <summary>
        /// Change direct data
        /// </summary>
        /// <param name="id">Identification number of Review to change data</param>
        /// <param name="value">Value to change. Write only row(key/value) of what do you what to change</param>
        /// <returns>New Review data: 200.Ok; 400.BadRequest; 409.Conflict</returns>
        [HttpPatch]
        [Route("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReviewDTO))]
        [SwaggerResponse(StatusCodes.Status409Conflict)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [Authorize(Roles ="Admin,User")]
        public async Task<ActionResult> Patch(int id, ReviewPatchDTO value)
            => Ok(await _reviewService.UpdatePatch(id, value));
        /// <summary>
        /// Change direct data
        /// </summary>
        /// <param name="id">Identification number of Review to change data</param>
        /// <param name="value">Value to change. Write only row(key/value) of what do you what to change</param>
        /// <returns>New Review data: 200.Ok; 400.BadRequest; 409.Conflict</returns>
        [HttpPut]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReviewDTO))]
        [SwaggerResponse(StatusCodes.Status409Conflict)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [Authorize(Roles ="Admin,User")]
        public async Task<ActionResult> Put(ReviewPutDTO value)
            => Ok(await _reviewService.UpdatePut(value));

        /// <summary>
        /// Remove Review
        /// </summary>
        /// <param name="id">Identification number of Review to remove</param>
        /// <returns>Id of removed Review: 200.Ok; 404.NotFound</returns>
        [HttpDelete]
        [Route("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(int))]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [Authorize(Roles ="Admin")]
        public async Task<ActionResult> Delete(int id)
            => Ok(await _reviewService.Remove(id));
    }
}
