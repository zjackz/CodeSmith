﻿//------------------------------------------------------------------------------
// <autogenerated>
//     此代码是由 CodeSmith 模板生成的。
//
//     请不要对该文件内容进行修改。如果重新生成代码，文件内容将被覆盖。
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

// ReSharper disable once CheckNamespace
namespace CodeSmith.Abp.Template.Test.Core
{
    public partial class Bsmenu : IEntity<int>,IHasCreationTime,IPassivable
    {
        public Bsmenu()
        {
            ParentMenuBsmenus = new List<Bsmenu>();
            ParentMenuBsmenus1 = new List<Bsmenu>();
            MenuBsmenubuttons = new List<Bsmenubutton>();
            MenuBsuseroperatelogs = new List<Bsuseroperatelog>();
        }
        
        public bool IsTransient()
        {
            return EqualityComparer<int>.Default.Equals(this.Id, default(int));
        }

        /// <summary>
        /// 编号
        /// </summary>    
        public int Id { get; set; }
        /// <summary>
        /// 菜单文本
        /// </summary>    
        public string MenuText { get; set; }
        /// <summary>
        /// 菜单Url
        /// </summary>    
        public string MenuUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public int Sort { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public int? ParentMenuId { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public string ParentMenuIds { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public bool IsMain { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public bool IsInline { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public bool IsActive { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public string OpenEvent { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public string CloseEvent { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public System.DateTime CreationTime { get; set; }
        /// <summary>
        /// 
        /// </summary>    
        public string Remark { get; set; }

        public virtual Bsmenu ParentMenuBsmenu { get; set; }
        public virtual ICollection<Bsmenu> ParentMenuBsmenus { get; set; }
        public virtual Bsmenu ParentMenuBsmenu1 { get; set; }
        public virtual ICollection<Bsmenu> ParentMenuBsmenus1 { get; set; }
        public virtual ICollection<Bsmenubutton> MenuBsmenubuttons { get; set; }
        public virtual ICollection<Bsuseroperatelog> MenuBsuseroperatelogs { get; set; }
    }
}