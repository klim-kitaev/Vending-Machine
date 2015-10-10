using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine.Models
{
    public interface IUnit<T>
    {
        T Type { get; }
        Info Info {get;}
    }
}
