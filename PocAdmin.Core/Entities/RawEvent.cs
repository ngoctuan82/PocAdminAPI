namespace PocAdmin.Core.Entities
{
    public class RawEvent
    {
        public int Id { get; set; }
        public int FileSourceId { get; set; }
        public string? ReferenceId { get; set; }
    }
}
