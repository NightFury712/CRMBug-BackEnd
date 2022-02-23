using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Attribute
{
    public class Attribute
    {
        #region Attributes
        /// <summary>
        /// Attribute quy định tên bảng
        /// </summary>
        public class TableNameAttribute: Attribute
        {
            public string Name;

            public TableNameAttribute()
            {
                Name = string.Empty;
            }

            public TableNameAttribute(string name)
            {
                Name = name;
            }
        }
        #endregion
    }
}
