﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Faker.Generator.Collections
{
    public class ListGenerator : Generator
    {

        public ListGenerator()
        {
            
        }
        
        public override object Generate(GeneratorContext context)
        {
            var size = Random.Next(1, ConstSize);
            var list = (IList) Activator.CreateInstance(context.Type);

            for (int i = 0; i < size; i++)
            {
                list.Add(context.Faker.Create(context.Type.GetGenericArguments()[0]));
            }

            return list;
        }

        public override string GetType()
        {
            return "";
            //return typeof(List<T>).ToString();
        }
    }
}