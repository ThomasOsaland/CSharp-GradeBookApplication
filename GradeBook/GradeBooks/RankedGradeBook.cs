

using GradeBook.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            this.Type = GradeBookType.Ranked;            
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5) throw new InvalidOperationException("less than 5 students");

            var Threshold = (int)Math.Ceiling(Students.Count * 0.2);
            var GradesHigherThanAverage = 0;

            foreach (var grade in Students)
            {
                if (grade.AverageGrade > averageGrade) GradesHigherThanAverage++;
            }

            if (GradesHigherThanAverage < Threshold) return 'A';
            if (GradesHigherThanAverage < Threshold*2) return 'B';
            if (GradesHigherThanAverage < Threshold*3) return 'C';
            if (GradesHigherThanAverage < Threshold*4) return 'D';

            return 'F';
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
            else
                base.CalculateStatistics();
            return;
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
            else
                base.CalculateStatistics();
            return;
        }
    }
}
