using System.ComponentModel.DataAnnotations;
using TaskManager.Areas.Identity.Data;

namespace TaskManager.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Title { get; set; }

        [Required, StringLength(400)]
        public string Description { get; set; }

        public string StatusId { get; set; }
        public virtual Status Status { get; set; }

        public DateTime PublishDate { get; set; } = DateTime.Now;

        public DateTime? CompletionDate { get; set; } 

        public string PublisherId { get; set; }
        public virtual TaskManagerUser Publisher { get; set; }

        public string? AssigneeId { get; set; }
        public virtual TaskManagerUser? Assignee { get; set; }

    }
}
