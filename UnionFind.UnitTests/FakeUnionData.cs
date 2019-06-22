using System.Collections.Generic;

namespace UnionFind.UnitTests
{
	public class FakeUnionData
	{
		public static IList<object[]> Data() {
			return new List<object[]> {
				new object[] { 4, 3, 9, 2, 5, false },
				new object[] { 3, 8, 8, 4, 8, true  },
				new object[] { 6, 5, 7, 4, 5, false },
				new object[] { 9, 4, 6, 4, 6, false },
				new object[] { 2, 1, 5, 2, 3, false },
				new object[] { 5, 0, 4, 1, 9, false },
				new object[] { 7, 2, 3, 2, 8, false },
				new object[] { 6, 1, 2, 7, 5, true  }
			};
		} 

	}
}
