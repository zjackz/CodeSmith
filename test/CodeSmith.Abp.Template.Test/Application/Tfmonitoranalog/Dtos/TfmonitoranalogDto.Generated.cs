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
    public partial class TfmonitoranalogDto : IEntityDto<int>, IInputDto, IOutputDto
    {
        /// <summary>
        /// 
        /// </summary>    
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public int AddressId { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public int SysType { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public int MonitorType { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public decimal? MaxValue { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public string MaxMomentValue { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public decimal? MinValue { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public string MinMomentValue { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public decimal? DailyAverageValue { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public int? OutCount { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public System.DateTime CreationTime { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public System.DateTime CollectionTime { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public string Remarks { get; set; }

    }
}

