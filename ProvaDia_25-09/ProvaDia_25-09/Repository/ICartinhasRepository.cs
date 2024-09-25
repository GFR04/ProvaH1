using ProvaDia_25_09.Models;
using System.ComponentModel.DataAnnotations;

namespace ProvaDia_25_09.Repository
{
    public interface ICartinhasRepository
    {
        public void InserirDadosCarta(Carta carta);
        public List<Carta> GetCarta();
    }
}
