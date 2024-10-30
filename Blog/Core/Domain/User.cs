using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Blog.Core.Domain
{
    public class User
    {

        [Key]
        public int Id { get; set; }

        [Required, MaxLength(25), Unicode(false)] //true nvarchar false varchar
        public string FirstName { get; set; }
        [MaxLength(25), Unicode(false)] //true nvarchar false varchar
        public string? LastName { get; set; }


        [Required, MaxLength(100), Unicode(false)] //true nvarchar false varchar
        public string Email { get; set; }


        [Required, MaxLength(30)]
        public string Salt { get; set; }

        [Required, MaxLength(100)]
        public string Hash { get; set; }

    }
}
