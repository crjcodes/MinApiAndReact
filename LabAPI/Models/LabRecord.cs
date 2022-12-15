namespace LabAPI.Models
{
    public class LabRecord
    {
        public string Name { get; set; } = string.Empty;
        //public string Category { get; set; }
        //public string Subcategory { get; set; }

        public List<LabMeasurement> LabMeasurements { get; set; } = new List<LabMeasurement>();
    }
}
