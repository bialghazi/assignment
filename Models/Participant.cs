namespace Activity.API.Models {
    public class Participant {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Activity { get; set; }
        public string Comments { get; set; }
    }
}