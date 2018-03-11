using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC_02.Rectangle_Area
{
	class Program
	{
		static void Main(string[] args)
		{
           // Here we parse the variables to double
			double width = double.Parse(Console.ReadLine());
			double height = double.Parse(Console.ReadLine());

		  // Here we print the rectangle area
			Console.WriteLine($"{width * height:F2}");

		}
	}
}