using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    class EmployeeBuilder
    {
        public string Name { get; set; }
        public sbyte Age { get; set; }
        public short Height { get; set; }
        public sbyte RussianScores { get; set; }
        public sbyte HistoryScores { get; set; }
        public sbyte MathScores { get; set; }

        static EmployeeBuilder() { }

        public Employee Build()
        {
            string userInput;
            bool successParse;

            if (this.Name == null)
            {
                Console.WriteLine("Введите Имя сотрудника:");
                userInput = Console.ReadLine();

                if (userInput.Length < 3)
                {
                    throw new EmployeeBuildException("Имя сотрудника не может быть меньше 3 символов.");
                }

                this.Name = userInput;
            }

            if (this.Age == 0)
            {
                Console.WriteLine($"Введите Возраст сотрудника \"{this.Name}\":");
                userInput = Console.ReadLine();
                successParse = SByte.TryParse(userInput, out sbyte parsedAge);

                if (!successParse)
                {
                    throw new EmployeeBuildException("Возраст сотрудника должен быть числом.");
                }

                if (parsedAge < 18 || parsedAge > 60)
                {
                    throw new EmployeeBuildException("Все сотрудники должны быть старше 18 лет и моложе 60.");
                }

                this.Age = parsedAge;
            }

            if (this.Height == 0)
            {
                Console.WriteLine($"Введите Рост сотрудника \"{this.Name}\":");
                userInput = Console.ReadLine();
                successParse = Int16.TryParse(userInput, out short parsedHeight);

                if (!successParse)
                {
                    throw new EmployeeBuildException("Рост сотрудника должен быть числом.");
                }

                if (parsedHeight < 0)
                {
                    throw new EmployeeBuildException("Рост не может быть отрицательным.");
                }

                this.Height = parsedHeight;
            }

            if (this.RussianScores == 0)
            {
                Console.WriteLine($"Введите баллы по Русскому языку сотрудника \"{this.Name}\":");
                userInput = Console.ReadLine();
                successParse = SByte.TryParse(userInput, out sbyte parsedRussianScores);

                if (!successParse)
                {
                    throw new EmployeeBuildException("Балл должен быть числом.");
                }

                if (parsedRussianScores < 1 || parsedRussianScores > 10)
                {
                    throw new EmployeeBuildException("Балл по Русскому языку должен быть равен значению от 1 до 10 включительно.");
                }

                this.RussianScores = parsedRussianScores;
            }

            if (this.HistoryScores == 0)
            {
                Console.WriteLine($"Введите баллы по Истории сотрудника \"{this.Name}\":");
                userInput = Console.ReadLine();
                successParse = SByte.TryParse(userInput, out sbyte parsedHistoryScores);

                if (!successParse)
                {
                    throw new EmployeeBuildException("Балл должен быть числом.");
                }

                if (parsedHistoryScores < 1 || parsedHistoryScores > 10)
                {
                    throw new EmployeeBuildException("Балл по Истории должен быть равен значению от 1 до 10 включительно.");
                }

                this.HistoryScores = parsedHistoryScores;
            }

            if (this.MathScores == 0)
            {
                Console.WriteLine($"Введите баллы по Математике сотрудника \"{this.Name}\":");
                userInput = Console.ReadLine();
                successParse = SByte.TryParse(userInput, out sbyte parsedMatchScores);

                if (!successParse)
                {
                    throw new EmployeeBuildException("Балл должен быть числом.");
                }

                if (parsedMatchScores < 1 || parsedMatchScores > 10)
                {
                    throw new EmployeeBuildException("Балл по Математике должен быть равен значению от 1 до 10 включительно.");
                }

                this.MathScores = parsedMatchScores;
            }

            Employee employee = new Employee(this.Name, this.Age, this.Height, this.RussianScores, this.HistoryScores, this.MathScores);
            employee.CalcAverageScore();

            return employee;
        }
    }
}
