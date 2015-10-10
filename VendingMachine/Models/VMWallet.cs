using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendingMachine.Models
{
    public class VMWallet : Wallet<FaceValueTypes>
    {
        public VMWallet(Dictionary<FaceValueTypes, int> _coins)
            : base(_coins)
        {

        }

        protected override IUnit<FaceValueTypes> _UnitCreator(FaceValueTypes type)
        {
            return new Coin(type);
        }
    }
}