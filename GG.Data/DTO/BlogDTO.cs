﻿// <autogenerated>
//   This file was generated by T4 code generator Entry.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using FluentValidation.Attributes;
using GG.Data.Validator;

namespace GG.Data.DTO
{   
    [Validator(typeof(BlogValidator))]
	public class BlogDTO
    {
       public string Name  { get; set; } 
       public string Content  { get; set; } 
       public DateTime CreateTime  { get; set; } 
       public DateTime LastTime  { get; set; } 
       public int BlogTypeId  { get; set; } 
       public string UserId  { get; set; } 
       public string Url  { get; set; } 
       public string BlogTypeName  { get; set; } 
       public int Id  { get; set; } 
    }
}
