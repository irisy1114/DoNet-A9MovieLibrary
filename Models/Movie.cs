using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MovieLibrary.Models
{
    public class Movie : Media
    {
        public string Genres { get; set; }

        public override string ToString()
        {
            return $"Movie: {Title}, {Genres}";
        }
    }
}
