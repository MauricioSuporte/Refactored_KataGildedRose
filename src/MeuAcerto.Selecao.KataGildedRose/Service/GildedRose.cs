using System.Collections.Generic;

namespace MeuAcerto.Selecao.KataGildedRose
{
    class GildedRose
    {
        IList<Item> Itens;
        public GildedRose(IList<Item> Itens)
        {
            this.Itens = Itens;
        }

        public void AtualizarQualidade()
        {
            for (var i = 0; i < Itens.Count; i++)
            {
                if (Itens[i].Nome != "Queijo Brie Envelhecido" && Itens[i].Nome != "Ingressos para o concerto do Turisas")
                {
                    if (Itens[i].Qualidade > 0)
                    {
                        if (Itens[i].Nome.Contains("Conjurado"))
                        {
                            Itens[i].Qualidade = Itens[i].Qualidade - 2;
                        }
                        else if (Itens[i].Nome != "Dente do Tarrasque")
                        {
                            Itens[i].Qualidade = Itens[i].Qualidade - 1;
                        }
                    }
                }
                else
                {
                    if (Itens[i].Qualidade < 50)
                    {
                        Itens[i].Qualidade = Itens[i].Qualidade + 1;

                        if (Itens[i].Nome == "Ingressos para o concerto do Turisas")
                        {
                            if (Itens[i].PrazoParaVenda < 11)
                            {
                                if (Itens[i].Qualidade < 50)
                                {
                                    Itens[i].Qualidade = Itens[i].Qualidade + 1;
                                }
                            }

                            if (Itens[i].PrazoParaVenda < 6)
                            {
                                if (Itens[i].Qualidade < 50)
                                {
                                    Itens[i].Qualidade = Itens[i].Qualidade + 1;
                                }
                            }
                        }
                    }
                }

                if (Itens[i].Nome != "Dente do Tarrasque")
                {
                    Itens[i].PrazoParaVenda = Itens[i].PrazoParaVenda - 1;
                }

                if (Itens[i].PrazoParaVenda < 0)
                {
                    if (Itens[i].Nome != "Queijo Brie Envelhecido")
                    {
                        if (Itens[i].Nome != "Ingressos para o concerto do Turisas")
                        {
                            if (Itens[i].Qualidade > 0)
                            {
                                if (Itens[i].Nome != "Dente do Tarrasque")
                                {
                                    Itens[i].Qualidade = Itens[i].Qualidade - 1;
                                }
                            }
                        }
                        else
                        {
                            Itens[i].Qualidade = Itens[i].Qualidade - Itens[i].Qualidade;
                        }
                    }
                    else
                    {
                        if (Itens[i].Qualidade < 50)
                        {
                            Itens[i].Qualidade = Itens[i].Qualidade + 1;
                        }
                    }
                }
            }
        }
    }
}
