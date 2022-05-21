using System;

namespace AdvancedCSharp {
	public class Point {
		public int X;
		public int Y;

		public Point(int x, int y) {
			this.X = x;
			this.Y = y;
		}

		public void Move(int x, int y) {
			this.X = x;
			this.Y = y;
		}

		public void Move(Point location) {
			if (location == null)
				throw new ArgumentNullException("location");

			Move(location.X, location.Y);
		}
	}
}
