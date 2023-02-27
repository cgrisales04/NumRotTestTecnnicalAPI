using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace NumRotTestTecnnicalAPI.Persistence.Entity
{
    [Table("tbl_type_users")]
    public class TypeUsers
    {
        [Key]
        public int type_user_id { get; set; }
        [Required(ErrorMessage = "File name type of users is required")]
        public string? name { get; set; }
    }
}
