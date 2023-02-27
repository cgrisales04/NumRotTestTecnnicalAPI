using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NumRotTestTecnnicalAPI.Persistence.Entity
{
    [Table("tbl_genders")]
    public class Genders
    {
        [Key]
        public int gender_id { get; set; }
        [Required(ErrorMessage = "Input name of gender is required")]
        public string? Name { get; set; }
    }
}
