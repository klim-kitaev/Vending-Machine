using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendingMachine.Models
{
    public enum FaceValueTypes { One = 1, Two = 2, Five = 5, Ten = 10 };
    public class Coin : IUnit<FaceValueTypes>
    {
        private int _val;
        private string _title;
        private FaceValueTypes _type;

        public Coin(FaceValueTypes f_type)
        {
            switch (f_type)
            {
                case FaceValueTypes.One:
                    _val = 1;
                    _title = "1 руб";
                    break;
                case FaceValueTypes.Two:
                    _val = 2;
                    _title = "2 руб";
                    break;
                case FaceValueTypes.Five:
                    _val = 5;
                    _title = "5 руб";
                    break;
                case FaceValueTypes.Ten:
                    _val = 10;
                    _title = "10 руб";
                    break;
            }
        }

        public string Title
        {
            get { return _title; }
        }

        public int Val
        {
            get { return _val; }
        }

        public FaceValueTypes Type
        {
            get { return _type; }
        }
    }
}