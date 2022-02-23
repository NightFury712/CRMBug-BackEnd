using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    /// <summary>
    /// Thông tin vấn đề
    /// </summary>
    /// Author: HHDang 23.2.2022
    public class Issue : BaseEntity
    {
        #region Properties
        public string ID { get; set; }
        public int TypeID { get; set; }
        public string TypeIDText { get; set; }
        public string Subject { get; set; }
        public int PriorityID { get; set; }
        public string PriorityText { get; set; }
        public string AssignedTo { get; set; }
        public string FoundInBuild { get; set; }
        public string IntergratedBuild { get; set; }

        #endregion
    }
}
