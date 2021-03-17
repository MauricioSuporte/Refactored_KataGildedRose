using KataGildedRose.Domain.Entity;
using KataGildedRose.Domain.Interfaces.Repository;
using KataGildedRose.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace KataGildedRose.Web.Controllers
{
    [Route("Api")]
    [ApiController]
    public class GildedRoseController : ControllerBase
    {
        private readonly IGildedRose _gildedRoseService;
        private readonly IItemRepository _itemRepository;

        //Construtor
        public GildedRoseController(IGildedRose gildedRoseService, IItemRepository itemRepository)
        {
            _gildedRoseService = gildedRoseService;
            _itemRepository = itemRepository;
        }

        //Index
        [HttpGet]
        public List<Item> Index()
        {
            List<Item> itens = _gildedRoseService.InstanciaItens();
            return itens;
        }

        //Atualiza Itens
        [HttpPost]
        [Route("Att")]
        public List<Item> AtualizarItens()
        {
            _gildedRoseService.AtualizarQualidade();
            return _itemRepository.GetItens().ToList();
        }
    }
}