namespace PocAdmin.Core.Entities
{
    public class FileEvent
    {
        public int Id { get; set; }
        public int ReferenceId { get; set; }
        public string FileName { get; set; }
        public DateTime EventDate { get; set; }
    }
}
