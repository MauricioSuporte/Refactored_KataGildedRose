using KataGildedRose.Domain.Entity;
using System;
using System.Collections.Generic;

namespace KataGildedRose.Domain.Interfaces.Services
{
    public interface IGildedRose
    {
        List<Item> InstanciaItens();
        void AtualizarQualidade();
    }
}