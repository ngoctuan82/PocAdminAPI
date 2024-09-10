using System;

namespace PocAdmin.Core.Entities
{
    public class FileEvent
    {
        public int Id { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string Directory { get; set; } = String.Empty;
        public DateTime Created { get; set; }
    }
}
