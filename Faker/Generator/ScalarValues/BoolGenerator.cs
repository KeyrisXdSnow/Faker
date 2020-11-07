﻿using System;

namespace Faker.Generator.ScalarValues
{
    public class BoolGenerator : Generator
    {
        public BoolGenerator()
        {
            
        }
        public override object Generate(GeneratorContext context)
        {
            return Convert.ToBoolean(Random.Next(0, 1));
        }

        public override string GetType()
        {
            return typeof(bool).ToString();
        }
    }
}