using NumRotTestTecnnicalAPI.Persistence.Entity;
using NumRotTestTecnnicalAPI.Persistence.Repository.RepositoryBase;

namespace NumRotTestTecnnicalAPI.Persistence.Repository.Invoice {
    public class InvoiceRepository : RepositoryBase<Invoices>, IInvoiceRepository {
        public InvoiceRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }
        public void CreatedInvoices(Invoices invoices) {
            Create(invoices);
        }
        public IEnumerable<Invoices> GetAllInvoices() {
            return FindAll()
                .ToList();
        }

        public void DeleteInvoices(Invoices invoices) {
            Delete(invoices);
        }

    }
}
