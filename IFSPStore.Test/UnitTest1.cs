using IFSPStore.Domain.Entities;
using System.Diagnostics;
using System.Text.Json;

namespace IFSPStore.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class UnitTestDomain()
        {
            [TestMethod]
            public void TestCidade() 
            {
                Cidade cidade = new Cidade(1, "Birigui", "SP");

                Debug.WriteLine(JsonSerializer.Serialize(cidade));

                Assert.AreEqual(cidade.Nome, "Birigui");
                Assert.AreEqual(cidade.Estado, "SP");
            }
            /*[TestMethod]
            public void TestCliente() 
            {
                Cliente cliente = new Cliente(1, "Lucas", "Rua Afonso Pena", "CPF", "Centro",
                    "Buritama", 2);
                Debug.WriteLine(JsonSerializer.Serialize(cliente));
                Assert.AreEqual(cliente.Nome, "Lucas");
            }*/
        }
    }
}