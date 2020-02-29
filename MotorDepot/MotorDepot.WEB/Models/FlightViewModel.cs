﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MotorDepot.WEB.Models
{
    public class FlightViewModel
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string DeparturePlace { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string ArrivalPlace { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreateDate { get; set; }
        [Required]
        public string Status { get; set; }
        public string StatusColor { get; set; }
        public string AutoName { get; set; }
        public string AutoNumber { get; set; }
        public string DriverEmail { get; set; }
        public string DriverName { get; set; }
    }
}