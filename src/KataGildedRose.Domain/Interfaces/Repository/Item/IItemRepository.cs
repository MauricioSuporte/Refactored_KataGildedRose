using System.Collections.Generic;
using KataGildedRose.Domain.Entity;

namespace KataGildedRose.Domain.Interfaces.Repository
{
    public interface IItemRepository
    {
        List<Item> GetItens();
    }
}