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
    public partial class GetWsgasPageInput : DefaultPagedResultRequest
    {
        
        /// <summary>
        /// 
        /// </summary>    
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public int? AddressId { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public double? AirVolume { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public double? WorkingFaceCH4 { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public double? UpperCornerCH4 { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public double? GoafCH4 { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public double? BackRomanticAvg { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public double? BackRomanticMax { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public double? MaxGushGas { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public double? AverageExhaustAir { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public double? AverageGushGas { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public double? PureFlow { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public System.DateTime? CreationTime { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public System.DateTime? CollectionTime { get; set; }
    }
}

