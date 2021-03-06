﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine.Models
{
    /// <summary>
    /// Общий интерфейс для монет и продукции.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IUnit<T>
    {
        T Type { get; }
        Info Info {get;}
    }
}
