using System;

namespace PocAdmin.Core.Entities
{
    public class InvalidData
    {
        public int MappedId { get; set; }
        public int Event_Id { get; set; }
        public int? Event_ActionId { get; set; }
        public int? Event_SecId { get; set; }
        public int? Event_FileId { get; set; }
        public DateTime? Event_EffectiveDate { get; set; }
        public DateTime? Event_AmmendmentDate { get; set; }
        public string Event_FileName { get; set; } = String.Empty;
        public int Ca_Id { get; set; }
        public DateTime? Ca_EffectiveDate { get; set; }
        public DateTime? Ca_AmmendmentDate { get; set; }
        public DateTime Ca_Created { get; set; }
        public string? Ca_RefId { get; set; }
    }
}
