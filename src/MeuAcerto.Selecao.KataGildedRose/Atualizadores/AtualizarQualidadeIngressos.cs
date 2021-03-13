using System;
using System.Collections.Generic;
using System.Text;

namespace KataGildedRose.Atualizadores
{
    class AtualizarQualidadeIngressos : VerificadorDeAtualizacoes
    {
        //Atualiza Qualidade do Ingressos
        public override void AtualizarQualidade(Item item)
        {
            item.PrazoParaVenda--;

            if (item.PrazoParaVenda < 0)
            {
                item.Qualidade = item.Qualidade - item.Qualidade;
            }
            else if (item.PrazoParaVenda < 5)
            {
                item.Qualidade += 3;
            }
            else if (item.PrazoParaVenda < 10)
            {
                item.Qualidade += 2;
            }
            else
            {
                item.Qualidade += 1;
            }

            item.Qualidade = (item.Qualidade > 50) ? 50 : item.Qualidade;
        }
    }
}
