using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace SocialMedia.Api.Controllers.V1;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
public class PostsController: ControllerBase
{
    [HttpGet]
    [Route("{id}")]
    public IActionResult GetById(int id, CancellationToken cancellationToken)
    {
        return Ok();
    }
}