using System;

namespace Faker.DTO
{
    public class Boo
    {
        // тестовая переменная для доп. задания. Должно быть равно рандомному значения
        public int CCC; 
        
        public int[] IntArray;
        public float d { get; set; }
        public int a { get; set; }

        public char b;
        public DateTime c { get; set; }
        
        private int e;

        public Boo(int a, char b, DateTime c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int GetE()
        {
            return e;
        }

    }

}