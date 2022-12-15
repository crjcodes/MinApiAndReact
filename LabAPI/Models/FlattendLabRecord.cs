namespace LabAPI.Models
{
    public class FlattenedLabRecord
    {
        public string Name { get; set; } = string.Empty;
        //public string Category { get; set; }
        //public string Subcategory { get; set; }

        public DateTime DateMeasured { get; set; } = DateTime.MinValue;
        public float Value { get; set; } = 0;
        public string Units { get; set; } = string.Empty;
    }
}
