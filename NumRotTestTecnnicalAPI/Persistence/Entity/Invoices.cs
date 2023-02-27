using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NumRotTestTecnnicalAPI.Persistence.Entity {
    public class Invoices {
        [Key]
        public int invoice_id { get; set; }
        [Required(ErrorMessage = "Input date_issuei is required")]
        public string date_issue { get; set; }

        [Required(ErrorMessage ="Input totally is required")]
        public int value_totally { get; set; }

        [ForeignKey(nameof(InfoUsers))]
        [Column("info_user_id_fk")]
        public int? InfoUserId { get; set; }
        public InfoUsers? InfoUsers { get; set; }
    }
}
