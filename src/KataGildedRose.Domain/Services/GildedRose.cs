using System.Collections.Generic;
using KataGildedRose.Domain.Entity;
using KataGildedRose.Domain.Interfaces.Services;

namespace KataGildedRose.Domain.Services
{
    public class GildedRose : IGildedRose
    {
        IList<Item> Itens;
        public GildedRose(IList<Item> Itens)
        {
            this.Itens = Itens;
        }

        //Método que atualiza a Qualidade
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