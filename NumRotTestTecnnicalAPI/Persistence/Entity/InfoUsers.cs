using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NumRotTestTecnnicalAPI.Persistence.Entity {
    [Table("tbl_info_users")]
    public class InfoUsers {
        [Key]
        public int? info_user_id { get; set; }

        [Required(ErrorMessage = "Input Identification is required")]
        public string? identification { get; set; }

        [Required(ErrorMessage = "Password es un campo obligatorio")]
        public string? password { get; set; }

        [Required(ErrorMessage = "Input Name is required")]
        public string? name { get; set; }

        public string? second_name { get; set; }

        [Required(ErrorMessage = "Input Last Name is required")]
        public string? last_name { get; set; }

        public string? second_last_name { get; set; }
        public string? phone { get; set; }


        [Required(ErrorMessage = "Input Email is required")]
        public string? email { get; set; }


        [Required(ErrorMessage = "Input Address is required")]
        public string? address { get; set; }


        [Required(ErrorMessage = "Input Age is required")]
        public string? age { get; set; }

        [ForeignKey(nameof(Genders))]
        [Column("gender_id_fk")]
        public int? GenderId { get; set; }
        public Genders? Gender { get; set; }

        [ForeignKey(nameof(TypeUsers))]
        [Column("type_user_id_fk")]
        public int? TypeUserId { get; set; }
        public TypeUsers? TypeUser { get; set; }

    }
}
