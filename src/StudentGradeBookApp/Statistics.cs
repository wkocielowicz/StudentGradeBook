using System;

namespace StudentGradeBookApp
{
    public class Statistics
    {
        public double lowGrade;
        public double highGrade;
        public double sum;
        public double count;

        public Statistics()
        {
            lowGrade = double.MaxValue;
            highGrade = double.MinValue;
            sum = 0;
            count = 0;
        }

        public double Average
        {
            get
            {
                return sum / count;
            }
        }

        public void Add(double number)
        {
            sum += number;
            count++;
            lowGrade = Math.Min(lowGrade, number);
            highGrade = Math.Max(highGrade, number);
        }
    }
}