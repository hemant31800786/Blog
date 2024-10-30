namespace Blog.Core.Domain
{
    public class Comment
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Post Post { get; set; }
    }
}
