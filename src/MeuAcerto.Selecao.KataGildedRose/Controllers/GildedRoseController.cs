using MeuAcerto.Selecao.KataGildedRose.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuAcerto.Selecao.KataGildedRose.Controllers
{
    [Route("")]
    [ApiController]
    public class GildedRoseController : ControllerBase
    {
        public List<Item> Index()
        {
            var repositorio = new Repositorio();
            IList<Item> itens = repositorio.GetItens();
            return (List<Item>)itens;
        }
    }
}
