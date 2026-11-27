namespace AlarmSystem.Models
{
    /// <summary>
    /// Represents a single day in the time-series trend of open faults.
    /// Holds the daily fault count broken down by platform.
    /// </summary>
    public class FaultTrendModel
    {
        public DateTime Date { get; set; }
        public int CEA { get; set; }
        public int MSAN { get; set; }
        public int SLBN { get; set; }
        public int Total { get; set; }
    }
}
