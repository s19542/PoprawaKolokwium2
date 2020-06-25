
using System.Collections.Generic;

namespace PoprawaKolokwium2.Models
{
    public class Artist
    {
        public int IdArtist { get; set; }
        public string Nickname { get; set; }

        public ICollection<ArtistEvent> ArtistEvents { get; set; } 
    }
}