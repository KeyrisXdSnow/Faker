﻿using System;

namespace Faker.Generator.ScalarValues
{
    public class FloatGenerator : Generator
    {
        public FloatGenerator()
        {
            
        }
        public override object Generate(GeneratorContext context)
        {
            double mantissa = (Random.NextDouble() * 2.0) - 1.0;
            double exponent = Math.Pow(2.0, Random.Next(-126, 128));
            
            return (float)(mantissa * exponent);
        }

        public override string GetType()
        {
            return typeof(float).ToString();
        }
    }
}