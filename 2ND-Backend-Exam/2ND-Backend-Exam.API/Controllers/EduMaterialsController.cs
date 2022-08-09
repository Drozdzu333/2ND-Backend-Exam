namespace _2ND_Backend_Exam.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EduMaterialsController : ControllerBase
    {
        private readonly IEduMaterialService _materialService;

        public EduMaterialsController(IEduMaterialService materialService)
            => _materialService = materialService;


        /// <summary>
        /// Get Materials data list
        /// </summary>
        /// <returns>List of Materials</returns>
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ActionResult<IEnumerable<EduMaterialDTO>>))]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<EduMaterialDTO>>> Get()
            => Ok(await _materialService.GetAllAsync());

        /// <summary>
        /// Get one Material data
        /// </summary>
        /// <param name="id">Identification number of Material</param>
        /// <returns>Data about Material</returns>
        [HttpGet]
        [Route("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ActionResult<EduMaterialDTO>))]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<EduMaterialDTO>> Get(int id)
            => Ok(await _materialService.GetByIdAsync(id));

        /// <summary>
        /// Add new Material
        /// </summary>
        /// <param name="value">JSON-new material data</param>
        /// <returns>Id of new Material with 201.Created; 400.BadRequest; 409.Conflict</returns>
        [HttpPost]
        [SwaggerResponse(StatusCodes.Status201Created, type: typeof(EduMaterialDTO))]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status409Conflict)]
        public async Task<ActionResult> Post(EduMaterialPostDTO value)
        {
            var id = await _materialService.CreateNewAsync(value);
            return Created($"{HttpContext.Request.Path}/{id}", $"new Material with id= [{id.Id}] added");
        }

        /// <summary>
        /// Change direct data
        /// </summary>
        /// <param name="id">Identification number of Material to change data</param>
        /// <param name="value">Value to change. Write only row(key/value) of what do you what to change</param>
        /// <returns>New Material data: 200.Ok; 400.BadRequest; 409.Conflict</returns>
        [HttpPatch]
        [Route("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(EduMaterialDTO))]
        [SwaggerResponse(StatusCodes.Status409Conflict)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Patch(int id, EduMaterialPatchDTO value)
            => Ok(await _materialService.UpdatePatch(id, value));
        /// <summary>
        /// Change direct data
        /// </summary>
        /// <param name="id">Identification number of Material to change data</param>
        /// <param name="value">Value to change. Write only row(key/value) of what do you what to change</param>
        /// <returns>New Material data: 200.Ok; 400.BadRequest; 409.Conflict</returns>
        [HttpPut]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(EduMaterialDTO))]
        [SwaggerResponse(StatusCodes.Status409Conflict)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Put(EduMaterialPutDTO value)
            => Ok(await _materialService.UpdatePut(value));

        /// <summary>
        /// Remove Material
        /// </summary>
        /// <param name="id">Identification number of Material to remove</param>
        /// <returns>Id of removed Material: 200.Ok; 404.NotFound</returns>
        [HttpDelete]
        [Route("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(bool))]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Delete(int id)
            => Ok(await _materialService.Remove(id));
    }
}
