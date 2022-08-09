namespace _2ND_Backend_Exam.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialTypesController : ControllerBase
    {
        private readonly IMaterialTypeService _materialTypeService;

        public MaterialTypesController(IMaterialTypeService materialTypeService)
            => _materialTypeService = materialTypeService;


        /// <summary>
        /// Get Material Types data list
        /// </summary>
        /// <returns>List of Material Types</returns>
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ActionResult<IEnumerable<MaterialTypeDTO>>))]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [Authorize(Roles ="Admin,User")]
        public async Task<ActionResult<IEnumerable<MaterialTypeDTO>>> Get()
            => Ok(await _materialTypeService.GetAllAsync());

        /// <summary>
        /// Get one Material Type data
        /// </summary>
        /// <param name="id">Identification number of Material Type</param>
        /// <returns>Data about Material Type</returns>
        [HttpGet]
        [Route("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ActionResult<MaterialTypeDTO>))]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [Authorize(Roles ="Admin,User")]
        public async Task<ActionResult<MaterialTypeDTO>> Get(int id)
            => Ok(await _materialTypeService.GetByIdAsync(id));

        /// <summary>
        /// Add new Material Type
        /// </summary>
        /// <param name="value">JSON-new Material Type data</param>
        /// <returns>Id of new Material Type with 201.Created; 400.BadRequest; 409.Conflict</returns>
        [HttpPost]
        [SwaggerResponse(StatusCodes.Status201Created, type: typeof(MaterialTypeDTO))]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status409Conflict)]
        [Authorize(Roles ="")]
        public async Task<ActionResult> Post(MaterialTypePostDTO value)
        {
            var id = await _materialTypeService.CreateNewAsync(value);
            return Created($"{HttpContext.Request.Path}/{id}", $"new Material Type with id= [{id}] added");
        }

        /// <summary>
        /// Change direct data
        /// </summary>
        /// <param name="id">Identification number of Material Type to change data</param>
        /// <param name="value">Value to change. Write only row(key/value) of what do you what to change</param>
        /// <returns>New Material Type data: 200.Ok; 400.BadRequest; 409.Conflict</returns>
        [HttpPut]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(MaterialTypeDTO))]
        [SwaggerResponse(StatusCodes.Status409Conflict)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [Authorize(Roles ="")]
        public async Task<ActionResult> Put(MaterialTypePutDTO value)
            => Ok(await _materialTypeService.UpdatePut(value));

        /// <summary>
        /// Remove Material Type
        /// </summary>
        /// <param name="id">Identification number of Material Type to remove</param>
        /// <returns>Id of removed Material Type: 200.Ok; 404.NotFound</returns>
        [HttpDelete]
        [Route("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(int))]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [Authorize(Roles ="")]
        public async Task<ActionResult> Delete(int id)
            => Ok(await _materialTypeService.Remove(id));
    }
}
