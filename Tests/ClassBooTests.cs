using System;
using Faker.DTO;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ClassBooTests
    {
        private readonly Faker.Faker _faker = new Faker.Faker();
        
        [Test]
        public void TestClassBooConstructor()
        {
            var boo = _faker.Create<Boo>();
            Console.WriteLine(boo);
            Assert.IsNotNull(boo);
        }
        
        [Test]
        public void TestClassIntFiledConstructor()
        {
            var boo = _faker.Create<Boo>();
            Assert.IsTrue(boo.a !=0);
        }
        
        [Test]
        public void TestClassCharFiledConstructor()
        {
            var boo = _faker.Create<Boo>();
            Assert.IsTrue(boo.b.ToString() != "");
        }
        
        [Test]
        public void TestClassDateTimeFiledConstructor()
        {
            var boo = _faker.Create<Boo>();
            Assert.IsNotNull(boo.c);
        }
        
        [Test]
        public void TestClassIntArray()
        {
            var boo = _faker.Create<Boo>();
            Assert.IsNotNull(boo.IntArray);
        }
        
        [Test]
        public void TestClassFloatProperty()
        {
            var boo = _faker.Create<Boo>();
            Assert.IsTrue(boo.d != 0.0);
        }
        
        [Test]
        public void TestClassPrivateIntFlied()
        {
            var boo = _faker.Create<Boo>();
            Assert.IsTrue(boo.GetE() == 0);
        }
    }
}