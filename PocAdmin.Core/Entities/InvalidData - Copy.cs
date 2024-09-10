using System;

namespace PocAdmin.Core.Entities
{
    public class EventSimple
    {
        public int Event_Id { get; set; }
        public int Event_FileId { get; set; }
        public string? CA_RefId { get; set; }
    }
}
