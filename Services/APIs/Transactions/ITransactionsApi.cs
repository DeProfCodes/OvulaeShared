using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Models.Transactions;
using OvulaeShared.Models.WebApi;
using OvulaeShared.ViewModel.Affiliates;

namespace OvulaeShared.Services.APIs.Transactions
{
    public interface ITransactionsApi
    {
        public Task<List<Transaction>> GetUserTransactions(SecureApiRequest data);
    }
}
