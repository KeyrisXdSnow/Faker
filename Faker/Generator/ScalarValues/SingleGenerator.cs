using System;

namespace Faker.Generator.ScalarValues
{
    public class SingleGenerator : Generator
    {
        public SingleGenerator()
        {
            
        }
        
        public override object Generate(GeneratorContext context)
        {
            return (Single) Random.NextDouble();
        }

        public override string GetType()
        {
            return typeof(Single).ToString();
        }
    }
}