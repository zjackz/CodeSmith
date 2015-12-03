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
    public partial class BsmenubuttonMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Bsmenubutton>
    {
        public BsmenubuttonMap()
        {
            // table
            ToTable("bsmenubutton");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.ButtonId)
                .HasColumnName("ButtonId")
                .IsOptional();
            Property(t => t.MenuId)
                .HasColumnName("MenuId")
                .IsRequired();
            Property(t => t.ButtonText)
                .HasColumnName("ButtonText")
                .HasMaxLength(150)
                .IsOptional();
            Property(t => t.RunEvent)
                .HasColumnName("RunEvent")
                .HasMaxLength(150)
                .IsOptional();
            Property(t => t.IconClass)
                .HasColumnName("IconClass")
                .HasMaxLength(150)
                .IsOptional();
            Property(t => t.IsActive)
                .HasColumnName("IsActive")
                .IsRequired();
            Property(t => t.Sort)
                .HasColumnName("Sort")
                .IsRequired();
            Property(t => t.LastModificationTime)
                .HasColumnName("LastModificationTime")
                .IsOptional();
            Property(t => t.LastModifierUserId)
                .HasColumnName("LastModifierUserId")
                .IsOptional();
            Property(t => t.CreatorUserId)
                .HasColumnName("CreatorUserId")
                .IsOptional();
            Property(t => t.CreationTime)
                .HasColumnName("CreationTime")
                .IsRequired();

            // Relationships
            HasOptional(t => t.ButtonBsbutton)
                .WithMany(t => t.ButtonBsmenubuttons)
                .HasForeignKey(d => d.ButtonId)
                .WillCascadeOnDelete(false);
            HasRequired(t => t.MenuBsmenu)
                .WithMany(t => t.MenuBsmenubuttons)
                .HasForeignKey(d => d.MenuId)
                .WillCascadeOnDelete(false);

            InitializeMapping();
        }
    }
}
