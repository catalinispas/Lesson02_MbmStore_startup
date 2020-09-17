using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {
        // Fields

        // Properties

        public string Artist { get; set; }

        public string Label { get; set; }

        public short Released { get; set; }

        public TimeSpan PlayingTime
        {
            get
            {
                TimeSpan totalTime = new TimeSpan();
                foreach (Track track in Tracks)
                {
                    totalTime += track.Length;
                }
                return totalTime;
            }
        }

        public List<Track> Tracks { get; } = new List<Track>();

        // Constructors

        public MusicCD(string artist, string title, decimal price, short released) : base( title, price )
        {
            Artist = artist;
            Released = released;
        }


        // Method

        public void AddTrack(Track track)
        {
            Tracks.Add(track);
        }
    }
}
