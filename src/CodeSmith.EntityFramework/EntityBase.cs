﻿using System.Xml.Serialization;

namespace CodeSmith.EntityFramework
{
    /// <summary>
    /// 是否已经处理
    /// </summary>
    public class EntityBase
    {
        [XmlIgnore]
        public bool IsProcessed { get; set; }
    }
}