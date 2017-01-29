using System;

namespace VideoCollection.Data.Models
{
    public class DigitalAsset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? FileModified { get; set; }
        public long? Size { get; set; }
        public string ContentType { get; set; }
        public string RelativePath { get { return $"api/digitalasset/serve?uniqueid={UniqueId}"; } }
        public byte[] Bytes { get; set; } = new byte[0];
        public Guid? UniqueId { get; set; } = Guid.NewGuid();
        public bool IsDeleted { get; set; }
    }
}
