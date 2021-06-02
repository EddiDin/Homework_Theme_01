using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    class EmployeeBuilder
    {

        static EmployeeBuilder() { 
        }

        static public Employee build() {
            Console.WriteLine("Введите Имя сотрудника:");
            string inputName = Console.ReadLine();

            Console.WriteLine("Введите Возраст сотрудника \"{0}\":", inputName);
            string inputAge = Console.ReadLine();
            int parsedAge = Int16.Parse(inputAge);

            if (parsedAge < 18 || parsedAge > 60) 
            {
                throw new EmployeeBuildException("Ошибка при заведении сотрудника. Все сотрудники должны быть старше 18 лет и моложе 60.");
            }

            Console.WriteLine("Введите Рост сотрудника:");
            string inputHeight = Console.ReadLine();
            int parsedHeight = Int16.Parse(inputHeight);

            if (parsedHeight < 0)
            {
                throw new EmployeeBuildException("Ошибка при заведении сотрудника. Рост не может быть отрицательным.");
            }



            return new Employee(inputName, parsedAge, parsedHeight, 0, 0, 0);
        }
    }
}
