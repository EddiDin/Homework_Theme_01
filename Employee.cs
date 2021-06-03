using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    class Employee
    {
        public sbyte Age { get; set; }
        public short Height { get; set; }
        public sbyte RussianScores { get; set; }
        public sbyte HistoryScores { get; set; }
        public sbyte MathScores { get; set; }
        public string Name { get; set; }
        public double AverageScore { get; set; }

        public Employee(string Name, sbyte Age, short Height, sbyte RussianScores, sbyte HistoryScores, sbyte MathScores)
        {
            this.Name = Name;
            this.Age = Age;
            this.Height = Height;

            this.RussianScores = RussianScores;
            this.HistoryScores = HistoryScores;
            this.MathScores = MathScores;
        }

        public void CalcAverageScore()
        {
            this.AverageScore = (double)(this.RussianScores + this.HistoryScores + this.MathScores) / 3;
        }

        public override string ToString()
        {
            return $"{Name,15} {Age,10} {Height,10} {RussianScores,10} {HistoryScores,10} {MathScores,10} {Math.Round(AverageScore, 2),12}";
        }
    }
}
