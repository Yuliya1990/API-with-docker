using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyLifeWebAPI
{
    public partial class Cleaning
    {
        [Key]
        public int Cleaningid { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; } = null!;

        public List<Component> Components { get; set; } = new();
    }
}
