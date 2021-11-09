﻿using Domain.Entities;
using Domain.RepositoryInterface;
using Infrastructure.Data;

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
        public IEnumerable<Account> GetAll() => _context.Accounts;

        //Get Account by Id
        public Account GetById(int id) => _context.Accounts.FirstOrDefault(x => x.AccountId == id);

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
    }
}