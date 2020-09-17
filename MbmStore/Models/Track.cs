using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Track
    {
        // Fields

        // Properties
        public string Title { get; set; }
        public TimeSpan Length { get; set; }
        public string Composer { get; set; }

        // Constructors

        public Track() { }
        public Track(string title, TimeSpan length)
        {
            Title = title;
            Length = length;
        }
    }
}
