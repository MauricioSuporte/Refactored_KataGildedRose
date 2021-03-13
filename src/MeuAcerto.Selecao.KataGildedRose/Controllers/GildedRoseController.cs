using KataGildedRose.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KataGildedRose.Controllers
{
    [Route("Api")]
    [ApiController]
    public class GildedRoseController : ControllerBase
    {
        [HttpGet]
        public List<Item> Index()
        {
            var repositorio = new Repositorio();
            List<Item> itens = repositorio.GetItens().ToList();
            return itens;
        }

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
