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
			Console.WriteLine("Sum = "+calculator.Calculate());
			
			calculator.Operations = new Subtract();
			Console.WriteLine("Sub = "+calculator.Calculate());
			
			calculator.Operations = new Multiplication();
			Console.WriteLine("Mult = "+calculator.Calculate());
			
			calculator.Operations = new Division();
			Console.WriteLine("Div = "+calculator.Calculate());
		}
	}
}