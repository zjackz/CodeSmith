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
    public partial class GetZtfieldiinspectionPageInput : DefaultPagedResultRequest
    {
        
        /// <summary>
        /// 
        /// </summary>    
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public string DrillingField { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public string Distance { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public string Drainage { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public string Method { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public decimal? Concentration { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public decimal? MixedFlow { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public decimal? PureFlow { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public decimal? Temperature { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public System.DateTime? CreationTime { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public System.DateTime? CollectionTime { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public string Remarks { get; set; }
    }
}
