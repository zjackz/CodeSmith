﻿//------------------------------------------------------------------------------
// <autogenerated>
//     此代码是由 CodeSmith 模板生成的。
//
//     做不该文件的修改内容。更改此
//     如果重新生成代码，文件将会丢失。
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

// ReSharper disable once CheckNamespace
namespace CodeSmith.Abp.Template.Test.Application
{
    public partial class GetBsdictionaryPageInput : DefaultPagedResultRequest
    {
        
        /// <summary>
        /// 
        /// </summary>    
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public int? ParentId { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public string ParentIds { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public string DictionaryKey { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public string DictionaryName { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public string DictionaryValue { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public bool? IsActive { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public bool? IsDeleted { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public bool? IsGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public long? CreatorUserId { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public System.DateTime? CreationTime { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public long? LastModifierUserId { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public System.DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public int? Sort { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public string Remarks { get; set; }
    }
}

