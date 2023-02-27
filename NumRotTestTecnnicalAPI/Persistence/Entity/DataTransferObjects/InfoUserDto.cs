namespace NumRotTestTecnnicalAPI.Persistence.Entity.DataTransferObjects {
    public class InfoUserDto {
        public int info_user_id { get; set; }
        public string? identification { get; set; }
        public string? password { get; set; }
        public string? name { get; set; }

        public string? second_name { get; set; }
        public string? last_name { get; set; }

        public string? second_last_name { get; set; }
        public string? Phone { get; set; }
        public string? email { get; set; }
        public string? address { get; set; }
        public string? age { get; set; }
        public Genders? Gender { get; set; }
        public TypeUsers? TypeUser { get; set; }
    }
}
