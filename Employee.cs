using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    /// <summary>
    /// Класс работника
    /// </summary>
    class Employee
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возраст
        /// </summary>
        public sbyte Age { get; set; }

        /// <summary>
        /// Рост
        /// </summary>
        public short Height { get; set; }

        /// <summary>
        /// Балл по русскому
        /// </summary>
        public sbyte RussianScores { get; set; }

        /// <summary>
        /// Балл по истории
        /// </summary>
        public sbyte HistoryScores { get; set; }

        /// <summary>
        /// Балл по математике
        /// </summary>
        public sbyte MathScores { get; set; }

        /// <summary>
        /// Средний балл
        /// </summary>
        public double AverageScore { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Name">Имя</param>
        /// <param name="Age">Возраст</param>
        /// <param name="Height">Рост</param>
        /// <param name="RussianScores">Балл по русскому</param>
        /// <param name="HistoryScores">Балл по истории</param>
        /// <param name="MathScores">Балл по математике</param>
        public Employee(string Name, sbyte Age, short Height, sbyte RussianScores, sbyte HistoryScores, sbyte MathScores)
        {
            this.Name = Name;
            this.Age = Age;
            this.Height = Height;

            this.RussianScores = RussianScores;
            this.HistoryScores = HistoryScores;
            this.MathScores = MathScores;
        }

        /// <summary>
        /// Полсчет среднего балла
        /// </summary>
        public void CalcAverageScore()
        {
            this.AverageScore = (double)(this.RussianScores + this.HistoryScores + this.MathScores) / 3;
        }

        /// <summary>
        /// Форматированный вывод информации о сотруднике
        /// </summary>
        public override string ToString()
        {
            return $"{Name,15} {Age,10} {Height,10} {RussianScores,10} {HistoryScores,10} {MathScores,10} {Math.Round(AverageScore, 2),12}";
        }
    }
}
