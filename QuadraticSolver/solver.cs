using System;

namespace QuadraticSolver
{
    public class Solver
    {
        public static (int rootCount, double? root1, double? root2) Solve(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new ArgumentException("a = 0 kvadrat tənlik deyil!");
            }

            double d = b * b - 4 * a * c;

            if (d < 0)
            {
                return (0, null, null); //No real root
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                return (1, x, null); // 1 real root
            }
            else
            {
                double sqrtD = Math.Sqrt(d);
                double x1 = (-b + sqrtD) / (2 * a);
                double x2 = (-b - sqrtD) / (2 * a);
                return (2, x1, x2); // 2 real root
            }
        }
    }
}