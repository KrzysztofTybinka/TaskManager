using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class Status
    {
        [Key, StringLength(20)]
        public string Id { get; set; }
    }
}
