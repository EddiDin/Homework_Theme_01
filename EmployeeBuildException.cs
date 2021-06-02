using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    [Serializable]
    class EmployeeBuildException : Exception
    {
        public EmployeeBuildException() { }

        public EmployeeBuildException(string message) : base(message) { }

        public EmployeeBuildException(string message, Exception inner) : base(message, inner) { } 
    }
}
