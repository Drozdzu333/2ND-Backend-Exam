namespace _2ND_Backend_Exam.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly IUserRepository _repository;
        public TokenController(IConfiguration configuration, IUserRepository userRepository)
        {
            _configuration = configuration;
            _repository = userRepository;
        }
        // POST api/<TokenController>
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Post(UserLoginDTO userData)
        {
            var user = Authenticate(userData);
            if (user == null)
                return NotFound("Invalid credentials");

            var claims = new[] {

                new Claim(ClaimTypes.NameIdentifier, user.Username),
                new Claim(ClaimTypes.Role, user.Role)
                //new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                //new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                //new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                //new Claim("UserId", user.UserId.ToString()),
                //new Claim("DisplayName", user.DisplayName),
                //new Claim("UserName", user.UserName),
                };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims,
                expires: DateTime.UtcNow.AddMinutes(10),
                signingCredentials: signIn);

            return Ok(new JwtSecurityTokenHandler().WriteToken(token));
        }

        private User? Authenticate(UserLoginDTO userLogin)
        {
            var currentUser = _repository.GetUserByLoginAndPassword(userLogin.Username, userLogin.Password);

            return currentUser ?? null;
        }
    }
}
