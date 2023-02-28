using System.ComponentModel.DataAnnotations;

namespace NumRotTestTecnnicalAPI.Persistence.Entity.DataTransferObjects {
    public class InvoiceForCreationDto {
        [Required(ErrorMessage = "Input value_totally is required")]
        public int value_totally { get; set; }
        [Required(ErrorMessage = "Input infoUserId is required")]
        public int infoUserId { get; set; }
    }
}
