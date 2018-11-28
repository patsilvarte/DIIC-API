﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeaconApi.models
{
    public class BeaconItem
    {
        public long Id { get; set; }
        [Key]
        public string BeaconId { get; set; }
        public string Name { get; set; }
        public string ExtraInfo { get; set; }
    }
}
