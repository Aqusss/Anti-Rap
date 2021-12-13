using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _Operation;

namespace _SpendCategories
{
    class SpendCategories
    {
       private SortedList<Operation, double> _categories;

        public SpendCategories() { }

        public void CreateCategory(double sum, string category, DateTime date)
        {
            Operation operation = new Operation(sum, category, date);

            _categories.Add(operation, operation.Sum);
        }

        public static SortedList<Operation, double> GetSortedOperations(SortedList<Operation, double> all_operations_list,
            DateTime date_from, DateTime date_to)
        {
            SortedList<Operation, double> new_sortedList = new SortedList<Operation, double>();
            for (int i = 0; i< all_operations_list.Count;i++)
            {
                if (all_operations_list.ElementAt(i).Key.Date >= date_from 
                    && all_operations_list.ElementAt(i).Key.Date >= date_to)
                {
                    new_sortedList.Add(all_operations_list.ElementAt(i).Key, 
                        all_operations_list.ElementAt(i).Key.Sum);
                }
            }
            return new_sortedList;
        }




    }
}
