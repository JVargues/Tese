using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public class Blog
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Text { get; set; }
    }
}
