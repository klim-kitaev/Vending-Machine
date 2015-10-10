using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendingMachine.Models
{
    public abstract class Wallet
    {
        protected List<IUnitType> _units;

        private int _GetSum()
        {
            int sum = 0;
            foreach(IUnitType unit in _units)
            {
                sum += unit.Val;
            }
            return sum;
        }

        public int Sum { get { return _GetSum(); } }

        public List<IUnitType> Coins { get { return _units; } }

        public Dictionary<string,int> ShowSortedQuantity()
        {
            Dictionary<string, int> ret = new Dictionary<string, int>();
            foreach(IUnitType unit in _units)
            {
                int val = ret[unit.Name];
                val++;
                ret[unit.Name] = val;
            }
            return ret;
        }

        /// <summary>
        /// Начальная иницилизация всех возможных типов
        /// </summary>
        /// <returns></returns>
        protected abstract Dictionary<string, int> _StartInitilization();

        
    }
}