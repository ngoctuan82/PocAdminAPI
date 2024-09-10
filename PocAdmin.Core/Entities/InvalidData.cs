using System;

namespace PocAdmin.Core.Entities
{
    public class InvalidData
    {
        public int MappedId { get; set; }
        public int Event_Id { get; set; }
        public int Event_ActionId { get; set; }
        public int Event_SecId { get; set; }
        public int Event_FileId { get; set; }
        public DateTime Event_EffectiveDate { get; set; }
        public DateTime Event_AmmendmentDate { get; set; }
        public string Event_FileName { get; set; } = String.Empty;
        public int CA_Id { get; set; }
        public int CA_EffectiveDate { get; set; }
        public int CA_AmmendmentDate { get; set; }
        public DateTime CA_Created { get; set; }
        public string? CA_RefId { get; set; }
    }
}
