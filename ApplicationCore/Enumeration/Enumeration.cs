using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Enumeration
{
    public class Enumeration
    {
        /// <summary>
        /// Trạng thái của object
        /// </summary>
        public enum EntityState
        {
            /// <summary>
            /// Thêm mới
            /// </summary>
            Add = 1,
            /// <summary>
            /// Cập nhật
            /// </summary>
            Edit = 2,
            /// <summary>
            /// Xóa
            /// </summary>
            Delete = 3
        }

        /// <summary>
        /// Code để xác định phản hồi của request
        /// </summary>
        public enum Code
        {
            /// <summary>
            /// Dữ liệu hợp lệ
            /// </summary>
            IsValid = 100,
            /// <summary>
            /// Dữ liệu chưa hợp lệ
            /// </summary>
            NotValid = 900,
            /// <summary>
            /// Thành công
            /// </summary>
            Ok = 200,
            /// <summary>
            /// Thất bại
            /// </summary>
            BadRequest = 400,
            /// <summary>
            /// Thêm thành công
            /// </summary>
            Created = 201,
            /// <summary>
            /// Có lỗi xảy ra
            /// </summary>
            Exception = 500,
        }
    }
}
