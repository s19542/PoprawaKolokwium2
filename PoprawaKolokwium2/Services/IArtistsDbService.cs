
using PoprawaKolokwium2.Models;

namespace PoprawaKolokwium2.Services
{
    public interface IArtistsDbService
    {
        Artist GetArtist(int id);
        void UpdateTimeEvent(Event events );

    }
}
