﻿using System;
using System.Collections;
using System.Collections.Generic;
using Faker.Generator;
using FakerTest.DTO;

namespace Faker.MainApp
{
    internal static class MainApp
    {
        private static void Main(string[] args)
        {

            Faker faker = new Faker();
            
            var foo = faker.Create<Foo>();
           
        }
        
        
       

    }
}
