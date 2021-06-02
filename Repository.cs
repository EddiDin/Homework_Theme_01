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

        public Repository(int Count)
        {
            this.Employees = new List<Employee>();
        }

        public void save(Employee employee) {
            this.Employees.Add(employee);
        }
    }
}
