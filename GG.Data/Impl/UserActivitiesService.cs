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
	public class UserActivitiesService : IUserActivitiesService
    {
		   #region Fields

        private readonly IRepository<UserActivities> _UserActivitiesRepository;

        #endregion

        #region Ctor

        public UserActivitiesService(IRepository<UserActivities> UserActivitiesRepository
           )
        {
            this._UserActivitiesRepository = UserActivitiesRepository;

        }
        #endregion

        public async Task<int> DeleteAsync(UserActivities entity)
        {
            if (entity == null)
                throw new ArgumentNullException("UserActivities");

            entity.Deleted = true;
           return await UpdateAsync(entity);
        }

        public async Task<UserActivities> FindOneAsync(int Id)
        {
            if (Id == 0)
                return null;

            var entity = await _UserActivitiesRepository.GetByIdAsync(Id);
            return entity;
        }

        public IQueryable<UserActivities> GetAll()
        {
            return _UserActivitiesRepository.Table;
        }

        public IPagedList<UserActivities> GetPageList(int pageIndex, int pageSize)
        {
            var query = _UserActivitiesRepository.Table;
            query = query.OrderByDescending(a => a.Id);
            var result = new PagedList<UserActivities>(query, pageIndex, pageSize);
            return result;
        }

        public async Task<int> InsertAsync(UserActivities entity)
        {
            if (entity == null)
                throw new ArgumentNullException("UserActivities");
            return await _UserActivitiesRepository.InsertAsync(entity);
        }

        public async Task<int> UpdateAsync(UserActivities entity)
        {
            if (entity == null)
                throw new ArgumentNullException("UserActivities");

            return await _UserActivitiesRepository.UpdateAsync(entity);
        }
    }
}
