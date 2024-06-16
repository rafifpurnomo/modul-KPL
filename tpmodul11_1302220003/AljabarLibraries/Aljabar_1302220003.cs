namespace AljabarLibraries
{
    public class Aljabar_1302220003
    {
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                throw new Exception("Akar persamaan kuadrat tidak real");
            }

            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            return new double[] { root1, root2 };
        }

        public static double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];

            double aSquared = a * a;
            double abTimesTwo = 2 * a * b;
            double bSquared = b * b;

            return new double[] { aSquared, abTimesTwo, bSquared };
        }
    }
}