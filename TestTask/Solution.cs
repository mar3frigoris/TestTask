using System;
using System.Reflection;

namespace TestTask;

public class Solution
{
    public string solution(string S, string T)
    {
        if (S.Equals(T))
        {
            return "EQUAL";
        }
        if (S.Length == T.Length)
        {
            var difference = S.Zip(T, (s, t) => (s, t)).Where(tupleItem => tupleItem.s != tupleItem.t).ToList();
            if (difference.Count() == 1)
            {
                return $"REPLACE {difference.First().s} {difference.First().t}";
            }
            if (difference.Count() == 2)
            {
                if (difference.First().s == difference.Last().t && difference.First().t == difference.Last().s)
                {
                    return $"SWAP {difference.First().s} {difference.First().t}";
                }
            }
        }
        if (S.Length == (T.Length - 1))
        {
            for (int index = 0; index < S.Length; index++)
            {
                if (S[index] != T[index] && Enumerable.SequenceEqual(S.Skip(index), T.Skip(index + 1)))
                {
                    return $"INSERT {T[index]}";
                }
            }

        }

        return "IMPOSSIBLE";
    }
}