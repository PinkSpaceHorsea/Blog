using System.ComponentModel.DataAnnotations;

namespace Blog.Models;

public class Post
{
    public int Id { get; set; }

    [Required]
    public string? Title { get; set; }
    [Required]
    public string? Content { get; set; }
    public DateTime CreatedAt { get; set; }// = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Comment> Comments { get; set; }
}
