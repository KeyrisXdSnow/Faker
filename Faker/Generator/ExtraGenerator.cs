namespace Faker.Generator
{
    
    //  генератор для доп задания
    // для простоты просто возвращает 101  
    public class ExtraGenerator : IGenerator
    {
        public object Generate(GeneratorContext context)
        {
            return 101;
        }

        public new string GetType()
        {
            return typeof(string).ToString(); 
        }
    }
}