using System.ComponentModel.DataAnnotations;

namespace Blog.Core.Domain
{
    public class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
        }
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(120)] //true nvarchar false varchar
        public string Title { get; set; }
        [Required, MaxLength(150)]


        public int? CategoryId { get; set; } = 0;//Temp
        public int? UserId { get; set; } = 0;//Temp
        [Required, MaxLength(250)]
        public string Introdution { get; set; }
        [Required]
        public string Content { get; set; }

        public bool? IsPublished { get; set; }
        public DateTime? PublishedOn { get; set; } = DateTime.Now;
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
