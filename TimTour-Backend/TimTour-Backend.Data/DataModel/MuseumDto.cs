﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimTour_Backend.Data.DataModel
{
    public class MuseumDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string? WebSiteURL { get; set; }
    }
}

