using Microsoft.EntityFrameworkCore;
using NumRotTestTecnnicalAPI.Persistence.Entity;
using NumRotTestTecnnicalAPI.Persistence.Repository.RepositoryBase;

namespace NumRotTestTecnnicalAPI.Persistence.Repository.Invoice {
    public class InvoiceRepository : RepositoryBase<Invoices>, IInvoiceRepository {
        public InvoiceRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }
        public void CreatedInvoices(Invoices invoices) {
            Create(invoices);
        }
        public IEnumerable<Invoices> GetAllInvoicesByInfoUserId(int id) {
            return FindByCondition(invoice => invoice.InfoUserId.Equals(id))
                .ToList();
        }
        public IEnumerable<Invoices> GetAllInvoices() {
            return FindAll().ToList();
        }

        public Invoices GetInvoiceById(int id) {
            return FindByCondition(invoice => invoice.invoice_id.Equals(id))
                .FirstOrDefault();
        }

        public void DeleteInvoices(Invoices invoices) {
            Delete(invoices);
        }

    }
}
