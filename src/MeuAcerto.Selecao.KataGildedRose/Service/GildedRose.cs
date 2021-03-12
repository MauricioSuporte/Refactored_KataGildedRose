using System.Collections.Generic;
using KataGildedRose.Atualizadores;
using KataGildedRose.Enum;

namespace KataGildedRose
{
    class GildedRose
    {
        IList<Item> Itens;
        public GildedRose(IList<Item> Itens)
        {
            this.Itens = Itens;
        }

        public void AtualizarQualidade()
        {
            foreach (Item item in Itens)
            {
                var verificadorDeAtualizacoes = VerificadorDeAtualizacoes.InstanciaTipoItem(item);
                verificadorDeAtualizacoes.AtualizarQualidade(item);
            }
        }
    }
}
