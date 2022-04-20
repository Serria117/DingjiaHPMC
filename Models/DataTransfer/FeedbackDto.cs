using DingjiaHpmc.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace DingjiaHpmc.Models.DataTransfer
{
    public class FeedbackDto : IDataTransfer<Feedback, int?>
    {
        public int Id { get; set; }

        [EmailAddress(ErrorMessage = "Hãy nhập email hợp lệ (ví dụ: abc@email.com)")]
        public string? Email { get; set; }

        [RegularExpression("^[0-9]{8-15}$"), Required(ErrorMessage = "Số điện thoại là bắt buộc")]
        public string Phone { get; set; } = null!;

        [StringLength(1000, MinimumLength = 3, ErrorMessage = "Hãy gửi thông điệp có từ 3 đến 1000 ký tự. Cảm ơn!")]
        public string? Message { get; set; }

        public DateTime DateCreate { get; set; } = DateTime.Now;

        public DateTime? DateUpdate { get; set; }

        public bool? IsAnswered { get; set; } = false;

        [StringLength(200, MinimumLength = 3, ErrorMessage = "Hãy nhập tên của bạn ít nhất 3 ký tự")]
        public string ClientName { get; set; } = null!;

        public Feedback Build(int? id)
        {
            var feedback = new Feedback()
            {
                Email = Email,
                Phone = Phone,
                Message = Message,
                DateCreate = DateCreate,
                DateUpdate = DateUpdate,
                IsAnswered = IsAnswered,
                ClientName = ClientName
            };
            if (id != null) { feedback.Id = id.Value; }


            return feedback;
        }

        public void Extract(Feedback entity)
        {
            Email = entity.Email;
            Phone = entity.Phone;
            Message = entity.Message;
            DateCreate = entity.DateCreate;
            DateUpdate = entity.DateUpdate;
            IsAnswered = entity.IsAnswered;
            ClientName = entity.ClientName;
        }
    }
}
