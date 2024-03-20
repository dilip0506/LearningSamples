using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using pokemon;

namespace pokemon.tests
{
    [TestClass]
    public class PokemonTest
    {
        [TestMethod]
        public void Test_price()
        {
            var pokemon = new shop_pokemon();
            double price_test_1 = pokemon.price(1, 0, 0);
            Assert.AreEqual(6, price_test_1);
            double price_test_2 = pokemon.price(2, 0, 0);
            Assert.AreEqual(12.00, price_test_2);
            double price_test_3 = pokemon.price(1, 1, 0);
            Assert.AreEqual(9.90, price_test_3);
            double price_test_4 = pokemon.price(2, 2, 0);
            Assert.AreEqual(19.80, price_test_4);
            double price_test_5 = pokemon.price(3, 3, 0);
            Assert.AreEqual(29.70, price_test_5);
            double price_test_6 = pokemon.price(2, 1, 0);
            Assert.AreEqual(15.90, price_test_6);
            double price_test_7 = pokemon.price(1, 1, 1);
            Assert.AreEqual(12.80, price_test_7);
            double price_test_8 = pokemon.price(2, 1, 1);
            Assert.AreEqual(18.80, price_test_8);
        }

}
}
