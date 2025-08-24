namespace DesafioPOO.Models
{
    using System;

    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo = "Nokia") : base(numero, modelo)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            if (string.IsNullOrWhiteSpace(nomeApp)) throw new ArgumentException("Nome do aplicativo inválido.", nameof(nomeApp));
            // Simula processo simples de instalação para Nokia
            Console.WriteLine($"Nokia: instalando {nomeApp} via pacote .apk...");
            AplicativosInstalados.Add(nomeApp);
        }
    }
}