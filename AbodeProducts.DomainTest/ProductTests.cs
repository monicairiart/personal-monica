using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbodeProducts.Domain;

namespace AbodeProducts.DomainTest
{
    [TestClass]
    public class ProductTests
    {
        [TestInitialize()]
        public void SetUp()
        {
            Product product = new Product();
        }
        [TestMethod]
        public void NameNotEmptyTest()
        {
            Product product = new Product();
            product.Name = "producto 1";
            Assert.AreNotEqual(product.Name, null);
        }
        [TestMethod]
        public void NameOneCharacterTest()
        {
            Product product = new Product();
            product.Name = "x";
            Assert.AreEqual(product.Name.Length, 1);
        }

        [TestMethod]
        public void NameManyCharactersTest()
        {
            Product product = new Product();
            product.Name = "producto 1";
            Assert.IsTrue(product.Name.Length > 1);
        }
        [TestMethod]
        public void ReleaseDateEmptyTest()
        {
            Product product = new Product();
            product.ReleaseDate = new DateTime();
            Assert.AreNotEqual(product.ReleaseDate, null);
        }
    }
}
