﻿namespace Faker.Generator
{
    public interface IGenerator
    {
        public object Generate(GeneratorContext context);
        public string GetType();
    }
}