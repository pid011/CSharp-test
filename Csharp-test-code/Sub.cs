using System;
namespace Sub {
	class Circle {
		double pi = 3.14;

		double getArea(double radius) {
			return radius * radius * pi;
		}

		public void Print(double value) {
			Console.WriteLine(getArea(value));
		}
	}
}