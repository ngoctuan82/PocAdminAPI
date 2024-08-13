namespace PocAdmin.Core.Entities
{
    public class InvalidData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime EffectiveDate { get; set; }
        public decimal Value { get; set; }
        public int ReferenceId { get; set; }
    }
}
