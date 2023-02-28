using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NumRotTestTecnnicalAPI.Persistence.Entity {
    [Table("tbl_invoices")]
    public class Invoices {
        [Key]
        public int? invoice_id { get; set; }
        public DateTime? date_issue { get; set; }

        [Required(ErrorMessage ="Input totally is required")]
        public int value_totally { get; set; }

        [ForeignKey(nameof(InfoUsers))]
        [Column("info_user_id_fk")]
        public int? InfoUserId { get; set; }
    }
}
