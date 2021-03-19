using KataGildedRose.Domain.Entity;
using KataGildedRose.Domain.Interfaces.Repository;
using KataGildedRose.Domain.Interfaces.Services;
using KataGildedRose.Domain.Services;
using KataGildedRose.Infra.Data.Repository;
using System.Collections.Generic;
using Xunit;

namespace KataGildedRose.Testes
{
    public class GildedRoseTest
    {
        private readonly IItemRepository _itemRepository;
        private readonly IGildedRose _gildedRoseService;

        public GildedRoseTest()
        {
            _itemRepository = new ItemRepository();
            _gildedRoseService = new GildedRose(_itemRepository);
        }

        [Fact]
        public void TestarCriarItens()
        {
            List<Item> Items = new List<Item> { new Item { Nome = "Item teste", PrazoParaVenda = 0, Qualidade = 0 } };
            _gildedRoseService.AtualizarQualidade();
            Assert.Equal("Item teste", Items[0].Nome);
        }
    }
}