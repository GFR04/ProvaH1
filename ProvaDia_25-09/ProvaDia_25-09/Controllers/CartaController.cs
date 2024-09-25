using Microsoft.AspNetCore.Mvc;
using ProvaDia_25_09.Models;
using ProvaDia_25_09.Repository;

namespace ProvaDia_25_09.Controllers
{
    [ApiController]
    [Route("Api/CartaController")]
    public class CartaController : ControllerBase
    {
        private readonly ICartinhasRepository _cartinhasRepository;
        public CartaController(ICartinhasRepository cartinhasRepository)
        {
            _cartinhasRepository = cartinhasRepository;
        }
    [HttpPost]
    [Route("CadastrarCarta")]
    public IActionResult CadastrarCarta(Carta carta)
    {
        _cartinhasRepository.InserirDadosCarta(new Carta(){
                Nome = carta.NomeCrianca,
                Idade = carta.IdadeCriança,
                Rua = carta.Rua,
                Bairro = carta.Bairro,
                Cidade = carta.Cidade,
                Numero = carta.Numero,
                Estado = carta.Estado,
                CartaTexto = carta.TextoCarta
                    });
            return Ok($"{carta.Nome}, papai Noel vai entregar seu presente!");
        }
        [HttpGet]
        [Route("ObterCartas")]
        public IActionResult ObterCartas()
        {
            return Ok(CartinhaRepository.GetCarta());
        }
