using AlarmSystem.Models;
using System.Collections.Generic;

namespace AlarmSystem.ViewModels
{
    public class SummaryCarrierFaultViewModel
    {
        public CarrierSummaryModel Summary { get; set; } = new CarrierSummaryModel();

        public List<SummaryCarrierFaultModel> Details { get; set; }
            = new List<SummaryCarrierFaultModel>();

        /// <summary>
        /// Daily time-series of open faults broken down by platform.
        /// Drives the Trend &amp; Time-Series Analysis section of the dashboard.
        /// </summary>
        public List<FaultTrendModel> Trend { get; set; }
            = new List<FaultTrendModel>();
    }
}