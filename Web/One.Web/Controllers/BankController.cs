namespace One.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using Common.Mapping;
    using Services.Data;
    using ViewModels.Bank;

    public class BankController : BaseController
    {
        private IBanksService banks;
        private IBankAccountsService bankAccounts;

        public BankController(IBanksService banks, IBankAccountsService bankAccounts)
        {
            this.banks = banks;
            this.bankAccounts = bankAccounts;
        }

        // GET: Bank
        public ActionResult Index()
        {
            var bankAccounts = this.bankAccounts.GetRandomBankAccounts(3).To<BankAccountViewModel>().ToList();
            var banks = this.banks.GetAll().To<BankViewModel>().ToList();
            var viewModel = new IndexViewModel
            {
                BankAccounts = bankAccounts,
                Banks = banks,
            };

            return this.View(viewModel);
        }
    }
}
