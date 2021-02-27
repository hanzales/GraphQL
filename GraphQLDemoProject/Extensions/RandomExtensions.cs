using System;
using System.Collections.Generic;

namespace GraphQLDemoProject.Extensions
{
    public static class RandomExtensions
    {
        public static T Random<T>(this List<T> enumerable)
        {
            var index = new Random().Next(0, enumerable.Count);
            return enumerable[index];
        }
    }
}