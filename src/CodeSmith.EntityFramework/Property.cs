﻿using System;
using System.Data;
using System.Diagnostics;
using System.Xml.Serialization;

namespace CodeSmith.EntityFramework
{
    /// <summary>
    /// 属性 对象
    /// </summary>
    [DebuggerDisplay("属性: {PropertyName}, 字段: {ColumnName}, 类型: {NativeType}")]
    public class Property : EntityBase
    {
        #region CodeSmith

        /// <summary>
        /// 属性名称
        /// </summary>
        public string PropertyName { get; set; }
        /// <summary>
        /// 字段名
        /// </summary>
        public string ColumnName { get; set; }
        /// <summary>
        ///  字段类型，例如：Int32、Int64、String、DateTime
        /// </summary>
        public DbType DataType { get; set; }
        /// <summary>
        /// 字段类型，例如：int、bigint、datetime
        /// </summary>
        public string NativeType { get; set; }
        /// <summary>
        /// 字段类型，例如：System.Int32、System.String、System.DateTime、System.Int64
        /// </summary>
        [XmlIgnore]
        public Type SystemType { get; set; }
        /// <summary>
        /// 字段排序
        /// </summary>
        public int? Order { get; set; }
        /// <summary>
        /// 按指定顺序
        /// </summary>
        public bool OrderSpecified
        {
            get { return Order.HasValue; }
        }
        /// <summary>
        /// 是否可为null
        /// </summary>
        public bool? IsNullable { get; set; }
        /// <summary>
        /// 按指定是否为空
        /// </summary>
        public bool IsNullableSpecified
        {
            get { return IsNullable.HasValue; }
        }
        /// <summary>
        /// 是否必须
        /// </summary>
        public bool IsRequired
        {
            get { return IsNullable == false; }
            set { IsNullable = !value; }
        }
        /// <summary>
        /// 是否可选
        /// </summary>
        public bool IsOptional
        {
            get { return IsNullable == true; }
            set { IsNullable = value; }
        }
        /// <summary>
        /// 是否主键
        /// </summary>
        public bool? IsPrimaryKey { get; set; }
        public bool IsPrimaryKeySpecified
        {
            get { return IsPrimaryKey.HasValue; }
        }
        /// <summary>
        /// 是否外键
        /// </summary>
        public bool? IsForeignKey { get; set; }
        public bool IsForeignKeySpecified
        {
            get { return IsForeignKey.HasValue; }
        }
        /// <summary>
        /// 是否自增列
        /// </summary>
        public bool? IsAutoGenerated { get; set; }
        public bool IsAutoGeneratedSpecified
        {
            get { return IsAutoGenerated.HasValue; }
        }
        /// <summary>
        /// 是否只读
        /// </summary>
        public bool? IsReadOnly { get; set; }
        /// <summary>
        /// 制定是否只读
        /// </summary>
        public bool IsReadOnlySpecified
        {
            get { return IsReadOnly.HasValue; }
        }
        /// <summary>
        /// 是否是自动增长列，数据库级别标识，根据时间戳生成
        /// </summary>
        public bool? IsRowVersion { get; set; }
        /// <summary>
        /// 指定本地化
        /// </summary>
        public bool IsRowVersionSpecified
        {
            get { return IsRowVersion.HasValue; }
        }
        /// <summary>
        /// 是否自动增长列、数据表级别识别，根据种子生成
        /// </summary>
        public bool? IsIdentity { get; set; }
        /// <summary>
        /// 指定是否自动增长列
        /// </summary>
        public bool IsIdentitySpecified
        {
            get { return IsIdentity.HasValue; }
        }

        /// <summary>
        /// 唯一值
        /// </summary>
        public bool? IsUnique { get; set; }

        /// <summary>
        /// 指定唯一值
        /// </summary>
        public bool IsUniqueSpecified
        {
            get { return IsUnique.HasValue; }
        }

        /// <summary>
        /// 是否有单位编码
        /// </summary>
        public bool? IsUnicode { get; set; }

        /// <summary>
        /// 是否唯一值
        /// </summary>
        public bool IsUnicodeSpecified
        {
            get { return IsUnicode.HasValue; }
        }

        /// <summary>
        /// 制定固定值
        /// </summary>
        public bool? IsFixedLength { get; set; }

        /// <summary>
        /// 是否固定值
        /// </summary>
        public bool IsFixedLengthSpecified
        {
            get { return IsFixedLength.HasValue; }
        }

        /// <summary>
        /// 最大长度
        /// </summary>
        public int? MaxLength { get; set; }

        /// <summary>
        /// 指定最大长度
        /// </summary>
        public bool MaxLengthSpecified
        {
            get { return MaxLength.HasValue; }
        }

        /// <summary>
        /// 精确度
        /// </summary>
        public byte? Precision { get; set; }
        /// <summary>
        /// 指定精确度
        /// </summary>
        public bool PrecisionSpecified
        {
            get { return Precision.HasValue; }
        }

        /// <summary>
        /// 范围
        /// </summary>
        public int? Scale { get; set; }

        /// <summary>
        /// 指定范围
        /// </summary>
        public bool ScaleSpecified
        {
            get { return Scale.HasValue; }
        }

        /// <summary>
        /// 默认值
        /// </summary>
        public string Default { get; set; }

        #endregion

        #region 自定义扩展

        /// <summary>
        /// 说明
        /// </summary>
        public string Explain { get; set; }

        #endregion
    }
}