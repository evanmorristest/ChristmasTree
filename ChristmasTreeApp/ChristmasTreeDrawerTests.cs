using ChristmasTreeApp;

namespace ChristmasTreeTests
{
    [TestClass]
    public class ChristmasTreeDrawerTests
    {
        [TestMethod]
        public void BuildTree_Height3_ReturnsExpectedLines()
        {
            // Arrange
            var drawer = new ChristmasTreeDrawer();

            // Act
            string result = drawer.BuildTree(3);
            string[] lines = result.TrimEnd().Split('\n');

            // Assert
            Assert.HasCount(5, lines); // 1 wreath + 3 foliage + 1 trunk
            Assert.Contains("@", lines[0]);
            Assert.AreEqual("|", lines[^1].Trim());
        }

        [TestMethod]
        public void BuildTree_Height1_HasCorrectShape()
        {
            var drawer = new ChristmasTreeDrawer();
            string result = drawer.BuildTree(1);
            Assert.Contains("@", result);
            Assert.Contains("*", result);
            Assert.Contains("|", result);
        }
    }
}
