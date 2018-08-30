using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PizzaApp.Test
{
    [TestClass]
    public class ToppingEquality
    {
        [TestMethod]
        public void Should_Be_Equal_When_Same_Elements()
        {
            var toppingOne = new Topping(new[] { "pepperoni", "beef" });
            var toppingTwo = new Topping(new[] { "beef", "pepperoni" });

            Assert.IsTrue(toppingOne.Equals(toppingTwo));
        }

        [TestMethod]
        public void Should_Have_Same_Hash_Code_When_Same_Elements()
        {
            var toppingOne = new Topping(new[] { "pepperoni", "beef" });
            var toppingTwo = new Topping(new[] { "beef", "pepperoni" });
                
            Assert.AreEqual(toppingOne.GetHashCode(), toppingTwo.GetHashCode());
        }
    }
}
