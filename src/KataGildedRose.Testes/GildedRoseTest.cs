using KataGildedRose.Domain.Entity;
using KataGildedRose.Domain.Interfaces.Services;
using KataGildedRose.Domain.Services;
using System.Collections.Generic;
using Xunit;

namespace KataGildedRose.Testes
{
    public class GildedRoseTest
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Nome = "foo", PrazoParaVenda = 0, Qualidade = 0 } };
            IGildedRose app = new GildedRose(Items);
            app.AtualizarQualidade();
            Assert.Equal("foo", Items[0].Nome);
        }
    }
}