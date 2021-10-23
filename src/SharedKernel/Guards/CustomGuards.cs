using System;
using System.Collections.Generic;

namespace Ardalis.GuardClauses
{
    public static class CustomGuards
    {
        public static DateTimeOffset OutOfRange(this IGuardClause guardClause, DateTimeOffset input, 
            string parameterName, DateTimeOffset from, DateTimeOffset to)
        {
            return OutOfRange<DateTimeOffset>(guardClause, input, parameterName, from, to);
        }

        private static T OutOfRange<T>(this IGuardClause guardClause, T input,
            string parameterName, T from, T to)
        {
            Comparer<T> comp = Comparer<T>.Default;

            if(comp.Compare(from, to) > 0)
                throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}");
            
            if(comp.Compare(input, from) < 0 || comp.Compare(input, to) > 0)
                throw new ArgumentOutOfRangeException(parameterName, $"Input {parameterName} was out of range");
            
            return input;
        }
    }
}