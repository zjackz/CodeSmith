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
using Abp.EntityFramework;
using CodeSmith.Abp.Template.Test.Core;

// ReSharper disable once CheckNamespace
namespace CodeSmith.Abp.Template.Test.EntityFramework
{
    /// <summary>
    /// Implements <see cref="ICmsensorinfoRepository"/> for EntityFramework ORM.
    /// </summary>
    public partial class CmsensorinfoRepository : RepositoryBase<Cmsensorinfo,int>, ICmsensorinfoRepository
    {
        public CmsensorinfoRepository(IDbContextProvider<YtQdYtsfContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}