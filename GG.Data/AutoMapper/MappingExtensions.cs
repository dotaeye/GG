﻿// <autogenerated>
//   This file was generated by T4 code generator Entry.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using GG.Data.Models;
using GG.Data.DTO;

namespace GG.Data.AutoMapper
{
    public static class MappingExtensions
    {

        public static BlogDTO ToModel(this Blog entity)
        {
            return Mapper.Map<Blog, BlogDTO>(entity);
        }

        public static Blog ToEntity(this BlogDTO dto)
        {
            return Mapper.Map<BlogDTO, Blog>(dto);
        }

        public static Blog ToEntity(this BlogDTO dto, Blog entity)
        {
            return Mapper.Map(dto, entity);
        }

        public static BlogTypeDTO ToModel(this BlogType entity)
        {
            return Mapper.Map<BlogType, BlogTypeDTO>(entity);
        }

        public static BlogType ToEntity(this BlogTypeDTO dto)
        {
            return Mapper.Map<BlogTypeDTO, BlogType>(dto);
        }

        public static BlogType ToEntity(this BlogTypeDTO dto, BlogType entity)
        {
            return Mapper.Map(dto, entity);
        }

        public static UserActivitiesDTO ToModel(this UserActivities entity)
        {
            return Mapper.Map<UserActivities, UserActivitiesDTO>(entity);
        }

        public static UserActivities ToEntity(this UserActivitiesDTO dto)
        {
            return Mapper.Map<UserActivitiesDTO, UserActivities>(dto);
        }

        public static UserActivities ToEntity(this UserActivitiesDTO dto, UserActivities entity)
        {
            return Mapper.Map(dto, entity);
        }


    }
}
