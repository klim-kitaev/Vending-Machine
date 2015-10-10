using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine.Models
{
    public interface IUnit<T>
    {
        string Title { get; }
        int Val { get; }
        T Type { get; }

    }
}
