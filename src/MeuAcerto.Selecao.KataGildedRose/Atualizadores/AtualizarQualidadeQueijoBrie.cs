﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KataGildedRose.Atualizadores
{
    class AtualizarQualidadeQueijoBrie : VerificadorDeAtualizacoes
    {
        //Atualiza Qualidade do Queijo Brie
        public override void AtualizarQualidade(Item item)
        {
            item.PrazoParaVenda--;

            if (item.PrazoParaVenda < 0)
            {
                item.Qualidade += 2;
            }
            else
            {
                item.Qualidade++;
            }
            item.Qualidade = (item.Qualidade > 50) ? 50 : item.Qualidade;
        }
    }
}
