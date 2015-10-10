using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendingMachine.Models
{
    public abstract class Wallet<T>
    {
        protected List<IUnit<T>> _units;

        private int _GetSum()
        {
            int sum = 0;
            foreach (IUnit<T> unit in _units)
            {
                sum += unit.Val;
            }
            return sum;
        }

        public Wallet(Dictionary<T, int> unit_list)
        {
            _units = _GetUnitList(unit_list);
        }

        protected List<IUnit<T>> _GetUnitList(Dictionary<T, int> unit_list)
        {
            List<IUnit<T>> ret = new List<IUnit<T>>();
            foreach (var key in unit_list.Keys)
            {
                int count = unit_list[key];
                IUnit<T> unit = _UnitCreator(key);
                for (int i = 0; i < count; i++)
                {
                    ret.Add(unit);
                }
            }
            return ret;
        }

        public int Sum { get { return _GetSum(); } }

        public List<IUnit<T>> Units { get { return _units; } }

        public Dictionary<T, int> GetSorted()
        {
            Dictionary<T, int> ret = _StartInitilization();
            foreach (IUnit<T> unit in _units)
            {
                int val = ret[unit.Type];
                val++;
                ret[unit.Type] = val;
            }
            return ret;
        }

        /// <summary>
        /// Начальная иницилизация всех возможных типов
        /// </summary>
        /// <returns></returns>
        protected Dictionary<T, int> _StartInitilization()
        {
            Dictionary<T, int> ret = new Dictionary<T, int>();
            foreach (T type in Enum.GetValues(typeof(T)))
            {
                ret.Add(type, 0);
            }
            return ret;
        }

        protected abstract IUnit<T> _UnitCreator(T type);
    }
}