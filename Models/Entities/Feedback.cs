using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DingjiaHpmc.Models.Entities
{
    public partial class Feedback
    {
        public int Id { get; set; }

        [Display(Name = "Người gửi")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Hãy nhập tên của bạn ít nhất 3 ký tự")]
        public string ClientName { get; set; } = string.Empty;

        [RegularExpression("^[0-9]{8,12}", ErrorMessage = "Hãy nhập số điện thoại hợp lệ")]
        public string Phone { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "Hãy nhập email hợp lệ (ví dụ: abc@email.com)")]
        public string? Email { get; set; }

        [Display(Name = "Nội dung")]
        [StringLength(1000, MinimumLength = 3, ErrorMessage = "Hãy gửi thông điệp có từ 3 đến 1000 ký tự.")]
        public string? Message { get; set; }
        
        [Display(Name = "Ngày tạo")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy | HH:mm:ss}")]
        public DateTime DateCreate { get; set; } = DateTime.Now;

        [Display(Name = "Ngày cập nhật")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy | HH:mm:ss}")]
        public DateTime? DateUpdate { get; set; }
 
        [Display(Name = "Trạng thái")]
        public bool? IsAnswered { get; set; } = false;

        
    }
}
