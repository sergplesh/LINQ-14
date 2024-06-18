using GeometrucShapeCarLibrary;
using LINQ_лаб__14;

namespace TestQuery
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MaxLength()
        {
            // Arrange
            List<Page> pages = new List<Page>
                {
                    new Page { ContentPage = new Dictionary<int, Shape> { { 1, new Rectangle("элемент", 1, 10, 20) }, { 2, new Circle("элемент", 1, 15) } } },
                    new Page { ContentPage = new Dictionary<int, Shape> { { 1, new Rectangle("элемент", 1, 5, 15) }, { 2, new Circle("элемент", 1, 25) } } }
                };

            // Act
            double result = Query.MaxLength(pages);

            // Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void MinLength()
        {
            // Arrange
            List<Page> pages = new List<Page>
                {
                    new Page { ContentPage = new Dictionary<int, Shape> { { 1, new Rectangle("элемент", 1, 10, 20) }, { 2, new Circle("элемент", 1, 15) } } },
                    new Page { ContentPage = new Dictionary<int, Shape> { { 1, new Rectangle("элемент", 1, 5, 15) }, { 2, new Circle("элемент", 1, 25) } } }
                };

            // Act
            double result = Query.MinLength(pages);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Volume()
        {
            // Arrange
            List<Page> pages = new List<Page>
                {
                    new Page { ContentPage = new Dictionary<int, Shape> { { 1, new Parallelepiped("элемент", 1, 10, 20, 30) }, { 2, new Circle("элемент", 1, 15) } } },
                    new Page { ContentPage = new Dictionary<int, Shape> { { 1, new Rectangle("элемент", 1, 5, 15) }, { 2, new Circle("элемент", 1, 25) } } }
                };

            // Act
            double result = Query.AverageVolume(pages);

            // Assert
            Assert.AreEqual(6000, result);
        }

        //[TestMethod]
        //public void VolumeLINQ()
        //{
        //    // Arrange
        //    List<Page> pages = new List<Page>
        //        {
        //            new Page { ContentPage = new Dictionary<int, Shape> { { 1, new Parallelepiped("элемент1", 1, 10, 20, 30) }, { 2, new Circle("элемент2", 1, 15) } } },
        //            new Page { ContentPage = new Dictionary<int, Shape> { { 1, new Rectangle("элемент3", 1, 5, 15) }, { 2, new Circle("элемент4", 1, 25) } } }
        //        };

        //    // Act
        //    var result = Query.VolumeLINQ(pages);

        //    // Assert
        //    foreach (var page in result)
        //    {
        //        Assert.IsTrue(page.Name == "элемент1");
        //        Assert.IsTrue(page.Volume == 6000);
        //    }
        //}
    }
}