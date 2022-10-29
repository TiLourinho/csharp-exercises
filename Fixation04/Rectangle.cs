namespace FixationExercises
{
    public class Rectangle
    {
        public double width;
        public double height;

        public double Area()
        {
            double calc = width * height;
            return calc;
        }

        public double Perimeter()
        {
            double calc =  2 * (width + height);
            return calc;
        }

        public double Diagonal()
        {
            double calc = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            return calc;
        }
    }
}
