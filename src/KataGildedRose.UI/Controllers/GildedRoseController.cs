using KataGildedRose.Domain.Entity;
using KataGildedRose.Domain.Services;
using KataGildedRose.Infra.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace KataGildedRose.Web.Controllers
{
    [Route("Api")]
    [ApiController]
    public class GildedRoseController : ControllerBase
    {
        //Index
        [HttpGet]
        public List<Item> Index()
        {
            var itemRepository = new ItemRepository();
            List<Item> itens = itemRepository.GetItens().ToList();
            return itens;
        }

        //Atualiza Itens
        [HttpPost]
        [Route("Att")]
        public List<Item> AtualizarItens(List<Item> itens)
        {
            var gildedRoseService = new GildedRose(itens);
            gildedRoseService.AtualizarQualidade();
            return itens;
        }
    }
}