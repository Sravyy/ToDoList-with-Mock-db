using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace todolists.tests
{
    [TestClass]
    public class ItemTests
    {
        [TestMethod]
        public void GetDescription_ReturnsItemDescription_String()
        {
            //Arrange
            var item = new Item();

            //Act
            var result = item.Description = "Wash the dog";

            //Assert
            Assert.AreEqual("Wash the dog", result);
        }
    }
}
