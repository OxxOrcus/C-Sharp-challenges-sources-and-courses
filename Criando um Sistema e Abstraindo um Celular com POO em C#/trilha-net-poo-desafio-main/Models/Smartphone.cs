namespace DesafioPOO.Models
{
    using System;
    using System.Collections.Generic;

    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public List<string> AplicativosInstalados { get; private set; }

        public Smartphone(string numero, string modelo = "", string imei = "")
        {
            if (string.IsNullOrWhiteSpace(numero)) throw new ArgumentException("Numero não pode ser nulo ou vazio.", nameof(numero));
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            AplicativosInstalados = new List<string>();
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}