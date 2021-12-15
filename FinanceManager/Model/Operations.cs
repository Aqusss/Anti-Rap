using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _Operation;

namespace _Operations
{
    class Operations
    {
        private List<Operation> _operations;

        public void AddOperation(Operation operation)
        {
            _operations.Append(operation);
        }
    }
}
