using System.Collections.Generic;
using MeuAcerto.Selecao.KataGildedRose.Atualizadores;
using MeuAcerto.Selecao.KataGildedRose.Enum;

namespace MeuAcerto.Selecao.KataGildedRose
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
