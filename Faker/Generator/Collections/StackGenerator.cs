using System;
using System.Collections;

namespace Faker.Generator.Collections
{
    public class StackGenerator<T> : Generator
    {

        public StackGenerator()
        {
            
        }
        
        public override object Generate(GeneratorContext context)
        {
            var size = Random.Next(1, ConstSize);
            var stack = (Stack) Activator.CreateInstance(context.Type);
            
            for (int i = 0; i < size; i++)
            {
                stack.Push(context.Type.GetGenericArguments()[0]);
            }

            return stack;
        }

        public override string GetType()
        {
            return typeof(System.Collections.Generic.Stack<T>).ToString();
        }
    }
}