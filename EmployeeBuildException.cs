using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    /// <summary>
    /// Пользовательское исключение для описания ошибок билдера работников.
    /// </summary>
    [Serializable]
    class EmployeeBuildException : Exception
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public EmployeeBuildException() { }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="message">Пользовательское сообщение об ошибке</param>
        public EmployeeBuildException(string message) : base(message) { } 
    }
}
