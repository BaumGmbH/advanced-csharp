namespace AdvancedCSharp {
	public class Generics<T> {

		public static bool IsOfType(object obj) {
			return obj is T;
		}
	}
}
