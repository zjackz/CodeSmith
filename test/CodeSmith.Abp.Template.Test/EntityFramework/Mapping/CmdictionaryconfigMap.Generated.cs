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
    public partial class CmdictionaryconfigMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Cmdictionaryconfig>
    {
        public CmdictionaryconfigMap()
        {
            // table
            ToTable("cmdictionaryconfig");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.DictionaryKey)
                .HasColumnName("DictionaryKey")
                .HasMaxLength(150)
                .IsRequired();
            Property(t => t.DictionaryValue)
                .HasColumnName("DictionaryValue")
                .HasMaxLength(150)
                .IsRequired();
            Property(t => t.CreationTime)
                .HasColumnName("CreationTime")
                .IsRequired();
            Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasMaxLength(150)
                .IsOptional();

            // Relationships

            InitializeMapping();
        }
    }
}