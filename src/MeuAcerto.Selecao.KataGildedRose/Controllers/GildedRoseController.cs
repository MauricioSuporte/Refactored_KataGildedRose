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
    [Route("api")]
    [ApiController]
    public class GildedRoseController : ControllerBase
    {
        [HttpGet]
        public List<Item> Index()
        {
            var repositorio = new Repositorio();
            List<Item> itens = repositorio.GetItens().ToList();

            //Dictionary<int, IList<Item>> novosItens = new Dictionary<int, IList<Item>>();

            //var gildedRose = new GildedRose(itens);

            //for (var i = 0; i < 31; i++)
            //{
            //    Console.WriteLine("-------- dia " + i + " --------");
            //    Console.WriteLine("Nome, PrazoParaVenda, Qualidade");
            //    for (var j = 0; j < itens.Count; j++)
            //    {
            //        Console.WriteLine(itens[j].Nome + ", " + itens[j].PrazoParaVenda + ", " + itens[j].Qualidade);
            //    }
            //    Console.WriteLine("");
            //    gildedRose.AtualizarQualidade();
            //}

            
            //string json = JsonConvert.SerializeObject(novosItens, Formatting.Indented);
            return itens;
        }
    }
}
