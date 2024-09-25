using ProvaDia_25_09.Controllers;
using ProvaDia_25_09.Models;

namespace ProvaDia_25_09.Repository
{
    public class CartinhaRepository : ICartinhasRepository
    {
        private static List<Carta> listaCarta = new List<Carta>();

        public void InserirDadosCarta(Carta carta)
        {
            listaCarta.Add(carta);
        }

        public List<CartaController> GetCartas()
        {
            return listaCarta;
        }
    }
}