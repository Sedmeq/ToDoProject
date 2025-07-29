using System.ComponentModel.DataAnnotations;

namespace UsersApp.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Title { get; set; } = string.Empty;

        public bool IsCompleted { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string UserId { get; set; } = string.Empty;

        // Navigation property
        public Users? User { get; set; }
    }
}
