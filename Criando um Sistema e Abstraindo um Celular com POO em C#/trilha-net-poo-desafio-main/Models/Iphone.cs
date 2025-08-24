namespace DesafioPOO.Models
{
    using System;

    public class Iphone : Smartphone, IConectividade
    {
        public Iphone(string numero, string modelo = "Iphone") : base(numero, modelo)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            if (string.IsNullOrWhiteSpace(nomeApp)) throw new ArgumentException("Nome do aplicativo inválido.", nameof(nomeApp));
            // Simula processo de instalação específico do iPhone
            Console.WriteLine($"iPhone: instalando {nomeApp} via App Store...");
            AplicativosInstalados.Add(nomeApp);
        }

        public void ConectarAInternet()
        {
            Console.WriteLine("iPhone: conectando à internet via Wi-Fi...");
        }
    }
}
