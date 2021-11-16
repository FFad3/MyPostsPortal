using Domain.Entities;
using Domain.RepositoryInterface;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly MyPostsPortalContext _context;

        public AccountRepository(MyPostsPortalContext context)
        {
            _context = context;
        }   

        //Get all Accounts
        public IEnumerable<Account> GetAll() => _context.Accounts.
            Include(x=>x.Details);

        //Get Account by Id
        public Account GetById(int id) => _context.Accounts.
            SingleOrDefault(x => x.AccountId == id);

        //Add new Account
        public Account Add(Account ob)
        {
            _context.Accounts.Add(ob);
            _context.SaveChanges();
            return ob;
        }

        //Update Account
        public void Update(Account ob)
        {
            _context.Update(ob);
            _context.SaveChanges();
        }

        //Delete Account
        public void Delete(Account ob)
        {
            _context.Remove(ob);
            _context.SaveChanges();
        }

        //Login
        public Account Login(string Login, string Passowrd) => _context.Accounts.
            Include(x => x.Details).
            SingleOrDefault(x => x.Login == Login && x.Password == Passowrd);

        //Check if login is used
        public bool LoginIsAvaiable(string Login) => _context.Accounts.Any(x => x.Login == Login);
    }
}
