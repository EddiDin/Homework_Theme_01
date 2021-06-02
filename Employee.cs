using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    class Employee
    {
        public int Age { get; set; }
        public int Height { get; set; }
        public int RussianScores { get; set; }
        public int HistoryScores { get; set; }
        public int MathScores { get; set; }
        public string Name { get; set; }

        public Employee(string Name, int Age, int Height, int RussianScores, int HistoryScores, int MathScores) {
            this.Name = Name;
            this.Age = Age;
            this.Height = Height;

            this.RussianScores = RussianScores;
            this.HistoryScores = HistoryScores;
            this.MathScores = MathScores;
        }

        
    }
}
