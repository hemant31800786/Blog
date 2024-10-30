using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Blog.Core.Domain
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100), Unicode(false)] //true nvarchar false varchar
        public string Name { get; set; }
        [Required, MaxLength(125), Unicode(false)] //true nvarchar false varchar
        public string Slug { get; set; }
    }
}
