using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;
using KataGildedRose.Domain.Entity;
using KataGildedRose.Infra.Data.Repository;
using Xunit;
using KataGildedRose.Domain.Services;

namespace KataGildedRose.Testes
{
    [UseReporter(typeof(DiffReporter))]
    public class ApprovalTest
    {
        [Fact]
        public void TrintaDias()
        {
            var repositorio = new ItemRepository();
            List<Item> itens = repositorio.GetItens().ToList();
            var gildedRoseService = new GildedRose(itens);
            var stringTest = "";

            for (var i = 0; i < 31; i++)
            {
                stringTest += "-------- dia " + i + " --------\n";
                stringTest += "Nome, PrazoParaVenda, Qualidade\n";
                for (var j = 0; j < itens.Count; j++)
                {
                    stringTest += itens[j].Nome + ", " + itens[j].PrazoParaVenda + ", " + itens[j].Qualidade + "\n";
                }
                stringTest += "\n";
                gildedRoseService.AtualizarQualidade();
            }

            Approvals.Verify(stringTest);
        }
    }
}