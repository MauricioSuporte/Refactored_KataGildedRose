using System;
using System.Collections.Generic;
using System.Text;

namespace KataGildedRose.Repository
{
    public class Repositorio
    {
		//Instancia lista de Itens
		public IList<Item> GetItens()
        {
			IList<Item> itens = new List<Item>{
				new Item {Nome = "Corselete +5 DEX", PrazoParaVenda = 10, Qualidade = 20},
				new Item {Nome = "Queijo Brie Envelhecido", PrazoParaVenda = 2, Qualidade = 0},
				new Item {Nome = "Elixir do Mangusto", PrazoParaVenda = 5, Qualidade = 7},
				new Item {Nome = "Dente do Tarrasque", PrazoParaVenda = 0, Qualidade = 80},
				new Item {Nome = "Dente do Tarrasque", PrazoParaVenda = -1, Qualidade = 80},
				new Item
				{
					Nome = "Ingressos para o concerto do Turisas",
					PrazoParaVenda = 15,
					Qualidade = 20
				},
				new Item
				{
					Nome = "Ingressos para o concerto do Turisas",
					PrazoParaVenda = 10,
					Qualidade = 49
				},
				new Item
				{
					Nome = "Ingressos para o concerto do Turisas",
					PrazoParaVenda = 5,
					Qualidade = 49
				},
				new Item {Nome = "Bolo de Mana Conjurado", PrazoParaVenda = 3, Qualidade = 6}
			};

			return itens;
		}
	}
}
