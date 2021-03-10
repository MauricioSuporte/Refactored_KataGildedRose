using System;
using System.Collections.Generic;
using System.Text;

namespace MeuAcerto.Selecao.KataGildedRose.Atualizadores
{
    class AtualizarQualidadeItemComum : VerificadorDeAtualizacoes
    {
        public override void AtualizarQualidade(Item item)
        {
            item.PrazoParaVenda--;

            if (item.PrazoParaVenda < 0)
                item.Qualidade -= 2;
            else
                item.Qualidade--;

            item.Qualidade = item.Qualidade < 0 ? 0 : item.Qualidade;
        }
    }
}
