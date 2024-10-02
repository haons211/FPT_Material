using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository iAccountRepository;

        public AccountService()
        {
            iAccountRepository = new AccountRepository();
        }
        public AccountMember GetAccountMemberById(string accountId)
        {
            return iAccountRepository.GetAccountMemberById(accountId);
        }
    }
}
