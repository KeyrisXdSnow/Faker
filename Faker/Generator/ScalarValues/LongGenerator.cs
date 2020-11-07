﻿namespace Faker.Generator.ScalarValues
{
    public class LongGenerator : Generator
    {
        public LongGenerator()
        {
            
        }
        
        public override object Generate(GeneratorContext context)
        {
            long result = Random.Next(int.MinValue >> 32, int.MaxValue >> 32);
            
            result = (result << 32);
            result = result | Random.Next(int.MinValue, int.MaxValue);
            
            return result;
            
        }

        public override string GetType()
        {
            return typeof(long).ToString();
        }
    }
}