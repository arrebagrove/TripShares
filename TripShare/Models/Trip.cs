﻿using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripShare.Models
{
    public class Trip
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public DateTime Date{ get; set; }
        [Required]
        public DateTime CancelDate { get; set; }
        [Required]
        public string DriverId { get; set; }
        [Required, MinLength(2)]
        public string From { get; set; }
        [Required, MinLength(2)]
        public string To { get; set; }
        public string AdditionalWay { get; set; }
        [Required]
        [Range(1, 20, ErrorMessage = "Please enter a value bigger than {1} and less than {2}")]
        public int SeatsCount { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int Price { get; set; }
        public List<Passenger> Passengers { get; set; }
        public int Deposit { get; set; }
    }
}
