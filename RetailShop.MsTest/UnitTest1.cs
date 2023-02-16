using RetailShop.Model.ViewModel;

namespace RetailShop.MsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetByName()
        {
            //Arrange
            var Expected = "Car";

            //Act
            ProductViewModelTestSeries product = new();
            ProductViewModel Actual= product.GetByName("Car");

            //Assert
            Assert.IsNotNull(Actual);
            Assert.AreEqual(Expected, Actual.Name);
        }
    }
}