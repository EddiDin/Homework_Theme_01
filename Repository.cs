using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    /// <summary>
    /// Организация хранения данных.
    /// </summary>
    class Repository
    {

        /// <summary>
        /// База данных работников (записная книжка в конкретном случае), в которой хранятся 
        /// Имя, возраст, рост, баллы по русскому, истории и математике
        /// </summary>
        public List<Employee> Employees { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Repository()
        {
            this.Employees = new List<Employee>();
        }

        /// <summary>
        /// Метод добавления сотрудника в репозиторий
        /// </summary>
        /// <param name="employee">Сотрудник. Объект класса Employee</param>
        public void Save(Employee employee)
        {
            this.Employees.Add(employee);
        }

        /// <summary>
        /// Форматированный вывод данных из репозитория
        /// </summary>
        /// <param name="message"></param>
        public void Print(string message)
        {
            Console.WriteLine(message);

            string pattern = "Имя: {0}\nВозраст: {1}\nРост: {2}\nРусский(балл): {3}\nИстория(балл): {4}\nМатематика(балл): {5}\nСредний(балл): {6}";
            foreach (Employee employee in this.Employees)
            {
                Console.WriteLine(pattern,
                    employee.Name,
                    employee.Age,
                    employee.Height,
                    employee.RussianScores,
                    employee.HistoryScores,
                    employee.MathScores,
                    Math.Round(employee.AverageScore, 2));
                Console.WriteLine();
            }
        }
    }
}
