using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine.Models
{
    interface IUnitType
    {
        string Name;
        int Val;
        int Order;
    }
}
