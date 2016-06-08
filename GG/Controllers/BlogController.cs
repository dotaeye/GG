using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Data.Entity;
using System.Web.Http;
using System.Web.Http.Description;
using GG.Data.Service;
using GG.Data.DTO;
using GG.Data.Models;
using System.Threading.Tasks;

namespace GG.Controllers
{
    public class BlogController : ApiController
    {
        private IBlogService BlogService;
        public BlogController(
            IBlogService _BlogService
          )
        {
            this.BlogService = _BlogService;
        }

        private static readonly Expression<Func<Blog, BlogDTO>> AsBlogDTO =
        x => new BlogDTO
        {
            Id = x.Id,
            BlogTypeID = x.BlogTypeID,
            Content = x.Content,
            CreateTime = x.CreateTime,
            LastTime = x.LastTime,
            Name = x.Name,
            Url = x.Url,
            UserId = x.UserId
        };

        // GET api/Blogs
        public IQueryable<BlogDTO> GetBlogs()
        {
            return BlogService.GetAll().Select(AsBlogDTO);
        }

        [ResponseType(typeof(BlogDTO))]
        public async Task<IHttpActionResult> GetBlog(int id)
        {
            BlogDTO blog = await BlogService.GetAll().Where(x => x.Id == id).Select(AsBlogDTO).FirstOrDefaultAsync();
            if (blog == null)
            {
                return NotFound();
            }
            return Ok(blog);
        }


    }
}
