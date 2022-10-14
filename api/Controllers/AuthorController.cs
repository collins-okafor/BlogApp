using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using api.Configuration;
using api.Dto;
using api.Dto.Requests;
using api.Dto.Response;
using api.Repo;
using api.Repo.Interface;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    
    // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class AuthorController: ControllerBase
    {
        private readonly IAuthorRepository authorRepository;
        // private readonly UserManager<IdentityUser> userManager;
        // private readonly IOptionsMonitor<JwtConfig> optionsMonitor;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly JwtConfig _jwtConfig;

        public AuthorController(IAuthorRepository authorRepository, UserManager<IdentityUser> userManager, IOptionsMonitor<JwtConfig> optionsMonitor)
        {
            this.authorRepository = authorRepository;
            // this.userManager = userManager;
            // this.optionsMonitor = optionsMonitor;
            _userManager = userManager;
            _jwtConfig = optionsMonitor.CurrentValue;
        } 

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody]UserRegistrationDto user)
        {
            if(ModelState.IsValid)
            {
                //We can utilize the model
                var existingUser = await _userManager.FindByEmailAsync(user.Email);

                if(existingUser != null)
                {
                    return BadRequest(new RegistrationResponse(){

                        Error = new List<string>(){
                            "Email already in use"
                        },
                        Success = false

                    });
                }

                var newUser = new IdentityUser() { Email = user.Email, UserName = user.Username };
                var isCreated = await _userManager.CreateAsync(newUser, user.Password);
                if(isCreated.Succeeded)
                {
                    var jwtToken = GenerateJwtToken( newUser);

                    return Ok(new RegistrationResponse()
                    {
                        Success = true,
                        Token = jwtToken
                    });
                } else{
                    return BadRequest(new RegistrationResponse(){
                        Error = isCreated.Errors.Select(x => x.Description).ToList(),
                        Success = false
                    });
                }
            }

            return BadRequest(new RegistrationResponse(){
                Error = new List<string>(){
                    "Invalid payload"
                },
                Success = false

            });
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] UserLoginRequestDto user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = await _userManager.FindByEmailAsync(user.Email);

            if(existingUser == null) {
                return BadRequest(new RegistrationResponse(){
                Error = new List<string>(){
                    "Invalid payload"
                },
                Success = false
                });
            }

            var isCorrect = await _userManager.CheckPasswordAsync(existingUser, user.Password);

            if(!isCorrect){
                return BadRequest(new RegistrationResponse(){
                Error = new List<string>(){
                    "Invalid payload"
                },
                Success = false
                });
            }

                var jwtToken = GenerateJwtToken(existingUser);

                return Ok(new RegistrationResponse(){
                    Success = true,
                    Token = jwtToken
                }

                );

            }
            
            return BadRequest(new RegistrationResponse(){
                Error = new List<string>(){
                    "Invalid payload"
                },
                Success = false
                }
            );
        }


        private string GenerateJwtToken(IdentityUser user)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(_jwtConfig.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new []
                {
                    new Claim("Id", user.Id),
                    new Claim(JwtRegisteredClaimNames.Email, user.Email),
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                }),
                Expires = DateTime.UtcNow.AddSeconds(30), //5-10 minutes
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = jwtTokenHandler.WriteToken(token);

            return jwtToken;
        } 


        [Authorize]
        [HttpGet]
        public async Task<IActionResult> getAuthors()
        {
            var dataFromRepo = await authorRepository.GetAuthors();
            if(dataFromRepo == null)
            {
                return BadRequest(new
                {
                    Message = "Error",
                    StatusCode = 401,
                    IsSuccessful = false
                });
            }

            return Ok(new
                {
                    Message = "Success",
                    StatusCode = 201,
                    IsSuccessful = true,
                    Data = dataFromRepo
                });
        }


        [Authorize]
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> getAuthorById(int id)
        {
            var dataFromRepo = await authorRepository.GetAuthorWithId(id);
            if(dataFromRepo == null)
            {
                return BadRequest(new
                {
                    Message = "Error",
                    StatusCode = 401,
                    IsSuccessful = false
                });
            }

            return Ok(new
                {
                    Message = "Success",
                    StatusCode = 201,
                    IsSuccessful = true,
                    AuthorId = id,
                    Data = dataFromRepo
                }
            );
        }

        [HttpPost("update")]
        
        public async Task<IActionResult> updateAuthor([FromBody] AuthorForUpdate model)
        {
            var dataFromRepo = await authorRepository.UpdateAuthor(model);
            if(dataFromRepo == null)
            {
                return BadRequest(new
                {
                    Message = "Error",
                    StatusCode = 401,
                    IsSuccessful = false
                });
            }

            return Ok(new
                {
                    Message = "Success",
                    StatusCode = 201,
                    IsSuccessful = true,
                    AuthorId = model.Id,
                    Data = dataFromRepo
                }
            );
            
        } 

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            var dataFromRepo = await authorRepository.DeleteAuthor(id);
            if(!ModelState.IsValid)
            {
                return BadRequest(new
                {
                    Message = "Error",
                    StatusCode = 401,
                    IsSuccessful = false
                });
            }

            return Ok(new
                {
                    Message = "Success",
                    StatusCode = 201,
                    IsSuccessful = true,
                    AuthorId = id,
                    Data = dataFromRepo
                }
            );

        }
    }
}