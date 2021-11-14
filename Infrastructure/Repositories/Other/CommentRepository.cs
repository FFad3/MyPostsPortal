using Domain.Entities;
using Domain.RepositoryInterface;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Comment ob)
        {
            throw new NotImplementedException();
        }
    }
}
