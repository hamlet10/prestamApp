using PrestamApp.Domain.Entities;
using System.Linq;

namespace PrestamApp.Persistence.Extensions
{
    public static class CollectorExtensions
    {
        public static Collector AddZones(this Collector collector, params int[] zones)
        {

            foreach (var zone in zones)
            {
                collector.ZoneCollectors.Add(new ZoneCollector { ZoneId = zone });
            }
            return collector;
        }

        public static Collector UpdateZones(this Collector collector, params int[] zones)
        {
            foreach (var zone in zones)
            {
                if (!collector.ZoneCollectors.Any(zc => zc.ZoneId == zone))
                {
                    collector.ZoneCollectors.Add(new ZoneCollector { ZoneId = zone });
                }
            }

            foreach (var item in collector.ZoneCollectors.ToList())
            {
                if (!zones.Any(z => z == item.ZoneId))
                {
                    collector.ZoneCollectors.Remove(item);
                }
            }
            return collector;
        }

    }
}
