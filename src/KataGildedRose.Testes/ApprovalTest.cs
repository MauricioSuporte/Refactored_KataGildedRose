using System.Collections.Generic;
using ApprovalTests;
using ApprovalTests.Reporters;
using KataGildedRose.Domain.Entity;
using KataGildedRose.Infra.Data.Repository;
using Xunit;
using KataGildedRose.Domain.Services;
using KataGildedRose.Domain.Interfaces.Services;
using KataGildedRose.Domain.Interfaces.Repository;

namespace KataGildedRose.Testes
{
    [UseReporter(typeof(DiffReporter))]
    public class ApprovalTest
    {
        private readonly IItemRepository _itemRepository;
        private readonly IGildedRose _gildedRoseService;

        public ApprovalTest()
        {
            _itemRepository = new ItemRepository();
            _gildedRoseService = new GildedRose(_itemRepository);
        }

        [Fact]
        public void TrintaDias()
        {       
            List<Item> itens = _gildedRoseService.InstanciaItens();
            var stringTest = "";

            for (var i = 0; i < 31; i++)
            {
                stringTest += "-------- dia " + i + " --------\n";
                stringTest += "Nome, PrazoParaVenda, Qualidade\n";
                for (var j = 0; j < itens.Count; j++)
                {
                    stringTest += itens[j].Nome + ", " + itens[j].PrazoParaVenda + ", " + itens[j].Qualidade + "\n";
                }
                stringTest += "\n";
                _gildedRoseService.AtualizarQualidade();
            }

            Approvals.Verify(stringTest);
        }
    }
}