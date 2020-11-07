﻿namespace Faker.Generator.ScalarValues
{
    public class DecimalGenerator : Generator
    {
        public DecimalGenerator()
        {
            
        }
        public override object Generate(GeneratorContext context)
        {
            byte scale = (byte) Random.Next(29);
            bool sign = Random.Next(2) == 1;
            
            return new decimal(Random.Next(),Random.Next(),Random.Next(), sign, scale);
        }

        public override string GetType()
        {
            return typeof(decimal).ToString();
        }
    }
}