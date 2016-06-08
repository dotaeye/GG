﻿// <autogenerated>
//   This file was generated by T4 code generator Entry.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using SQ.Core.Data;
using GG.Data.Service;
using GG.Data.Models;
using System.Threading.Tasks;

namespace GG.Data.Impl
{
	public class BlogTypeService : IBlogTypeService
    {
		   #region Fields

        private readonly IRepository<BlogType> _BlogTypeRepository;

        #endregion

        #region Ctor

        public BlogTypeService(IRepository<BlogType> BlogTypeRepository
           )
        {
            this._BlogTypeRepository = BlogTypeRepository;

        }
        #endregion

        public async Task<int> DeleteAsync(BlogType entity)
        {
            if (entity == null)
                throw new ArgumentNullException("BlogType");

            entity.Deleted = true;
           return await UpdateAsync(entity);
        }

        public async Task<BlogType> FindOneAsync(int Id)
        {
            if (Id == 0)
                return null;

            var entity = await _BlogTypeRepository.GetByIdAsync(Id);
            return entity;
        }

        public IQueryable<BlogType> GetAll()
        {
            return _BlogTypeRepository.Table;
        }

        public IPagedList<BlogType> GetPageList(int pageIndex, int pageSize)
        {
            var query = _BlogTypeRepository.Table;
            query = query.OrderByDescending(a => a.Id);
            var result = new PagedList<BlogType>(query, pageIndex, pageSize);
            return result;
        }

        public async Task<int> InsertAsync(BlogType entity)
        {
            if (entity == null)
                throw new ArgumentNullException("BlogType");
            return await _BlogTypeRepository.InsertAsync(entity);
        }

        public async Task<int> UpdateAsync(BlogType entity)
        {
            if (entity == null)
                throw new ArgumentNullException("BlogType");

            return await _BlogTypeRepository.UpdateAsync(entity);
        }
    }
}