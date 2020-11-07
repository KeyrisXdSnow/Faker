using FakerTest.DTO;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ClassFooTests
    {
        private readonly Faker.Faker _faker = new Faker.Faker();
        
        [Test]
        public void TestClassFoo()
        {
            var foo = _faker.Create<Foo>();
            Assert.IsNotNull(foo);
        }
        
        [Test]
        public void TestClassFooConstructor()
        {
            var foo = _faker.Create<Foo>();
            Assert.IsTrue(foo.a != 0);
            Assert.IsTrue(foo.b != 0);
        }
        
        [Test]
        public void TestClassBoo()
        {
            var foo = _faker.Create<Foo>();
            Assert.IsNotNull(foo.Boo);
        }
        
        [Test]
        public void TestClassStrProperty()
        {
            var foo = _faker.Create<Foo>();
            Assert.IsNotNull(foo.Str);
        }

    }
}