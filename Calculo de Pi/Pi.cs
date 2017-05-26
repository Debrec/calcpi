using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_Pi
{
    public class Pi
    {
        public double convertiradouble(string s)
        {
            double result;
            try
            {
                result = Convert.ToDouble(s);
                Console.WriteLine("Converted '{0}' to {1}.", s, result);
                return result;
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert '{0}' to a Double.", s);
                return -1;
            }
            catch (OverflowException)
            {
                Console.WriteLine("'{0}' is outside the range of a Double.", s);
                return -1;
            }
        }

        public int convertiraint(string s)
        {
            int result;
            try
            {
                result = Convert.ToInt32(s);
                Console.WriteLine("Converted '{0}' to {1}.", s, result);
                return result;
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert '{0}' to a Int.", s);
                return -1;
            }
            catch (OverflowException)
            {
                Console.WriteLine("'{0}' is outside the range of a Int.", s);
                return -1;
            }
        }

        double factorial(double Num)
        {
            if (Num > 1)
            {
                return Num * factorial(Num - 1);
            }
            else if (Num == 1)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        double f(double x, int Num)
        {
            double var = 0;
            for (int i = 0; i < Num; i++)
            {
                var = var + Math.Pow(x, 2 * i + 1) * Math.Pow(-1, i) / factorial(2 * i + 1);
            }
            return (0.5 - var);
        }

        double dfdx(double x, int Num)
        {
            double var = 0;
            for (int i = 0; i < Num; i++)
            {
                var = var + Math.Pow(x, 2 * i) * Math.Pow(-1, i) / factorial(2 * i);
            }
            return (var);
        }

        double puntofijo(double a, double tol, int Num, int nmax = 10000)
        {
            double xi = 0;
            double x = a;
            int max = 0;
            do
            {
                xi = x;
                x = xi + f(xi, Num);
                max++;
            } while ((Math.Abs(x - xi) > tol) && (max < nmax));
            if (max < nmax)
            {
                return x;
            }
            else
            {
                return -1;
            }
        }

        double newton_raphson(double a, double tol, int Num, int nmax = 1000)
        {
            double xi = 0;
            double x = a;
            int max = 0;
            do
            {
                xi = x;
                try
                {
                    x = xi - f(xi, Num) / dfdx(xi, Num);
                }
                catch (DivideByZeroException)
                {
                    return -1;
                }
                max++;

            } while ((Math.Abs(x - xi) > tol) && (max < nmax));
            if (max < nmax)
            {
                return x;
            }
            else
            {
                return -1;
            }
        }

        public double calculo_de_pi3(int num, System.Windows.Forms.ProgressBar p, double tol = 1e-15)
        {
            if (num <= 2000)
            {
                p.Step = num;
                double x0 = 0.5;
                double pi_6 = puntofijo(x0, tol, num);
                p.PerformStep();
                return 6 * pi_6;
            }
            else
            {
                return -1;
            }
        }

        public double calculo_de_pi2(int num, System.Windows.Forms.ProgressBar p, double tol = 1e-15)
        {
            if (num <= 2000)
            {
                p.Step = num;
                double x0 = 0.5;
                double pi_6 = newton_raphson(x0, tol, num);
                p.PerformStep();
                return 6 * pi_6;
            }
            else
            {
                return -1;
            }
        }

        public double calc_pi(int Num, System.Windows.Forms.ProgressBar p)
        {
            double var = 0;
            p.Step = 1; 
            for (int i = 0; i < Num; i++)
            {
                var = var + Math.Pow(-1.0, i) / (2 * i + 1);
                p.PerformStep();
            }
            return 4 * var;
        }

        double termino(double x, int i)
        {
            if (i == 0)
            {
                return 1;
            }
            else
            {
                return Math.Pow(x, i) / factorial(i);
            }
        }

        double calculo_e(double x, int Num)
        {
            double var = 0;
            for (int i = 0; i < Num; i++)
            {
                var = var + termino(x, i);
            }
            return var;
        }

        double calculo_elim(int Num)
        {
            double var = Math.Pow(1.0 + 1.0 / Num, Num);
            return var;
        }
    }
}
