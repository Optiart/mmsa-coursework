using DjikstaAndFloydWarshall;
using FluentAssertions;
using Xunit;

namespace Tests
{
    public class Tests
    {
        [Theory]
        [InlineData(0, 3, 9, new[] { 0, 2, 1, 3 })]
        [InlineData(0, 1, 3, new[] { 0, 2, 1 })]
        [InlineData(0, 0, 0, new[] { 0 })]
        [InlineData(2, 3, 7, new[] { 2, 1, 3 })]
        public void FindsCorrectForFourVertices_DijkstraAlgorithm(int start, int target, int expectedDistance, int[] expectedRoute)
        {
            var dijkstra = new DijkstraRouteFinder();
            FindsCorrectForFourVertices(dijkstra, start, target, expectedDistance, expectedRoute);
        }

        [Theory]
        [InlineData(0, 3, 9, new[] { 0, 2, 1, 3 })]
        [InlineData(0, 1, 3, new[] { 0, 2, 1 })]
        [InlineData(0, 0, 0, new[] { 0 })]
        [InlineData(2, 3, 7, new[] { 2, 1, 3 })]
        public void FindsCorrectForFourVertices_FloydWarshalAlgorithm(int start, int target, int expectedDistance, int[] expectedRoute)
        {
            var floydWarshall = new FloydWarshallRouteFinder();
            FindsCorrectForFourVertices(floydWarshall, start, target, expectedDistance, expectedRoute);
        }

        private void FindsCorrectForFourVertices(IFastestRouteFinder algorithm, int start, int target, int expectedDistance, int[] expectedRoute)
        {
            // Arrange
            /* 0 --- 1 --- 3
             * |     |     |
             *  ---- 2 ----
             */
            var graph = new int[,]
            {
                { 0, 5, 2, -1 },
                { 5, 0, 1, 6 },
                { 2, 1, 0, 8 },
                { -1, 6, 8, 0 }
            };

            // Act
            var result = algorithm.Find(graph, start, target);

            // Assert
            result.Distance.Should().Be(expectedDistance);
            result.Route.Should().BeEquivalentTo(expectedRoute);
        }

        [Theory]
        [InlineData(0, 5, 14, new[] { 0, 2, 4, 5 })]
        [InlineData(1, 7, 18, new[] { 1, 0, 2, 4, 7 })]
        [InlineData(7, 6, 22, new[] { 7, 5, 6 })]
        public void FindsCorrectForEightVertices_Dijkstra(int start, int target, int expectedDistance, int[] expectedRoute)
        {
            var dijkstra = new DijkstraRouteFinder();
            FindsCorrectForEightVertices(dijkstra, start, target, expectedDistance, expectedRoute);
        }

        [Theory]
        [InlineData(0, 5, 14, new[] { 0, 2, 4, 5 })]
        [InlineData(1, 7, 18, new[] { 1, 0, 2, 4, 7 })]
        [InlineData(7, 6, 22, new[] { 7, 5, 6 })]
        public void FindsCorrectForEightVertices_FloydWarshal(int start, int target, int expectedDistance, int[] expectedRoute)
        {
            var floydWarshall = new FloydWarshallRouteFinder();
            FindsCorrectForEightVertices(floydWarshall, start, target, expectedDistance, expectedRoute);
        }

        private void FindsCorrectForEightVertices(IFastestRouteFinder algorithm, int start, int target, int expectedDistance, int[] expectedRoute)
        {
            // Arrange
            var graph = new int[,]
            {
                {  0,  2,  3, -1, -1, -1,  -1,  -1 },
                {  2,  0, -1,  7, -1, -1 , -1,  -1},
                {  3, -1,  0,  9,  4, -1,  -1 , -1},
                { -1,  7,  9,  0, -1,  6,   5,  -1 },
                { -1, -1,  4, -1,  0,  7,  -1,   9 },
                { -1, -1, -1,  6,  7,  0,   10,  12 },
                { -1, -1, -1,  5, -1,  10,  0,  -1 },
                { -1, -1, -1, -1,  9,  12, -1,   0 }
            };

            var dijkstra = new DijkstraRouteFinder();

            // Act
            var result = algorithm.Find(graph, start, target);

            // Assert
            result.Distance.Should().Be(expectedDistance);
            result.Route.Should().BeEquivalentTo(expectedRoute);
        }
    }
}
