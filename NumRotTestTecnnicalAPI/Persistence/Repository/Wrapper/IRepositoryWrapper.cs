using NumRotTestTecnnicalAPI.Persistence.Repository.InfoUser;
using NumRotTestTecnnicalAPI.Persistence.Repository.Invoice;

namespace NumRotTestTecnnicalAPI.Persistence.Repository.Wrapper {
    public interface IRepositoryWrapper {
        IInfoUsersRepository InfoUser { get; }
        IInvoiceRepository Invoice { get; }
        void Save();
    }
}
