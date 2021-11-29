using Domain.Entities;
using Domain.RepositoryInterface;
using Infrastructure.Data;

namespace Infrastructure.Repositories.Other
{
    internal class CommentRepository : ICommentRepository
    {
        private readonly MyPostsPortalContext _context;
        public CommentRepository(MyPostsPortalContext context)
        {
            _context = context;
        }
        public Comment Add(Comment ob)
        {
            _context.Add(ob);
            _context.SaveChanges();
            return ob;
        }

        public void Delete(Comment ob)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id) => _context.Comments.FirstOrDefault(x => x.CommentId == id);

        public void Update(Comment ob)
        {
            _context.Update(ob);
            _context.SaveChanges();
        }
        //check if account exists
        public bool AcocuntExist(int id) => _context.Accounts.Any(x => x.AccountId == id);
        //check if post exists
        public bool PostExist(int id) => _context.Posts.Any(x => x.PostId == id);

        public string GetUsername(int id) => _context.Accounts.
            Where(x => x.AccountId == id).
            Select(c => c.Username).
            FirstOrDefault();
    }
}
