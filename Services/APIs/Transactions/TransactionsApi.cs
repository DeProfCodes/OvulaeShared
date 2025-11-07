using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Helpers.API;
using OvulaeShared.Helpers.CommonFunctions;
using OvulaeShared.Models.Transactions;
using OvulaeShared.Models.WebApi;
using OvulaeShared.ViewModel.Account;
using OvulaeShared.ViewModel.Affiliates;

namespace OvulaeShared.Services.APIs.Transactions
{
    public class TransactionsApi : BaseApiService, ITransactionsApi
    {
        public TransactionsApi()
        {
            
        }

        #region CRUD - CREATE
        #endregion

        #region CRUD - READ

        public async Task<List<Transaction>> GetUserTransactions(SecureApiRequest data)
        {
            try
            {
                DefaultValueHelper.SetDefaults(data);

                var result = await _webAPI.PostDataObject<List<Transaction>>(OvulaeApiEndPoints.TRANSACTIONS.GET_USER_TRANSACTIONS, data);

                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        #endregion

        #region CRUD - UPDATE

        #endregion

    }
}
