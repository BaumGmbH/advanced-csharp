using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp {
	class Programm {

		static void Main(string[] args) {
			Events.EventMain.Start();
		}

		#region Old Tutorial Content

		static void UseGenerics() {
			System.Console.WriteLine(Generics<int>.IsOfType("9"));
		}

		static void UseOut() {
			int number;
			bool result = int.TryParse("13", out number);

			if (result)
				System.Console.WriteLine(number);
			else
				System.Console.WriteLine("Conversion Failed");
		}

		static void UseParams() {
			var calc = new Calculator();

			System.Console.WriteLine(calc.Add(1));
			System.Console.WriteLine(calc.Add(1, 2));
			System.Console.WriteLine(calc.Add(1, 2, 3));
			System.Console.WriteLine(calc.Add(1, 2, 3, 4));
			System.Console.WriteLine(calc.Add(1, 2, 3, 4, 5));
			System.Console.WriteLine(calc.Add(1, 2, 3, 4, 5, 6));
		}

		static void UsePoints() {
			try {
				var point = new Point(10, 20);
				point.Move(40, 60);
				System.Console.WriteLine($"Point is at X: {point.X}, Y: {point.Y}");

				point.Move(new Point(100, 200));
				System.Console.WriteLine($"Point is at X: {point.X}, Y: {point.Y}");

				point.Move(null);
			} catch {
				System.Console.WriteLine("An error occured");
			}
		}

		#endregion
	}
}
