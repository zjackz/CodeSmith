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
    public partial class TfgasdrillingMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Tfgasdrilling>
    {
        public TfgasdrillingMap()
        {
            // table
            ToTable("tfgasdrilling");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.CreateDateTime)
                .HasColumnName("CreateDateTime")
                .IsRequired();
            Property(t => t.DrillingId)
                .HasColumnName("DrillingId")
                .IsRequired();
            Property(t => t.TValue)
                .HasColumnName("TValue")
                .HasMaxLength(765)
                .IsRequired();
            Property(t => t.COValue)
                .HasColumnName("COValue")
                .HasMaxLength(765)
                .IsRequired();
            Property(t => t.IsDeleted)
                .HasColumnName("IsDeleted")
                .IsRequired();
            Property(t => t.CreationTime)
                .HasColumnName("CreationTime")
                .IsRequired();

            // Relationships
            HasRequired(t => t.DrillingTfdrilling)
                .WithMany(t => t.DrillingTfgasdrillings)
                .HasForeignKey(d => d.DrillingId)
                .WillCascadeOnDelete(false);

            InitializeMapping();
        }
    }
}
