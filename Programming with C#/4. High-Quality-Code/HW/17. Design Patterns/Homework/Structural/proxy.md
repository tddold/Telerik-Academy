#Proxy
1.	Цел на шаблона - предоставяне на заместник или контейнер за даден реален обект, позволявайки контролиран достъп до него.
2.	Структура:



3.	Приложения: 
	-	има множество приложения – примерно: 
		- Aspect - Oriented Programming – AOP
		- Java RMI и т.н.

4.	Свързани шаблони – „Adaptor” и “Decorator”

Примерен код:

```

	namespace Proxy.Example
	{
	    using System;
	
	    /// <summary>
	    /// MainApp startup class
	    /// Proxy Design Pattern.
	    /// </summary>
	    public class MainApp
	    {
	        /// <summary>
	        /// Entry point into console application.
	        /// </summary>
	        public static void Main()
	        {
	            // Create math proxy
	            MathProxy proxy = new MathProxy();
	
	            // Do the math
	            Console.WriteLine("4 + 2 = {0}", proxy.Add(4, 2));
	
	            Console.WriteLine("4 - 2 = {0}", proxy.Sub(4, 2));
	
	            Console.WriteLine("4 * 2 = {0}", proxy.Mul(4, 2));
	
	            Console.WriteLine("4 / 2 = {0}", proxy.Div(4, 2));
	        }
	    }

		/// <summary>
	    /// The 'Subject interface
	    /// </summary>
	    public interface IMath
	    {
	        double Add(double x, double y);
	
	        double Sub(double x, double y);
	
	        double Mul(double x, double y);
	
	        double Div(double x, double y);
	    }
	
		/// <summary>
	    /// The 'RealSubject' class
	    /// </summary>
	    public class Math : IMath
	    {
	        public double Add(double x, double y)
	        {
	            return x + y;
	        }
	
	        public double Sub(double x, double y)
	        {
	            return x - y;
	        }
	
	        public double Mul(double x, double y)
	        {
	            return x * y;
	        }
	
	        public double Div(double x, double y)
	        {
	            return x / y;
	        }
	    }
	
		/// <summary>
	    /// The 'Proxy Object' class
	    /// </summary>
	    public class MathProxy : IMath
	    {
	        private Math math = new Math();
	
	        public double Add(double x, double y)
	        {
	            return this.math.Add(x, y);
	        }
	
	        public double Sub(double x, double y)
	        {
	            return this.math.Sub(x, y);
	        }
	
	        public double Mul(double x, double y)
	        {
	            return this.math.Mul(x, y);
	        }
	
	        public double Div(double x, double y)
	        {
	            return this.math.Div(x, y);
	        }
	    }
	}


```