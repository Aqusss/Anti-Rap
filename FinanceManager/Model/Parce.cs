using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Parce
{
    class Parce
    {
        private string _name;
        private double _balance = 0;

        public Parce(string name) : this (name, 0) { }
        public Parce(string name, double balance)
        {
            _name = name;
            _balance = balance;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }
    }
}
