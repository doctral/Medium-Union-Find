using Xunit;

namespace UnionFind.UnitTests
{
	public class QuickUnionTest
	{
		private IUnionFind unionFind = new QuickUnion(10);

		[Fact]
		public void WhenCall_Union_ShouldReturnCorrectComponentAndConnectedResults()
		{
			// Arrange
			var testDataSet = FakeUnionData.Data();

			// Act
			foreach (var obj in testDataSet)
			{
				int p = (int)obj[0];
				int q = (int)obj[1];
				int componentCount = (int)obj[2];
				int dot1 = (int)obj[3];
				int dot2 = (int)obj[4];
				bool res = (bool)obj[5];
				unionFind.Union(p, q);

				// Assert
				Assert.Equal(unionFind.Count(), componentCount);
				Assert.Equal(unionFind.Connected(dot1, dot2), res);
			}

		}
	}
}
