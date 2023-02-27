using System.ComponentModel.DataAnnotations;

namespace NumRotTestTecnnicalAPI.Persistence.Entity.DataTransferObjects {
    public class InfoUsersForCreationDto {
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
        [Required(ErrorMessage = "Input TypeUser is required")]

        public int? TypeUserId { get; set; }
        [Required(ErrorMessage = "Input Gender is required")]

        public int? GenderId { get; set; }
    }
}
