using System;
using System.Collections.Generic;
using System.Text;

namespace KataGildedRose.Atualizadores
{
    class AtualizarQualidadeConjurado : VerificadorDeAtualizacoes
    {
        public override void AtualizarQualidade(Item item)
        {
            item.PrazoParaVenda--;

            if (item.PrazoParaVenda < 0)
                item.Qualidade -= 4;
            else
                item.Qualidade -= 2;

            item.Qualidade = item.Qualidade < 0 ? 0 : item.Qualidade;
        }
    }
}
