using System;
using DesafioPOO.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioPOO.Tests
{
  [TestClass]
  public class NokiaTests
  {
    private class TestNokia : Nokia
    {
      public string LastInstalledApp { get; private set; }

      public TestNokia(string numero) : base(numero)
      {
      }

      public override void InstalarAplicativo(string nomeApp)
      {
        LastInstalledApp = nomeApp;
      }
    }

    [TestMethod]
    public void Nokia_Constructor_Should_Set_Numero_Property()
    {
      var numero = "111-0000";
      var phone = new TestNokia(numero);
      Assert.AreEqual(numero, phone.Numero);
    }

    [TestMethod]
    public void Nokia_Ligar_And_ReceberLigacao_Should_Not_Throw()
    {
      var phone = new TestNokia("1");
      phone.Ligar();
      phone.ReceberLigacao();
    }

    [TestMethod]
    public void Nokia_InstalarAplicativo_Should_Invoke_Subclass_Implementation()
    {
      var phone = new TestNokia("1");
      var appName = "NokiaApp";
      phone.InstalarAplicativo(appName);
      Assert.AreEqual(appName, phone.LastInstalledApp);
    }
  }
}
