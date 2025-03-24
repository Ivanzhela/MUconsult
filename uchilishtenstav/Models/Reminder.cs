namespace uchilishtenstav.Models
{
    public class Reminder
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; } // active, completed
    }
}
