using Domain.Entities;
using Domain.RepositoryInterface;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly MyPostsPortalContext _context;

        public PostRepository(MyPostsPortalContext context)
        {
            _context = context;
        }

        public IEnumerable<Post> GetAll() => _context.Posts.
            Include(x => x.Content).
            Include(x => x.Comments);

        public Post GetById(int id) => _context.Posts.
            Include(_x => _x.Content).
            FirstOrDefault(x => x.PostId == id);

        public Post Add(Post ob)
        {
            _context.Posts.Add(ob);
            _context.SaveChanges();
            return ob;
        }

        public void Update(Post ob)
        {
            _context.Posts.Update(ob);
        }

        public void Delete(Post ob)
        {
            _context.Posts.Remove(ob);
            _context.SaveChanges();
        }

        //check if account with current id exists
        public bool AccountExist(int id) => _context.Accounts.Any(x => x.AccountId == id);
        public string GetUsername(int id)=> _context.Accounts.Where(x=>x.AccountId==id).Select(c=>c.Username).ToString();
    }
}
