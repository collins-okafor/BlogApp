using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using api.Dto;
using api.Repo.Interface;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
 
namespace api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class BlogPostController: ControllerBase
    {
        private readonly IBlogPostRepository blogPostRepository;
        private readonly IMapper mapper;

        public BlogPostController(IBlogPostRepository blogPostRepository, IMapper mapper)
        {
            this.blogPostRepository = blogPostRepository;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddBlogPost([FromBody]BlogPostForCreation field)
        {
            var dataFromRepo = await blogPostRepository.AddBlogPost(field);
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


        // [Authorize]
        [HttpGet]
        public async Task<ActionResult<BlogPostForGet>> getBlogPosts()
        {
             var dataFromRepo = await blogPostRepository.GetBlogPostsAll();
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
                    Data = mapper.Map<ICollection<BlogPostForGet>>(dataFromRepo)
                });
        }


        // [Authorize]
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult> getBlogPostWithId(int id)
        {
            var dataFromRepo = await blogPostRepository.GetBlogPostWithId(id);
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

        [HttpGet]
        [Route("title")]
        public async Task<ActionResult> GetBlogPostWithTitle(string title)
        {
            var dataFromRepo = await blogPostRepository.GetBlogPostWithTitle(title);
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
                    Data = mapper.Map<ICollection<BlogPostForGet>>(dataFromRepo)
                });
        }

        [HttpPost("update")]

        public async Task<IActionResult> UpdateBlogPost(BlogPostForUpdate model)
        { 
            var dataFromRepo = await blogPostRepository.UpdateBlogPost(model);
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
                }
            );
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            var dataFromRepo = await blogPostRepository.DeletePost(id);
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
                    PostId = id,
                    Data = dataFromRepo
                }
            );
        }
    }
}