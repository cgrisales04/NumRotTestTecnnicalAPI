using NumRotTestTecnnicalAPI.Persistence.Entity;
using NumRotTestTecnnicalAPI.Persistence.Repository.InfoUser;
using NumRotTestTecnnicalAPI.Persistence.Repository.Invoice;

namespace NumRotTestTecnnicalAPI.Persistence.Repository.Wrapper {

    public class RepositoryWrapper : IRepositoryWrapper{
        private RepositoryContext _repoContext;
        private IInfoUsersRepository _infoUsersRepository;
        private IInvoiceRepository _invoiceRepository;

        public IInfoUsersRepository InfoUser {
            get {
                if (_infoUsersRepository == null) {
                    _infoUsersRepository = new InfoUsersRepository(_repoContext);
                }
                return _infoUsersRepository;
            }
        }

        public IInvoiceRepository Invoice {
            get {
                if (_invoiceRepository == null) {
                    _invoiceRepository = new InvoiceRepository(_repoContext);
                }
                return _invoiceRepository;
            }
        }

        public RepositoryWrapper(RepositoryContext repositoryContext) {
            _repoContext = repositoryContext;
        }
        public void Save() {
            _repoContext.SaveChanges();
        }
    }
}
