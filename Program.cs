using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заказчик просит написать программу «Записная книжка». Оплата фиксированная - $ 120.

            // В данной программе, должна быть возможность изменения значений нескольких переменных для того,
            // чтобы персонифецировать вывод данных, под конкретного пользователя.

            // Для этого нужно: 
            // 1. Создать несколько переменных разных типов, в которых могут храниться данные
            //    - имя;
            //    - возраст;
            //    - рост;
            //    - баллы по трем предметам: история, математика, русский язык;

            // 2. Реализовать в системе автоматический подсчёт среднего балла по трем предметам, 
            //    указанным в пункте 1.

            // 3. Реализовать возможность печатки информации на консоли при помощи 
            //    - обычного вывода;
            //    - форматированного вывода;
            //    - использования интерполяции строк;

            // 4. Весь код должен быть откомментирован с использованием обычных и хml-комментариев

            // **
            // 5. В качестве бонусной части, за дополнительную оплату $50, заказчик просит реализовать 
            //    возможность вывода данных в центре консоли.


            const int MAX_EMPLOYEES = 1;

            Repository NoteBook = new Repository();

            string header = $"Создание записной книжки. Кол-во сотрудников - {MAX_EMPLOYEES}";
            string divider = "----------------------------------------------------";
            Console.SetCursorPosition((Console.WindowWidth - header.Length) / 2, Console.CursorTop);
            Console.WriteLine(header);
            Console.SetCursorPosition((Console.WindowWidth - divider.Length) / 2, Console.CursorTop);
            Console.WriteLine(divider);
            Console.WriteLine();

            int successfullyAddedEmployeesCount = 0;
            EmployeeBuilder employeeBuilderInstance = new EmployeeBuilder();
            while (successfullyAddedEmployeesCount < MAX_EMPLOYEES) {
                try
                {
                    Console.WriteLine("Добавление сотрудника " + (successfullyAddedEmployeesCount + 1));
                    Employee employee = employeeBuilderInstance.Build();
                    NoteBook.Save(employee);
                    successfullyAddedEmployeesCount++;
                    employeeBuilderInstance = new EmployeeBuilder();
                }
                catch (EmployeeBuildException e) {
                    Console.WriteLine($"Ошибка при добавлении сотрудника. {e.Message}");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Максимальное кол-во сотрудников добавлено в записную книжку.");
            NoteBook.Print("Записная книжка");

            Console.ReadKey();

        }
    }
}
