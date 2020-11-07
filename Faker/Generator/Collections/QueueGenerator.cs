using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Faker.Generator.Collections
{
    public class QueueGenerator<T> : Generator
    {

        public QueueGenerator()
        {
            
        }
        
        public override object Generate(GeneratorContext context)
        {
            var size = Random.Next(1, ConstSize);
            var stack = (Queue) Activator.CreateInstance(context.Type);
            
            for (int i = 0; i < size; i++)
            {
                stack.Enqueue(context.Faker.Create(context.Type.GetGenericArguments()[0]));
            }

            return stack;
        }

        public override string GetType()
        {
            return typeof(Queue<T>).ToString();
        }
    }
}