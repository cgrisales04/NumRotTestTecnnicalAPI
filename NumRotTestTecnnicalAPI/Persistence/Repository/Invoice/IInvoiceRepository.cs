using NumRotTestTecnnicalAPI.Persistence.Entity;

namespace NumRotTestTecnnicalAPI.Persistence.Repository.Invoice {
    public interface IInvoiceRepository {
        IEnumerable<Invoices> GetAllInvoicesByInfoUserId(int id);
        void CreatedInvoices(Invoices invoice);

        void DeleteInvoices(Invoices invoice);

        Invoices GetInvoiceById(int id);

        IEnumerable<Invoices> GetAllInvoices();

    }
}
