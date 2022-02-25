using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApi.Models
{
    public partial class ZrouteDetail
    {
        public int RouteId { get; set; }
        public int FlightId { get; set; }
        public string RouteDescription { get; set; }
    }
}
