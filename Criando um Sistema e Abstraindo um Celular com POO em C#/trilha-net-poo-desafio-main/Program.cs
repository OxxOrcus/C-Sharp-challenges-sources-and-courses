using System;
using DesafioPOO.Models;

Console.WriteLine("=== Demonstração: Abstração de Smartphone ===\n");

var nokia = new Nokia("111-0000", "Nokia 3310");
var iphone = new Iphone("222-0000", "iPhone 12");

Console.WriteLine("Instalando apps nos dispositivos:\n");
nokia.InstalarAplicativo("Snake");
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine();
Console.WriteLine($"Apps instalados no {nokia.Modelo} ({nokia.Numero}): {string.Join(", ", nokia.AplicativosInstalados)}");
Console.WriteLine($"Apps instalados no {iphone.Modelo} ({iphone.Numero}): {string.Join(", ", iphone.AplicativosInstalados)}");

Console.WriteLine();
Console.WriteLine("Testando conectividade no iPhone:");
if (iphone is IConectividade conectividade)
{
	conectividade.ConectarAInternet();
}

Console.WriteLine();
Console.WriteLine("Execução finalizada.");