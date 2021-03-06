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
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using Abp.EntityFramework;
using CodeSmith.Abp.Template.Test.Core;

// ReSharper disable once CheckNamespace
namespace CodeSmith.Abp.Template.Test.EntityFramework
{
    public partial class BsmenuMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Bsmenu>
    {
        public BsmenuMap()
        {
            // table
            ToTable("bsmenu");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.MenuText)
                .HasColumnName("MenuText")
                .HasMaxLength(150)
                .IsRequired();
            Property(t => t.MenuUrl)
                .HasColumnName("MenuUrl")
                .HasMaxLength(765)
                .IsOptional();
            Property(t => t.Sort)
                .HasColumnName("Sort")
                .IsRequired();
            Property(t => t.ParentMenuId)
                .HasColumnName("ParentMenuId")
                .IsOptional();
            Property(t => t.ParentMenuIds)
                .HasColumnName("ParentMenuIds")
                .HasMaxLength(150)
                .IsOptional();
            Property(t => t.IsMain)
                .HasColumnName("IsMain")
                .IsRequired();
            Property(t => t.IsInline)
                .HasColumnName("IsInline")
                .IsRequired();
            Property(t => t.IsActive)
                .HasColumnName("IsActive")
                .IsRequired();
            Property(t => t.OpenEvent)
                .HasColumnName("OpenEvent")
                .HasMaxLength(150)
                .IsOptional();
            Property(t => t.CloseEvent)
                .HasColumnName("CloseEvent")
                .HasMaxLength(150)
                .IsOptional();
            Property(t => t.CreationTime)
                .HasColumnName("CreationTime")
                .IsRequired();
            Property(t => t.Remark)
                .HasColumnName("Remark")
                .IsOptional();

            // Relationships
            HasOptional(t => t.ParentMenuBsmenu)
                .WithMany(t => t.ParentMenuBsmenus)
                .HasForeignKey(d => d.ParentMenuId)
                .WillCascadeOnDelete(false);
            HasOptional(t => t.ParentMenuBsmenu1)
                .WithMany(t => t.ParentMenuBsmenus1)
                .HasForeignKey(d => d.ParentMenuId)
                .WillCascadeOnDelete(false);

            InitializeMapping();
        }
    }
}
