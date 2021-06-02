﻿using System;
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


            const int MAX_EMPLOYEES = 3;

            Repository NoteBook = new Repository(MAX_EMPLOYEES);

            Console.WriteLine("Создание записной книжки. Кол-во сотрудников - {0}", MAX_EMPLOYEES);

            int successfullyAddedEmployeesCount = 0;
            while (successfullyAddedEmployeesCount < 3) {
                try
                {
                    Console.WriteLine("Добавление сотрудника " + successfullyAddedEmployeesCount + 1);
                    Employee employee = EmployeeBuilder.build();
                    NoteBook.save(employee);
                    successfullyAddedEmployeesCount++;
                }
                catch (EmployeeBuildException e) {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine();
            }

            Console.WriteLine("Максимальное кол-во сотрудников добавлено в записную книжку.");

            Console.ReadKey();

        }
    }
}
