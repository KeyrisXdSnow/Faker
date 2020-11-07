using System;

namespace Faker.Generator
{
    public class GeneratorContext
    {
        public Faker Faker { get; }
        public Type Type { get; }
        

        public GeneratorContext(Faker faker, Type type)
        {
            Faker = faker;
            Type = type;


        }
    }
}