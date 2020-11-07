﻿using System;

namespace Faker.Generator
{
    public class DateGenerator : Generator
    {
        public DateGenerator(Faker faker) : base()
        {
        }

        public override object Generate( GeneratorContext context)
        {
            var year = Random.Next(1, int.MaxValue);
            var month = Random.Next(1, 12);
            var day = Random.Next(1, DateTime.DaysInMonth(year, month));
            
            return  new DateTime(year,month,day);
        }

        public override string GetType()
        {
            return typeof(DateTime).ToString();
        }
    }
}