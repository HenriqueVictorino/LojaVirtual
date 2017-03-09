using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace LojaVirtual.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Take()
        {
            int[] numeros = { 5, 6, 7, 8, 9, 10,1,2,3,4,5 };

            var resultado = from num in numeros.Take(5) select num;

            int[] Teste = { 5, 6, 7, 8, 9 };

            CollectionAssert.AreEqual(resultado.ToArray(), Teste);
        }

        public void Skype()
        {
            int[] numeros = { 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5 };

            var resultado = from num in numeros.Take(5).Skip(5) select num;

            int[] Teste = { 10, 1, 2, 3, 4 };

            CollectionAssert.AreEqual(resultado.ToArray(), Teste);


        }
    }
}
