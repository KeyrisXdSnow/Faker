﻿
using System;
using Faker.Generator;

namespace IntGenerator
{
    public class IntGenerator : Generator
    {
        public IntGenerator()
        {
            
        }
        public override object Generate(GeneratorContext context)
        {
            return Random.Next(0, int.MaxValue);
        }

        public override string GetType()
        {
            return typeof(int).ToString();
        }
    }
}