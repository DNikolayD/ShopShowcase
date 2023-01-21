using System;
using System.Collections.Generic;
using System.Linq;

namespace ASP.NET_Skeleton.Common
{
    public static class AutoMapper
    {
        public static T MapTo<T>(this object entity)
        {
            var result = Activator.CreateInstance<T>()!;
            var type = typeof(T);
            if (type.CheckForNonGenerics())
            {
                result = entity.MapNonGenerics(result);
            } 
            if(type.CheckForGenerics())
            {
                result = entity.MapGenerics(result);
            }
            return result;
        }

        private static T MapNonGenerics<T>(this object entity, T result)
        { 
            result?.GetType()
                .GetProperties()
                .Where(p => !p.GetType().IsGenericType)
                .ToList()
                .ForEach(p => p.SetValue(result,
                    typeof(T).GetProperty(p.Name)!
                        .GetValue(entity)));
            return result;
        }

        private static T MapGenerics<T>(this object entity, T result)
        { 
            result!
                .GetType()
                .GetProperties()
                .Where(p => p.GetType().IsGenericType)
                .ToList()
                .FindAll(p => p.GetValue(p) != null)
                .ForEach(p =>
                {
                    p.SetValue(p, entity.GetType()
                        .GetProperty(p.Name)!
                        .GetValue(entity)!
                        .MapTo<List<object>>());
                });

            return result;
        }

        
    }
}