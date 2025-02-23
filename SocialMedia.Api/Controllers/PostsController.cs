using Microsoft.AspNetCore.Mvc;
using SocialMedia.Domain.Models;

namespace SocialMedia.Api.Controllers;

[Route("[controller]")]
[ApiController]
public class PostsController: ControllerBase
{
    [HttpGet]
    [Route("{id}")]
    public IActionResult GetById(int id)
    {
        var post = new Post{Id = id, Text = "Hello, world" };
        return Ok(post);
    }
}