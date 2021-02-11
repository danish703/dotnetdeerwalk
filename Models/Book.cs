using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day1B.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Author { get; set; }

        [EmailAddress]
        public String Publication { get; set; }

        public String Description { get; set; }

        [Url]
        public String CoverImage { get; set; }

    }
}
