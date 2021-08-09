using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoIndentityCore.Areas.Identity.Data
{
    public class ITask
    {
        [Key]
        [Display(Name = "Mã công việc")]
        public string TaskId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Tiêu đề")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Nội dung")]
        public string Contentt { get; set; }
        [Required]
        [Display(Name = "Thời gian bắt đầu")]
        [Column(TypeName = "date")]
        public DateTime TimeStart { get; set; }
        [Required]
        [Display(Name = "Thời gian kết thúc")]
        [Column(TypeName = "date")]
        public DateTime TimeEnd { get; set; }
        [Display(Name = "Trạng thái")]
        public string TaskStatus { get; set; }
        public ICollection<UserTask> UserTasks { get; set; }
    }
}
