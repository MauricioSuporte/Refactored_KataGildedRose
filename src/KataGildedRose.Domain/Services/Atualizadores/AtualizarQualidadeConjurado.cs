using KataGildedRose.Domain.Entity;

namespace KataGildedRose.Domain.Services
{
    class AtualizarQualidadeConjurado : VerificadorDeAtualizacoes
    {
        //Atualiza Qualidade do Conjurado
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