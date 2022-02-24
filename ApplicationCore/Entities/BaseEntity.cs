﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ApplicationCore.Enumeration.Enumeration;

namespace ApplicationCore.Entities
{
    public class BaseEntity
    {
        #region Properties
        public int ID { get; set; }
        public EntityState EntityState { get; set; } = EntityState.Edit;
        /// <summary>
        /// Thời gian tạo
        /// </summary>
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// Người tạo
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// Thời gian thay đổi
        /// </summary>
        public DateTime? ModifiedDate { get; set; }
        /// <summary>
        /// Người thay đổi
        /// </summary>
        public string ModifiedBy { get; set; }
        #endregion
    }
}
