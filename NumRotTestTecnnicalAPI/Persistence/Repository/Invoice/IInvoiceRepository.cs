using NumRotTestTecnnicalAPI.Persistence.Entity;

namespace NumRotTestTecnnicalAPI.Persistence.Repository.Invoice {
    public interface IInvoiceRepository{
        IEnumerable<Invoices> GetAllInvoices();
        void CreatedInvoices(Invoices invoice);

        void DeleteInvoices(Invoices invoice);

    }
}
