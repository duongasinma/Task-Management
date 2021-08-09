using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoIndentityCore.Areas.Identity.Data
{   
    public class UserTask
    {
        [Key]
        [Column(Order = 0)]
        public string TaskId { get; set; }
        [Key]       
        [Column(Order = 1)]
        public string UserId { get; set; }       
        public string UserTaskStatus { get; set; }
        [ForeignKey("TaskId")]
        public  ITask Task { get; set; }
        [ForeignKey("UserId")]
        public DemoIndentityCoreUser User{ get; set; }


    }
}
