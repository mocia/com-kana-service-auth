using Com.Kana.Service.Auth.Lib.BusinessLogic.Interfaces;
using Com.Kana.Service.Auth.Lib.Models;
using Com.Kana.Service.Auth.Lib.ViewModels;
using Com.Kana.Service.Auth.Test.Utils;
using Com.Kana.Service.Auth.WebApi.Controllers.v1;

namespace Com.Kana.Service.Auth.Test.Controllers
{
    public class AccountsControllerTest : BaseControllerTest<AccountsController, Account, AccountViewModel, IAccountService>
    {
    }
}
