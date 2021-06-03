using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    class Repository
    {

        /// <summary>
        /// База данных работников (записная книжка в конкретном случае), в которой хранятся 
        /// Имя, возраст, рост, баллы по русскому, истории и математике
        /// </summary>
        public List<Employee> Employees { get; set; }

        public Repository()
        {
            this.Employees = new List<Employee>();
        }

        public void Save(Employee employee)
        {
            this.Employees.Add(employee);
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine($"{"Имя",15} {"Возраст",10} {"Рост",10} {"Русский",10} {"История",10} {"Математика",10} {"Средний балл",12}");

            foreach (Employee employee in this.Employees)
            {                                    
                Console.WriteLine(employee);       
            }                                    
        }
    }
}
