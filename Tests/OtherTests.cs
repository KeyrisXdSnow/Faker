using System.Collections.Generic;
using FakerTest.DTO;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class OtherTests
    {
        private readonly Faker.Faker _faker = new Faker.Faker();

        [Test]
        public void TestCycleDependency()
        {
            var a = _faker.Create<A>();
            
            Assert.IsNotNull(a);
            Assert.IsNull(a.B);
            
            
        }
        
        [Test]
        public void TestIntType()
        {
            var boo = _faker.Create<int>();
            Assert.IsTrue(boo != 0);
        }
        
        [Test]
        public void TestIntList()
        {
            var boo = _faker.Create<List<int>>();
            Assert.IsNotNull(boo);
        }
        
        [Test]
        public void TestInt2xList()
        {
            var boo = _faker.Create<List<List<int>>>();
            Assert.IsNotNull(boo);
        }
        
        [Test]
        public void TestFooList()
        {
            var foo = _faker.Create<List<Foo>>();
            Assert.IsNotNull(foo);
        }
        
        [Test]
        public void TestFoo2xList()
        {
            var foo = _faker.Create<List<List<Foo>>>();
            Assert.IsNotNull(foo);
        }
    }
}