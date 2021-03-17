using System.Collections.Generic;
using System.Linq;
using KataGildedRose.Domain.Entity;
using KataGildedRose.Domain.Interfaces.Repository;
using KataGildedRose.Domain.Interfaces.Services;

namespace KataGildedRose.Domain.Services
{
    public class GildedRose : IGildedRose
    {
        private readonly IItemRepository _itemRepository;

        IList<Item> Itens;
        public GildedRose(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
            Itens = _itemRepository.GetItens().ToList();
        }

        //Instancia Itens do Repository
        public List<Item> InstanciaItens()
        {
            return _itemRepository.GetItens().ToList();
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