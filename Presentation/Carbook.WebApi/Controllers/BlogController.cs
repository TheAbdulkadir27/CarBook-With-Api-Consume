using CarBook.Application.Features.Mediator.Commands.Blog;
using CarBook.Application.Features.Mediator.Queries.Blog;
using MediatR;
using Microsoft.AspNetCore.Mvc;
namespace Carbook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BlogController(IMediator mediator) => _mediator = mediator;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var values = await _mediator.Send(new GetBlogQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _mediator.Send(new GetBlogByIdQuery(id));
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveBlog(int id)
        {
            await _mediator.Send(new RemoveBlogCommand(id));
            return Ok("Başarıyla  Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Başarıyla Güncellendi");
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Başarıyla Eklendi");
        }

        [HttpGet("GetLast3BlogsWithAuthor")]
        public async Task<IActionResult> GetLast3BlogsWithAuthor()
        {
            var value = await _mediator.Send(new GetLast3BlogsQuery());
            return Ok(value);
        }
    }
}
