using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendingMachine.Models
{
    public class VMWallet:Wallet
    {
        private int _given_summ;

        public VMWallet()
        {
            _given_summ=0;
        }

        public void EnterCoin(IUnitType coin)
        {
            _units.Add(coin);
            _given_summ += (int)coin.Val;
        }

        protected override Dictionary<string, int> _StartInitilization()
        {
            throw new NotImplementedException();
        }
    }
}