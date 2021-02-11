using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day1B.Models
{
    public class Book
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Author { get; set; }
        public String Publication { get; set; }

        public String Description { get; set; }

        public String CoverImage { get; set; }

    }
}
