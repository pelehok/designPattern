using System;
using Bridge.Abstraction;
using Bridge.Net;
using Bridge.VB;

namespace Bridge
{
	class Program
	{
		static void Main(string[] args)
		{
			var data = new Data(3,2);
			Console.WriteLine(data.ToString());
			
			var calculator = new Calculator(data);
			calculator.Operations = new Sum();
            var sum = calculator.Calculate();
            Console.WriteLine("Sum = "+ sum);
			
			calculator.Operations = new Subtract();
            var sub = calculator.Calculate();
            Console.WriteLine("Sub = "+sub);

            var calculator1 = new Calculator(new Data(sum,sub));
            calculator1.Operations = new Multiplication();
			Console.WriteLine("Mult = "+ calculator1.Calculate());
			
			calculator1.Operations = new Division();
			Console.WriteLine("Div = "+ calculator1.Calculate());

            Console.ReadKey();
        }

	}
}