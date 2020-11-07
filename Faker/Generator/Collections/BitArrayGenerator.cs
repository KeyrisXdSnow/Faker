using System;
using System.Collections;

namespace Faker.Generator.Collections
{
    public class BitArrayGenerator : Generator
    {
        public BitArrayGenerator()
        {
            
        }
        
        public override object Generate(GeneratorContext context)
        {
            var size = Random.Next(1, ConstSize);
            var array = new bool[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToBoolean(Random.Next(0, 1));
            }
            
            return new BitArray(array);
        }

        public override string GetType()
        {
            return typeof(BitArray).ToString();
        }
    }
}