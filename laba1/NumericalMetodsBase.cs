namespace laba1
{
	static class NumericalMetods
	{
		public static double Table(double a, double b, double h, Func<double, double> f)
		{
			//функція Table табулює функцію f на відрізку [a, b] з кроком h
			while (a <= b)
			{
				Console.WriteLine($"x: {a}; y:{f(a)}");
				a += h;
			}
			return 0;
		}

		public static double Dihotom(double a, double b, double eps, Func<double, double> f)//eps - точність
		{
			while (true)
			{
				var c = (a + b) / 2;
				if (f(c) == 0 || (b - a) / 2 < eps)
				{
					return c;
				}
				if (f(c) == f(a))
				{
					a = c;
				}
				else b = c;
			}
			throw new Exception("somth wrong");
			//функція  Dihotom шукає корінь функції f на відрізку [a, b] методом діленням пополам
		}
		public static double Hords(double a, double b, double eps, Func<double, double> f)//eps - точність
		{
			//функція  Hords шукає корінь функції f на відрізку [a, b] методом хорд
			while (Math.Abs(b - a) > eps)
			{
				a = a - (b - a) * f(a) / (f(b) - f(a));
				b = b - (a - b) * f(b) / (f(a) - f(b));
			}
			return b;
		}

		public static double Newton(double a, double b, double eps, Func<double, double> f, Func<double, double> df)//eps - точність
		{
			//функція  Newton шукає корінь функції f на відрізку [a, b] методом Ньютона, df - похідна f
			var x0 = a;
			double x1 = x0 - f(x0) / df(x0); // первое приближение
			while (Math.Abs(x1 - x0) > eps)
			{ // пока не достигнута точность 0.000001
				x0 = x1;
				x1 = x0 - f(x0) / df(x0); // последующие приближения
			}
			return x1;
		}

		public static double RectangleIntegral(double a, double b, int n, Func<double, double> f)//n - кількість розбиттів
		{
			//функція  RectangleIntegral обчислює визначений інтеграл функції f на відрізку [a, b] методом прямокутників
			var h = (b - a) / n;
			var sum = 0d;
			for (var i = 0; i <= n - 1; i++)
			{
				var x = a + i * h;
				sum += f(x);
			}
			var result = h * sum;
			return result;
		}

		public static double SimpsonIntegral(double a, double b, int n, Func<double, double> f)//n - кількість розбиттів
		{
			//функція  SimpsonIntegral обчислює визначений інтеграл функції f на відрізку [a, b] методом Сімпсона
			double h = (b - a) / n;
			double s = (f(a) + f(b)) * 0.5;
			for (int i = 1; i <= n - 1; i++)
			{
				double xk = a + h * i; //xk
				double xk1 = a + h * (i - 1); //Xk-1
				s += f(xk) + 2 * f((xk1 + xk) / 2);
			}
			var x = a + h * n; //xk
			var x1 = a + h * (n - 1); //Xk-1
			s += 2 * f((x1 + x) / 2);

			return s * h / 3.0;
		}
	}
}