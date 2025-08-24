using System;
using DesafioPOO.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioPOO.Tests
{
  [TestClass]
  public class SmartphoneTest
  {
    private class TestSmartphone : Smartphone
    {
      public string LastInstalledApp { get; private set; }

      public TestSmartphone(string numero) : base(numero)
      {
      }

      public override void InstalarAplicativo(string nomeApp)
      {
        LastInstalledApp = nomeApp;
      }
    }

    [TestMethod]
    public void Constructor_Should_Set_Numero_Property()
    {
      var numero = "555-1234";
      var phone = new TestSmartphone(numero);

      Assert.AreEqual(numero, phone.Numero);
    }

    [TestMethod]
    public void Ligar_And_ReceberLigacao_Should_Not_Throw()
    {
      var phone = new TestSmartphone("1");
      phone.Ligar();
      phone.ReceberLigacao();
    }

    [TestMethod]
    public void InstalarAplicativo_Should_Invoke_Subclass_Implementation()
    {
      var phone = new TestSmartphone("1");
      var appName = "AppTeste";

      phone.InstalarAplicativo(appName);

      Assert.AreEqual(appName, phone.LastInstalledApp);
    }
  }
}