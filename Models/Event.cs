namespace Eventhut.Models
{
    public class Event{
        public int Id { get; set; }
        public string Title {get; set;}
        public string Vanue { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Description { get; set; }
        public string Organizer {get; set;}
        public string AboutOrganizer { get; set; }
        public bool IsOnline {get; set; }
        public int Price {get; set;}
        public string CoverImage { get; set; }
        public string OrganizerImage {get; set;}
    }
}
