
using Microsoft.EntityFrameworkCore;
using PoprawaKolokwium2.Exceptions;
using PoprawaKolokwium2.Models;
using System.Data;
using System.Linq;

namespace PoprawaKolokwium2.Services
{
    public class ArtistsDbService : IArtistsDbService
    {
        private ArtistDbContext _context;

        public ArtistsDbService(ArtistDbContext context)
        {
            _context = context;
        }

        public Artist GetArtist(int id)
        {
            var player = _context.Artists
                .Include(m => m.ArtistEvents)
                .FirstOrDefault(m => m.IdArtist == id);

            if (player == null)
            {
                throw new NoArtistException($"No artist with id={id}");
            }
            player.ArtistEvents = player.ArtistEvents.OrderByDescending(p => p.PerfomanceDate).ToList();

            return player;
        }

        public void UpdateTimeEvent(Event events)
        {
            throw new System.NotImplementedException();
        }

        Artist IArtistsDbService.GetArtist(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
