using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NumRotTestTecnnicalAPI.Persistence.Entity;
using NumRotTestTecnnicalAPI.Persistence.Entity.DataTransferObjects;
using NumRotTestTecnnicalAPI.Persistence.Repository.Wrapper;
using System.Collections.Generic;

namespace NumRotTestTecnnicalAPI.Controllers {
    [Route("api/invoices")]
    [ApiController]
    public class InvoicesController : ControllerBase {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public InvoicesController(IRepositoryWrapper repository, IMapper mapper) {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllInvoices() {
            try {
                var findInvoices = _mapper.Map<IEnumerable<Invoices>>(_repository.Invoice.GetAllInvoices());
                if (findInvoices is null) {
                    return Ok(ResponseFactory.Crear(false, "¡Invoices not found!", findInvoices));
                }
                return Ok(ResponseFactory.Crear(true, "¡Invoices found successfully!", findInvoices));
            } catch (Exception ex) {
                return StatusCode(500, ex + "Internal server error");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetAllInfoUsers(int id) {
            try {
                var findInvoices = _mapper.Map<IEnumerable<Invoices>>(_repository.Invoice.GetAllInvoicesByInfoUserId(id));
                if (findInvoices.Count() <= 0) {
                    return Ok(ResponseFactory.Crear(false, "¡Invoices not found!", findInvoices));
                }
                return Ok(ResponseFactory.Crear(true, "¡Invoices found successfully!", findInvoices));
            } catch (Exception ex) {
                return StatusCode(500, ex + "Internal server error");
            }
        }

        [HttpPost]
        public IActionResult CreateInvoice([FromBody] InvoiceForCreationDto invoiceForCreationDto) {
            try {
                if (invoiceForCreationDto is null) {
                    return Ok(ResponseFactory.Crear(false, "Please enter a values corrects.", ""));
                }
                if (!ModelState.IsValid) {
                    return getErrors();
                }

                var invoiceEntity = _mapper.Map<Invoices>(invoiceForCreationDto);
                _repository.Invoice.CreatedInvoices(invoiceEntity);
                _repository.Save();
                var createdInvoice = _mapper.Map<Invoices>(invoiceEntity);
                return Ok(ResponseFactory.Crear(
                    true,
                    "Invoice created successfully.",
                    CreatedAtRoute("InfoUserById", new { id = createdInvoice.invoice_id }, createdInvoice).Value)
                    );

            } catch (Exception ex) {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteInvoice(int id) {
            try {
                var invoice = _repository.Invoice.GetInvoiceById(id);
                if (invoice == null) {
                    return Ok(ResponseFactory.Crear(false, "Invoice not existing with this id.", ""));
                }
                _repository.Invoice.DeleteInvoices(invoice);
                _repository.Save();
                return Ok(ResponseFactory.Crear(true, "Invoice deleted successfully.", invoice));
            } catch (Exception ex) {
                return StatusCode(500, "Internal server error");
            }
        }
        private IActionResult getErrors() {
            return Ok(ModelState
           .Where(x => x.Value.Errors.Any())
           .ToDictionary(x => x.Key, x => x.Value.Errors.Select(error => error.ErrorMessage)));
        }

    }
}
