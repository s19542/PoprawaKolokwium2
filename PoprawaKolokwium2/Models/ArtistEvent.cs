using System;

namespace PoprawaKolokwium2.Models
{
    public class ArtistEvent
    {
        public int IdEvent { get; set; }
        public int IdArtist { get; set; }
        public DateTime PerfomanceDate { get; set; }
        public Event Event { get; set; }
        public Artist Artist { get; set; }

    }
}