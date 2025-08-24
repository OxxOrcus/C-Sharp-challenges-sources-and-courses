using System;
using DesafioPOO.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioPOO.Tests
{
  [TestClass]
  public class IphoneTests
  {
    private class TestIphone : Iphone
    {
      public string LastInstalledApp { get; private set; }

      public TestIphone(string numero) : base(numero)
      {
      }

      public override void InstalarAplicativo(string nomeApp)
      {
        LastInstalledApp = nomeApp;
      }
    }

    [TestMethod]
    public void Iphone_Constructor_Should_Set_Numero_Property()
    {
      var numero = "222-0000";
      var phone = new TestIphone(numero);
      Assert.AreEqual(numero, phone.Numero);
    }

    [TestMethod]
    public void Iphone_Ligar_And_ReceberLigacao_Should_Not_Throw()
    {
      var phone = new TestIphone("1");
      phone.Ligar();
      phone.ReceberLigacao();
    }

    [TestMethod]
    public void Iphone_InstalarAplicativo_Should_Invoke_Subclass_Implementation()
    {
      var phone = new TestIphone("1");
      var appName = "IphoneApp";
      phone.InstalarAplicativo(appName);
      Assert.AreEqual(appName, phone.LastInstalledApp);
    }
  }
}
