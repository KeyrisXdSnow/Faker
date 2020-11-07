﻿using System;

namespace Faker.Generator.ScalarValues
{
    public class DoubleGenerator : Generator
    {
        public DoubleGenerator()
        {
            
        }
        
        public override object Generate(GeneratorContext context)
        {
            return Random.NextDouble();
        }

        public override string GetType()
        {
            return typeof(double).ToString();
        }
    }
}