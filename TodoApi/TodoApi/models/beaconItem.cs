using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.models
{
    public class BeaconItem
    {
        public long Id { get; set; }
        public long beaconId { get; set; }
        public string Name { get; set; }
        public string ExtraInfo { get; set; }
    }
}
