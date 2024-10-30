

using Blog.Core.Domain;
using Blog.Core.Repositories;

namespace Blog.Persistence.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(BlogContext context) : base(context)
        {
        }



    }
}