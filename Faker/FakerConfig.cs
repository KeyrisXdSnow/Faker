using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Faker.Generator;

namespace Faker
{
    public class FakerConfig
    {
        private readonly Dictionary<MemberInfo, IGenerator> _generators;
        private List<Type> additionalTypes; 

        
        public FakerConfig()
        {
            _generators = new Dictionary<MemberInfo, IGenerator>();
        }
        
        public void Add<TClass, TMember, TGenerator>(Expression<Func<TClass, TMember>> expressionTree) where TGenerator: IGenerator
        {
            var generator = (IGenerator) Activator.CreateInstance<TGenerator>();

            var body = (MemberExpression)expressionTree.Body;
            var memberInfo = body.Member;
            _generators.Add(memberInfo, generator);
        }
        
        internal IGenerator GetGeneratorByName(string parameterName, Type objType)
        {
            foreach (var member in _generators.Keys)
            {
                if (member.Name.Equals(parameterName, StringComparison.OrdinalIgnoreCase) && member.DeclaringType == objType)
                {
                    _generators.TryGetValue(member, out var generator);
                    return generator;
                }
            }

            return null;
        }

        internal IGenerator GetGeneratorByMemberInfo(MemberInfo memberInfo)
        {
            _generators.TryGetValue(memberInfo, out var generator);
            return generator;
        }

    }
}