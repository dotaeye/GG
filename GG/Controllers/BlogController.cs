﻿// <autogenerated>
//   This file was generated by T4 code generator Entry.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

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
using GG.Data.AutoMapper;
using GG.Data.Models;
using AutoMapper.QueryableExtensions;
using System.Threading.Tasks;

namespace GG.Controllers
{
    [RoutePrefix("api/Blog")]
    public class BlogController : ApiController
    {
        private IBlogService BlogService;
        public BlogController(
            IBlogService _BlogService
          )
        {
            this.BlogService = _BlogService;
        }

        [Route("")]
        public IQueryable<BlogDTO> Get()
        {
            return BlogService.GetAll().Where(x=>!x.Deleted).ProjectTo<BlogDTO>();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(BlogDTO))]
        public async Task<IHttpActionResult> GetById(int id)
        {
            BlogDTO Blog = await BlogService.GetAll().Where(x => x.Id == id&&!x.Deleted).ProjectTo<BlogDTO>().FirstOrDefaultAsync();
            if (Blog == null)
            {
                return NotFound();
            }
            return Ok(Blog);
        }

        [Route("")]
        [HttpPost]
        [ResponseType(typeof(BlogDTO))]
        public async Task<IHttpActionResult> Create([FromBody]BlogDTO BlogDto)
        {
		    if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity = BlogDto.ToEntity();
            await BlogService.InsertAsync(entity);
            return Ok(entity.ToModel());
        }


        [Route("{id:int}")]
        [HttpPut]
        [ResponseType(typeof(BlogDTO))]
        public async Task<IHttpActionResult> Update(int id, [FromBody]BlogDTO BlogDto)
        {
			if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity = BlogDto.ToEntity();
            await BlogService.UpdateAsync(entity);
            return Ok(entity.ToModel());
        }

        [Route("{id:int}")]
        [HttpDelete]
        [ResponseType(typeof(BlogDTO))]
        public async Task<IHttpActionResult> Delete(int id)
        {
            Blog entity = await BlogService.FindOneAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            await BlogService.DeleteAsync(entity);

            return Ok(entity.ToModel());
        }

    }
}

