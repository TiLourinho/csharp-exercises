using System.Globalization;

namespace FixationExercises
{
    public class Student
    {
        public string? name;
        public double firstQuarter;
        public double secondQuarter;
        public double thirdQuarter;

        public double FinalGrade()
        {
            double calc = firstQuarter + secondQuarter + thirdQuarter;
            return calc;
        }

        public string IsApproved()
        {
            if (FinalGrade() < 60)
            {
                double gradeLeft = 60 - FinalGrade();
                return "REPROVADO";
            }
            else
            {
                return "APROVADO";
            }
        }
    }
}