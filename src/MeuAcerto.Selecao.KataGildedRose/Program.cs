using System;
using System.Collections.Generic;
using KataGildedRose.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace KataGildedRose
{
	class Program
	{
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();

			//var repositorio = new Repositorio();
			//IList<Item> itens = repositorio.GetItens();

			//var app = new GildedRose(itens);

			//for (var i = 0; i < 31; i++)
			//{
			//	Console.WriteLine("-------- dia " + i + " --------");
			//	Console.WriteLine("Nome, PrazoParaVenda, Qualidade");
			//	for (var j = 0; j < itens.Count; j++)
			//	{
			//		Console.WriteLine(itens[j].Nome + ", " + itens[j].PrazoParaVenda + ", " + itens[j].Qualidade);
			//	}
			//	Console.WriteLine("");
			//	app.AtualizarQualidade();
			//}
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});
	}
}
