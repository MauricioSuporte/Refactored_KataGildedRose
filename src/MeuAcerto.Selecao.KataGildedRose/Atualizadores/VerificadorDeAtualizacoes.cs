﻿using System;
using System.Collections.Generic;
using System.Text;
using KataGildedRose.Enum;

namespace KataGildedRose.Atualizadores
{
    public class VerificadorDeAtualizacoes
    {
        //Atualiza a qualdiade podendo ser sobrescrito
        public virtual void AtualizarQualidade(Item item)
        {
            throw new Exception("Tipo do Item Desconhecido");
        }

        //Chama GetTipo e retorna o Tipo do Item
        public static VerificadorDeAtualizacoes InstanciaTipoItem(Item item)
        {
            if (GetTipo(item) == TipoItem.QueijoBrie)
                return new AtualizarQualidadeQueijoBrie();
            else if (GetTipo(item) == TipoItem.Ingressos)
                return new AtualizarQualidadeIngressos();
            else if (GetTipo(item) == TipoItem.ItemComum)
                return new AtualizarQualidadeItemComum();
            else if (GetTipo(item) == TipoItem.Lendario)
                return new AtualizarQualidadeLendario();
            else if (GetTipo(item) == TipoItem.Conjurado)
                return new AtualizarQualidadeConjurado();
            else
                return new VerificadorDeAtualizacoes();
        }

        //Descobre o Tipo do Item
        public static TipoItem GetTipo(Item item)
        {
            if (item.Nome.Equals("Queijo Brie Envelhecido"))
                return TipoItem.QueijoBrie;
            else if (item.Nome.Equals("Ingressos para o concerto do Turisas"))
                return TipoItem.Ingressos;
            else if (item.Nome.Equals("Dente do Tarrasque"))
                return TipoItem.Lendario;
            else if (item.Nome.Contains("Conjurado"))
                return TipoItem.Conjurado;
            else
                return TipoItem.ItemComum;
        }
    }
}
