﻿using System.Collections.Generic;
using Xunit;

namespace KataGildedRose
{
    public class GildedRoseTest
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Nome = "foo", PrazoParaVenda = 0, Qualidade = 0 } };
            GildedRose app = new GildedRose(Items);
            app.AtualizarQualidade();
            Assert.Equal("foo", Items[0].Nome);
        }
    }
}
