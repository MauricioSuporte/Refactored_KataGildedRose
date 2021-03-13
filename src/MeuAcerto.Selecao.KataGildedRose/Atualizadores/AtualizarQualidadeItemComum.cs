﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KataGildedRose.Atualizadores
{
    class AtualizarQualidadeItemComum : VerificadorDeAtualizacoes
    {
        //Atualiza Qualidade do Item Comum
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
