using Domain.Entities;
using Domain.RepositoryInterface;
using Infrastructure.Data;

namespace Infrastructure.Repositories.Other
{
    public class OpinionRepository : IOpinionRepository
    {
        private readonly MyPostsPortalContext _context;
        public OpinionRepository(MyPostsPortalContext context)
        {
            _context = context;
        }

        public IEnumerable<Opinion> GetAll()
        {
            throw new NotImplementedException();
        }

        public Opinion GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Opinion Add(Opinion ob)
        {
            _context.Add(ob);
            return ob;
        }

        public void Delete(Opinion ob)
        {
            throw new NotImplementedException();
        }

        public void Update(Opinion ob)
        {
            throw new NotImplementedException();
        }

        //check if account exists
        public bool AcocuntExist(int id) => _context.Accounts.Any(x => x.AccountId == id);
        //check if post exists
        public bool PostExist(int id) => _context.Posts.Any(x => x.PostId == id);
    }
}
