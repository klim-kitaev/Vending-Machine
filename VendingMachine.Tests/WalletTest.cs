using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine.Models;
using System.Collections.Generic;

namespace VendingMachine.Tests
{
    [TestClass]
    public class WalletTest
    {
        [TestMethod]
        public void ReturnCacheTest()
        {
            VMWallet vwWallet = new VMWallet(new Dictionary<FaceValueTypes, int>{
                {FaceValueTypes.One,100},
                {FaceValueTypes.Two,100},
                {FaceValueTypes.Five,100},
                {FaceValueTypes.Ten,100}
            });

            List<Coin> AddingCoins = new List<Coin>{
            new Coin(FaceValueTypes.Ten),
            new Coin(FaceValueTypes.Ten),
            new Coin(FaceValueTypes.Two),
            new Coin(FaceValueTypes.One)
            };

            foreach(var coin in AddingCoins)
            {
                vwWallet.Add(coin);
            }

            Assert.AreEqual(23, vwWallet.MoneyCache);

            List<Coin> returned_coins = vwWallet.ReturnCache();

            Assert.AreEqual(AddingCoins.Count, returned_coins.Count);

            var e1 = AddingCoins.GetEnumerator();
            var e2 = returned_coins.GetEnumerator();

            while (e1.MoveNext() && e2.MoveNext())
            {
                Assert.AreEqual(e1.Current, e2.Current);
            }
        }
    }
}
