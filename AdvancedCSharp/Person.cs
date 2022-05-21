using System;

namespace AdvancedCSharp {
	public class Person {
		public string Name;

		private DateTime birthday;

		public void SetBirthday(DateTime birthday) {
			if (birthday != null)
				this.birthday = birthday;
		}

		public DateTime GetBirthday() {
			return birthday;
		}
	}
}
