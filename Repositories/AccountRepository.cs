using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly AccountDAO _accountDAO;

        public AccountRepository()
        {
            _accountDAO = new AccountDAO();
        }

        public AccountMember GetAccountById(string accountID) => _accountDAO.GetAccountById(accountID);
    }
}
