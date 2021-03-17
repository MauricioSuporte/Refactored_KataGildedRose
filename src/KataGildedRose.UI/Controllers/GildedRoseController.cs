using KataGildedRose.Domain.Entity;
using KataGildedRose.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace KataGildedRose.Web.Controllers
{
    [Route("Api")]
    [ApiController]
    public class GildedRoseController : ControllerBase
    {
        private readonly IGildedRose _gildedRoseService;

        //Construtor
        public GildedRoseController(IGildedRose gildedRoseService)
        {
            _gildedRoseService = gildedRoseService;
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
            List<Item> itens = _gildedRoseService.InstanciaItens();
            return itens;
        }
    }
}