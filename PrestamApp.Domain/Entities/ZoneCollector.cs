namespace PrestamApp.Domain.Entities
{
    public class ZoneCollector
    {
        public int ZoneId { get; set; }
        public int CollectorId { get; set; }

        public Zone Zone { get; set; }
        public Collector Collector { get; set; }

    }
}