using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Operation
{
    class Operation
    {
        private double _sum;
        private string _category;
        private DateTime _date; //тут должно быть взам. с каллендарем

        public Operation(double sum, string category, DateTime date)
        {
            Sum = sum;
            Category = category;
            Date = date;
        }

        public double Sum
        {
            get
            {
                return _sum;
            }
            set
            {
                _sum = value;
            }
        }

        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }

       
         public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
         
    }
}
