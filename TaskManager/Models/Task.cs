using System.ComponentModel.DataAnnotations;
using TaskManager.Areas.Identity.Data;

namespace TaskManager.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        //public int Status { get; set; }

        public DateTime PublishDate { get; set; } = DateTime.Now;

        public DateTime? CompletionDate { get; set; } 

        public string PublisherId { get; set; }
        public virtual TaskManagerUser Publisher { get; set; }

        public string AssigneeId { get; set; }
        public virtual TaskManagerUser Assignee { get; set; }

    }
}
