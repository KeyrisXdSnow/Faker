using System;

namespace Faker.MainApp
{
    public class CycleDependencyException : Exception
    {
        public CycleDependencyException(string message) : base(message)
        {
            
        }
        
    }
}