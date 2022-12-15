namespace LabAPI.Models
{
    public class LabMeasurement
    {
        public DateTime DateMeasured { get; set; } = DateTime.MinValue;
        public float Value { get; set; } = 0;
        public string Units { get; set; } = string.Empty;
    }
}
